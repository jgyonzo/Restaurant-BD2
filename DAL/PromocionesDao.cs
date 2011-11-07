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

        public IEnumerable<Plato_Promocion> GetPlatos(Promocion p)
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

        public IEnumerable<Promocion> GetAllFiltering(string filter)
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

        public int Update(Promocion p, IEnumerable platos)
        {
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
                        return -1;
                    }
                    if (DeleteAllPlatos(p,conn,trans) == -1)
                    {
                        //Update de platos no realizado
                        return -1;
                    }
                    foreach (var obj in platos)
                    {
                        var plato = obj as Plato;
                        Plato_Promocion pp = new Plato_Promocion();
                        pp.Plato_Id = plato.Id;
                        pp.Promocion_Id = p.Id;
                        if (conn.Execute(Constants.InsertPlatoPromo, pp, trans, null, CommandType.Text) == -1)
                        {
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
                finally
                {
                    trans.Commit();
                    conn.Close();
                }
            }
            return 1;
        }

        public int Insert(Promocion p, IEnumerable platos)
        {
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
                        return -1;
                    }
                    
                    long id = conn.Query<long>(Constants.SelectLastId, null, trans, true, null, CommandType.Text).ElementAt(0);

                    foreach (var obj in platos)
                    {
                        Plato plato = obj as Plato;
                        Plato_Promocion pp = new Plato_Promocion();
                        pp.Plato_Id = plato.Id;
                        pp.Promocion_Id = Convert.ToUInt32(id);
                        if (conn.Execute(Constants.InsertPlatoPromo, pp, trans, null, CommandType.Text) == -1)
                        {
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
                finally
                {
                    trans.Commit();
                    conn.Close();
                }
            }
            return 1;
        }

        public int Delete(Promocion p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                MySqlTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    if (conn.Execute(Constants.DeletePromo, p, trans, null, CommandType.Text) == -1)
                    {
                        //Promo not updated
                        return -1;
                    }
                    if (DeleteAllPlatos(p, conn, trans) == -1)
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
                finally
                {
                    trans.Commit();
                    conn.Close();
                }
            }
            return 1;
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
    }
}
