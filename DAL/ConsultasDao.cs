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
        public static Mozo GetMozoTop(string from, string to)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"select mozo_id from ventas where estado= 'CERRADA' and fecha >= str_to_date('" + from + "','%d/%m/%Y %H:%i:%s') and fecha <= str_to_date('" + to + "','%d/%m/%Y  %H:%i:%s') group by mozo_id having count(1) = (select max(total) from (select mozo_id, count(1) total from ventas where estado = 'CERRADA' and fecha >= str_to_date('" + from + "','%d/%m/%Y  %H:%i:%s') and fecha <= str_to_date('" + to + "','%d/%m/%Y  %H:%i:%s') group by mozo_id) temp)";
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

        public static IEnumerable<ComidaTop> GetComidaTop(string from, string to)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    string query = @"select p.plato_id, (count(1) * p.cantidad) cantidad,
                                        (select descripcion from platos pl where pl.id = p.plato_id) as descripcion,
                                        (select rubro from platos pl where pl.id = p.plato_id) as rubro
                                        from ventas v, pedidos p
                                        where v.id = p.venta_id
                                        and estado= 'CERRADA' 
                                        and fecha >= str_to_date('" + from + @"','%d/%m/%Y %H:%i:%s') 
                                        and fecha <= str_to_date('" + to + @"','%d/%m/%Y  %H:%i:%s')
                                        group by p.plato_id
                                        order by count(1) * p.cantidad desc
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
    }
}
