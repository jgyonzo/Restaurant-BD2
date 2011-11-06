using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class MesaDao
    {
        public IEnumerable<Mesa> GetAll()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Mesa>(Constants.SelectAllMesas, null, null, true, null, CommandType.Text);
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

        public IEnumerable<Sector> getAllSectores()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Sector>(Constants.SelectAllSectores, null, null, true, null, CommandType.Text);
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

        public int Insert(Mesa p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.InsertMesa, p, null, null, CommandType.Text);
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

        public int Delete(Mesa p)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.DeleteMesa, p, null, null, CommandType.Text);
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
