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

        public IEnumerable<Plato> GetAllFiltering(string filter)
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
                        throw new Exception("Plato no encontrado");
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

        public int Delete(Plato p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.DeletePlato, p, null, null, CommandType.Text);
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
