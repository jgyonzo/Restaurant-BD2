using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using DAL.Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PlatoDao
    {
        public IEnumerable<Plato> GetAll()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Plato>(Constants.SelectAllPlatos, null, null, true, null, CommandType.Text);
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

        public IEnumerable<Plato> SearchByDesc(string filter)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    string SelectAllPlatosFiltering = "select * from platos where upper(descripcion) like ('%"+ filter.ToUpper() +"%') order by rubro,descripcion";
                    conn.Open();
                    var lista = conn.Query<Plato>(SelectAllPlatosFiltering, null, null, true, null, CommandType.Text);
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

        public IEnumerable<Plato> SearchByDescDisponible(string filter)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    string SelectAllPlatosFiltering = "select * from platos where upper(descripcion) like ('%" + filter.ToUpper() + "%') and estado = 'DISPONIBLE' order by rubro,descripcion";
                    conn.Open();
                    var lista = conn.Query<Plato>(SelectAllPlatosFiltering, null, null, true, null, CommandType.Text);
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

        public IEnumerable<Plato> SearchByRubro(string rubro)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    string SelectAllPlatosFiltering = "select * from platos where rubro = '" + rubro + "' order by descripcion";
                    conn.Open();
                    var lista = conn.Query<Plato>(SelectAllPlatosFiltering, null, null, true, null, CommandType.Text);
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

        public IEnumerable<Plato> SearchByEstado(string estado)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Plato>(Constants.SearchPlatosByEstado, new { Estado = estado}, null, true, null, CommandType.Text);
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

        public Plato GetOne(UInt32 id)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Plato>(Constants.SelectOnePlato, new {Id = id}, null, true, null, CommandType.Text);
                    if (lista.Count() == 0)
                    {
                        return null;
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

        public int Update(Plato p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.UpdatePlato, p, null, null, CommandType.Text);
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

        public int Insert(Plato p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.InsertPlato, p, null, null, CommandType.Text);
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

        public void Inactivate(Plato p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                MySqlTransaction trans = null;
                try
                {
                    conn.Open();
                    trans = conn.BeginTransaction();
                    if (conn.Execute(Constants.DeletePlato, p, null, null, CommandType.Text) == -1)
                    {
                        throw new DataException("Error al actualizar como NO DISPONIBLE un plato");
                    }
                    PromocionesDao promoDao = new PromocionesDao();
                    var promos = promoDao.GetPromosByPlato(p);
                    foreach (var pr in promos)
                    {
                        if (promoDao.Inactivate(pr.Promocion_Id, conn, trans) == -1)
                        {
                            throw new DataException("Error al actualizar como NO DISPONIBLE la promocion con id =" + pr.Promocion_Id +  " asociada al plato");
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

        public int Activate(Plato p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.ActivatePlato, p, null, null, CommandType.Text);
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
