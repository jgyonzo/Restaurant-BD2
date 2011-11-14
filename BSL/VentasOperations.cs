using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using DAL;

namespace BSL
{
    public class VentasOperations
    {
        public IEnumerable<Venta> GetAbiertas()
        {
            try
            {
                VentasDao dao = new VentasDao();
                return dao.GetAbiertas();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener ventas en proceso: " + ex.Message);
                throw ex;
            }
        }

        public Venta GetOne(UInt32 id)
        {
            try
            {
                VentasDao dao = new VentasDao();
                return dao.GetOne(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la venta: " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Venta_Promocion> GetPromos(Venta v)
        {
            try
            {
                VentasDao dao = new VentasDao();
                return dao.GetPromos(v);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener promociones: " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Pedido> GetPedidos(Venta v)
        {
            try
            {
                VentasDao dao = new VentasDao();
                return dao.GetPedidos(v);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener pedidos: " + ex.Message);
                throw ex;
            }
        }

        public void Insert(Venta p)
        {
            VentasDao dao = new VentasDao();
            if (dao.Insert(p) != 1)
            {
                throw new Exception("No se insertó la información");
            }
        }

        public void Close(Venta p)
        {
            VentasDao dao = new VentasDao();
            if (dao.Close(p) != 1)
            {
                throw new Exception("No se cerró la venta");
            }
        }

        public void AddPedido(UInt32 pedido_id, UInt32 venta_id, float precio)
        {
            VentasDao dao = new VentasDao();
            if (dao.AddPedido(pedido_id, venta_id, precio) != 1)
            {
                throw new Exception("No se insertó la información");
            }
        }

        public void AddPromo(UInt32 promo_id, UInt32 venta_id, float precio)
        {
            VentasDao dao = new VentasDao();
            if (dao.AddPromo(promo_id, venta_id, precio) != 1)
            {
                throw new Exception("No se insertó la información");
            }
        }

        public void RemovePedido(UInt32 pedido_id, UInt32 venta_id, float precio)
        {
            VentasDao dao = new VentasDao();
            if (dao.RemovePedido(pedido_id, venta_id, precio) != 1)
            {
                throw new Exception("No se removió la información");
            }
        }

        public void RemovePromo(UInt32 promo_id, UInt32 venta_id, float precio)
        {
            VentasDao dao = new VentasDao();
            if (dao.RemovePromo(promo_id, venta_id, precio) != 1)
            {
                throw new Exception("No se removió la información");
            }
        }
    }
}
