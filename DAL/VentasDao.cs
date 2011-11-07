using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Entities;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class VentasDao
    {
        public IEnumerable<Venta> GetAbiertas()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Venta>(Constants.SelectVentasAbiertas, null, null, true, null, CommandType.Text);
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

        public Venta GetOne(UInt32 id)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Venta>(Constants.SelectOneVenta, new { Id = id }, null, true, null, CommandType.Text);
                    if (lista.Count() == 0)
                    {
                        throw new Exception("Venta no encotrada");
                    }
                    else
                    {
                        return lista.ElementAt(0);
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

        public int Insert(Venta v)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.InsertVenta, v, null, null, CommandType.Text);
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

        public int Close(Venta v)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    return conn.Execute(Constants.CerrarVenta, v, null, null, CommandType.Text);
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

        public IEnumerable<Venta_Promocion> GetPromos(Venta v)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Venta_Promocion>(Constants.SelectPromosByVenta, v, null, true, null, CommandType.Text);
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

        public IEnumerable<Pedido> GetPedidos(Venta v)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    var lista = conn.Query<Pedido>(Constants.SelectPlatosByVenta, v, null, true, null, CommandType.Text);
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

        public int AddPedido(UInt32 pedido_id, UInt32 venta_id, float precio)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    conn.Execute(Constants.UpdatePrice, new { Precio = precio, Id = venta_id }, null, null, CommandType.Text);
                    var existe = conn.Query<Pedido>(Constants.ExistPedido, new { Plato_Id = pedido_id , Venta_Id = venta_id}, null, true, null, CommandType.Text);
                    if (existe.Count() == 0)
                    {
                        return conn.Execute(Constants.InsertPedido, new { Plato_Id = pedido_id, Venta_Id = venta_id }, null, null, CommandType.Text);
                    }
                    else
                    {
                        return conn.Execute(Constants.AddPedido, new { Plato_Id = pedido_id, Venta_Id = venta_id }, null, null, CommandType.Text);
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

        public int AddPromo(UInt32 promo_id, UInt32 venta_id, float precio)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    conn.Execute(Constants.UpdatePrice, new { Precio = precio, Id = venta_id }, null, null, CommandType.Text);
                    var existe = conn.Query<Venta_Promocion>(Constants.ExistPromo, new { Promocion_Id = promo_id, Venta_Id = venta_id }, null, true, null, CommandType.Text);
                    if (existe.Count() == 0)
                    {
                        return conn.Execute(Constants.InsertVenta_Promo, new { Promocion_Id = promo_id, Venta_Id = venta_id }, null, null, CommandType.Text);
                    }
                    else
                    {
                        return conn.Execute(Constants.AddPromo, new { Promocion_Id = promo_id, Venta_Id = venta_id }, null, null, CommandType.Text);
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

        public int RemovePedido(UInt32 pedido_id, UInt32 venta_id, float precio)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    conn.Execute(Constants.UpdatePrice, new { Precio = (precio*-1), Id = venta_id }, null, null, CommandType.Text);
                    var existe = conn.Query<Pedido>(Constants.ExistPedido, new { Plato_Id = pedido_id, Venta_Id = venta_id }, null, true, null, CommandType.Text);
                    if (existe.ElementAt(0).Cantidad <= 1)
                    {
                        return conn.Execute(Constants.DeletePedido, new { Plato_Id = pedido_id, Venta_Id = venta_id }, null, null, CommandType.Text);
                    }
                    else
                    {
                        return conn.Execute(Constants.SubsPedido, new { Plato_Id = pedido_id, Venta_Id = venta_id }, null, null, CommandType.Text);
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

        public int RemovePromo(UInt32 promo_id, UInt32 venta_id, float precio)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.QueryConn))
            {
                try
                {
                    conn.Open();
                    conn.Execute(Constants.UpdatePrice, new { Precio = precio*-1, Id = venta_id }, null, null, CommandType.Text);
                    var existe = conn.Query<Venta_Promocion>(Constants.ExistPromo, new { Promocion_Id = promo_id, Venta_Id = venta_id }, null, true, null, CommandType.Text);
                    if (existe.ElementAt(0).Cantidad <= 1)
                    {
                        return conn.Execute(Constants.DeleteVenta_Promo, new { Promocion_Id = promo_id, Venta_Id = venta_id }, null, null, CommandType.Text);
                    }
                    else
                    {
                        return conn.Execute(Constants.SubsPromo, new { Promocion_Id = promo_id, Venta_Id = venta_id }, null, null, CommandType.Text);
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
