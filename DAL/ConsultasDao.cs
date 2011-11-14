using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using DAL.Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ConsultasDao
    {
        public static Mozo GetMozoTop()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"select mozo_id from ventas where estado= 'CERRADA'group by mozo_id having count(1) = (select max(total) from (select mozo_id, count(1) total from ventas where estado = 'CERRADA' group by mozo_id) temp)";
                    var lista = conn.Query<UInt32>(query, null, null, true, null, CommandType.Text);
                    if (lista.Count() == 0)
                    {
                        return null;
                    }
                    UInt32 mozoId = lista.ElementAt(0);
                    string selectMozo = "select * from mozos where id = @Mozo_Id";
                    var mozoInfo = conn.Query<Mozo>(selectMozo, new { Mozo_Id = mozoId} , null, true, null, CommandType.Text);
                    if (mozoInfo.Count() == 0)
                    {
                        return null;
                    }
                    return mozoInfo.ElementAt(0);
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

        public static IEnumerable<ComidaTop> GetComidasTop(string from, string to)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"select p.plato_id, (sum(p.cantidad)) cantidad,
                                        (select descripcion from platos pl where pl.id = p.plato_id) as descripcion,
                                        (select rubro from platos pl where pl.id = p.plato_id) as rubro
                                        from ventas v, pedidos p
                                        where v.id = p.venta_id
                                        and estado= 'CERRADA' 
                                        and fecha >= str_to_date('" + from + @"','%d/%m/%Y %H:%i:%s') 
                                        and fecha <= str_to_date('" + to + @"','%d/%m/%Y  %H:%i:%s')
                                        group by p.plato_id
                                        order by (sum(p.cantidad)) desc
                                        limit 0, 10";
                    var lista = conn.Query<ComidaTop>(query, null, null, true, null, CommandType.Text);
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

        public static IEnumerable<ComidaTop> GetComidasByRubro(string from, string to)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"select  pl.rubro as RUBRO, pl.descripcion as DESCRIPCION, pl.id AS PLATO_ID, (sum(p.cantidad)) as CANTIDAD
                                        from ventas v, pedidos p, platos pl
                                        where v.id = p.venta_id
                                        and pl.id = p.plato_id
                                        and v.estado= 'CERRADA'
                                        and fecha >= str_to_date('" + from + @"','%d/%m/%Y %H:%i:%s') 
                                        and fecha <= str_to_date('" + to + @"','%d/%m/%Y  %H:%i:%s')
                                        group by pl.id,pl.rubro
                                        order by rubro,(sum(p.cantidad)) DESC";
                    var lista = conn.Query<ComidaTop>(query, null, null, true, null, CommandType.Text);
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

        public static IEnumerable<PromoTop> GetPromosVendidas(string from, string to)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.id as Promo_Id, p.descripcion, SUM(vp.cantidad) cantidad
                                        FROM ventas v, ventas_promociones vp, promociones p
                                        where v.id = vp.venta_id
                                        and p.id = vp.promocion_id
                                        and v.estado = 'CERRADA'
                                        and fecha >= str_to_date('" + from + @"','%d/%m/%Y %H:%i:%s') 
                                        and fecha <= str_to_date('" + to + @"','%d/%m/%Y  %H:%i:%s')
                                        GROUP BY p.id
                                        ORDER BY (SUM(vp.cantidad)) desc";
                    var lista = conn.Query<PromoTop>(query, null, null, true, null, CommandType.Text);
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

        public static IEnumerable<MozosTop> GetMozosTop(string from, string to)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT m.dni, m.nombre, m.sector, count(1) as ventas_realizadas
                                        FROM ventas v, mozos m
                                        where v.mozo_id = m.id
                                        and v.estado = 'CERRADA'
                                        and fecha >= str_to_date('" + from + @"','%d/%m/%Y %H:%i:%s') 
                                        and fecha <= str_to_date('" + to + @"','%d/%m/%Y  %H:%i:%s')
                                        GROUP BY m.id
                                        ORDER BY count(1) desc";
                    var lista = conn.Query<MozosTop>(query, null, null, true, null, CommandType.Text);
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
    }
}
