using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using DAL.Entities;
using MySql.Data.MySqlClient;
using System.Collections;

namespace DAL
{
    public class PromocionesDao
    {
        public IEnumerable<Promocion> GetAll()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Promocion>(Constants.SelectAllPromociones, null, null, true, null, CommandType.Text);
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public Promocion GetOne(UInt32 id)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Promocion>(Constants.SelectPromocion, new { Id = id }, null, true, null, CommandType.Text);
                    if (lista.Count() == 0)
                    {
                        throw new Exception("Promo no encontrada");
                    }
                    return lista.ElementAt(0);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public IEnumerable<Plato_Promocion> GetPlatosByPromo(Promocion p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Plato_Promocion>(Constants.SelectPlatosByPromo, p, null, true, null, CommandType.Text);
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Devuelve todas las promociones en las que participa el plato
        /// </summary>
        public IEnumerable<Plato_Promocion> GetPromosByPlato(Plato p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Plato_Promocion>(Constants.SelectPromosByPlato, p, null, true, null, CommandType.Text);
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public IEnumerable<Promocion> SearchByDesc(string filter)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    string SelectAllPlatosFiltering = "select * from promociones where upper(descripcion) like ('%" + filter.ToUpper() + "%') order by descripcion";
                    conn.Open();
                    var lista = conn.Query<Promocion>(SelectAllPlatosFiltering, null, null, true, null, CommandType.Text);
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public IEnumerable<Promocion> SearchByEstado(string estado)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Promocion>(Constants.SearchPromocionesByEstado, new { Estado = estado}, null, true, null, CommandType.Text);
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void Update(Promocion p, IEnumerable<Plato> platos)
        {
            if (platos == null || platos.Count() == 0)
            {
                throw new DataException("No se pueden quitar todos los platos de una promoción");
            }
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                MySqlTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    if (conn.Execute(Constants.UpdatePromo, p, trans, null, CommandType.Text) == -1)
                    {
                        //Promo not updated
                        throw new DataException("Error al actualizar la promoción");
                    }
                    if (DeleteAllPlatos(p, conn, trans) == -1)
                    {
                        //Update de platos no realizado
                        throw new DataException("Error al actualizar los platos asociados a la promoción");
                    }
                    foreach (var plato in platos)
                    {
                        Plato_Promocion pp = new Plato_Promocion();
                        pp.Plato_Id = plato.Id;
                        pp.Promocion_Id = p.Id;
                        if (conn.Execute(Constants.InsertPlatoPromo, pp, trans, null, CommandType.Text) == -1)
                        {
                            throw new DataException("Error al actualizar los platos asociados a la promoción");
                        }
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Genera una nueva promocion con los platos asociados, si algo sale mal, lanza exception
        /// </summary>
        public void Insert(Promocion p, IEnumerable<Plato> platos)
        {
            if (platos == null || platos.Count() == 0)
            {
                throw new DataException("No se puede generar una promoción sin platos asociados");
            }
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                MySqlTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    if (conn.Execute(Constants.InsertPromo, p, trans, null, CommandType.Text) == -1)
                    {
                        //Promo not updated
                        throw new DataException("Error al generar la nueva promoción");
                    }
                    
                    long id = conn.Query<long>(Constants.SelectLastId, null, trans, true, null, CommandType.Text).ElementAt(0);

                    foreach (var plato in platos)
                    {
                        Plato_Promocion pp = new Plato_Promocion();
                        pp.Plato_Id = plato.Id;
                        pp.Promocion_Id = Convert.ToUInt32(id);
                        if (conn.Execute(Constants.InsertPlatoPromo, pp, trans, null, CommandType.Text) == -1)
                        {
                            throw new DataException("Error al generar la nueva promoción");
                        }
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int Inactivate(Promocion p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.DeletePromo, p, null, null, CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw new DataException("Error al marcar como no disponible una promocion", ex);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int Inactivate(UInt32 promoId, MySqlConnection conn, MySqlTransaction trans)
        {
            try
            {
                return conn.Execute(Constants.DeletePromo, new { Id = promoId}, trans, null, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new DataException("Error al marcar como no disponible una promocion", ex);
            }
        }

        public int DeleteAllPlatos(Promocion p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.DeletePlatosByPromo, p, null, null, CommandType.Text);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public int DeleteAllPlatos(Promocion p, MySqlConnection conn, MySqlTransaction trans)
        {
            try
            {
                return conn.Execute(Constants.DeletePlatosByPromo, p, trans, null, CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Activate(Promocion p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var platos = GetPlatosByPromo(p);
                    PlatoDao platoDao = new PlatoDao();
                    foreach (var pl in platos)
                    {
                        var plato = platoDao.GetOne(pl.Plato_Id);
                        if (plato.Estado != "DISPONIBLE")
                        {
                            throw new DataException("No se puede marcar como DISPONIBLE una promoción que contiene platos NO DISPONIBLES");
                        }
                    }
                    if (conn.Execute(Constants.ActivatePromo, p, null, null, CommandType.Text) == -1)
                    {
                        throw new DataException("No se actualizó la promoción como DISPONIBLE");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
