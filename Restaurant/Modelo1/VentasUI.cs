using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BSL;
using DAL.Entities;

namespace Restaurant
{
    public partial class MainWindow
    {
        private void ReloadGridVentas()
        {
            try
            {
                VentasOperations po = new VentasOperations();
                var platos = po.GetAbiertas();
                DataGridVentas.DataSource = platos;
                DataGridVentas.ClearSelection();
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void ReloadGridVentasSinClear()
        {
            try
            {
                VentasOperations po = new VentasOperations();
                var platos = po.GetAbiertas();
                DataGridVentas.DataSource = platos;
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void LoadItemsActuales()
        {
            try
            {
                //var lista = (IEnumerable<Venta>)DataGridVentas.DataSource;
                //var elem = lista.ElementAt(DataGridVentas.CurrentRow.Index);
                VentasOperations vo = new VentasOperations();
                PlatoOperations plo = new PlatoOperations();
                PromocionesOperations pro = new PromocionesOperations();

                var elem = vo.GetOne(Convert.ToUInt32(TextIdVenta.Text));
                List<ItemCargado> items = new List<ItemCargado>();
                var promos_ventas = vo.GetPromos(elem);
                var pedidos = vo.GetPedidos(elem);
                foreach (var promo in promos_ventas)
                {
                    ItemCargado i = new ItemCargado();
                    i.Cant = promo.Cantidad;
                    i.Id = promo.Promocion_Id;
                    Promocion p = pro.GetOne(promo.Promocion_Id);
                    i.Descripción = p.Descripcion;
                    i.Precio = p.Precio;
                    i.Tipo = "PROMO";
                    items.Add(i);
                }
                foreach (var pedido in pedidos)
                {
                    ItemCargado i = new ItemCargado();
                    i.Cant = pedido.Cantidad;
                    i.Id = pedido.Plato_Id;
                    Plato p = plo.GetOne(pedido.Plato_Id);
                    i.Descripción = p.Descripcion;
                    i.Precio = p.Precio_Venta;
                    i.Tipo = "PLATO";
                    items.Add(i);
                }
                DataGridItemsActuales.DataSource = items;
                DataGridItemsActuales.ClearSelection();
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void ReloadGridItems()
        {
            List<Item> items = new List<Item>();
            DataGridItemsVenta.DataSource = items;
        }

        private void ReloadGridItemsActuales()
        {
            List<ItemCargado> items = new List<ItemCargado>();
            DataGridItemsActuales.DataSource = items;
        }

        private void TabVentas_Pedidos_Enter(object sender, EventArgs e)
        {
            //Cargo listado de mozos
            ReloadGridVentas();

            MozoOperations mo = new MozoOperations();
            var mozos = mo.GetAll();

            ComboMozoVenta.DataSource = mozos;
            ReloadGridItems();
            ReloadGridItemsActuales();
            ClearAllVenta();
        }

        public void ClearAllVenta()
        {
            TextSearchItems.Clear();
            ReloadGridItems();
            ReloadGridItemsActuales();
        }

        private void ComboMozoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var elem = (Mozo)ComboMozoVenta.SelectedItem;
                MesaOperations mo = new MesaOperations();
                var mesas = mo.GetDisponiblesMesasBySector(elem.Sector);
                ComboMesaVenta.DataSource = mesas;
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void ButtonNewVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboMozoVenta.SelectedItem == null || ComboMesaVenta.SelectedItem == null)
                {
                    //TODO: Marcar error
                    return;
                }
                Venta v = new Venta();
                var mozo = (Mozo)ComboMozoVenta.SelectedItem;
                var mesa = (Mesa)ComboMesaVenta.SelectedItem;
                v.Mozo_Id = mozo.Id;
                v.Mesa_Id = mesa.Id;
                VentasOperations vo = new VentasOperations();
                vo.Insert(v);
                ReloadGridVentas();

                MesaOperations mo = new MesaOperations();
                var mesas = mo.GetDisponiblesMesasBySector(mozo.Sector);
                ComboMesaVenta.DataSource = mesas;
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void ButtonFinVenta_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Error no hay venta seleccionada
                Venta v = new Venta();
                v.Id = Convert.ToUInt32(TextIdVenta.Text);
                VentasOperations vo = new VentasOperations();
                vo.Close(v);
                ReloadGridVentas();

                var elem = (Mozo)ComboMozoVenta.SelectedItem;
                MesaOperations mo = new MesaOperations();
                var mesas = mo.GetDisponiblesMesasBySector(elem.Sector);
                ComboMesaVenta.DataSource = mesas;
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void DataGridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var list = (IEnumerable<Venta>)DataGridVentas.DataSource;
                var elem = list.ElementAt(e.RowIndex);
                TextIdVenta.Text = "" + elem.Id;

                LoadItemsActuales();
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void ButtonBuscarPlatoVenta_Click(object sender, EventArgs e)
        {
            if (TextSearchItems.Text == null || TextSearchItems.Text == "")
            {
                ReloadGridItems();
                return;
            }
            try
            {
                PlatoOperations po = new PlatoOperations();
                var platos = po.SearchByDesc(TextSearchItems.Text);
                List<Item> items = new List<Item>();
                foreach (var p in platos)
                {
                    Item i = new Item();
                    i.Descripción = p.Descripcion;
                    i.Id = p.Id;
                    i.Precio = p.Precio_Venta;
                    i.Tipo = "PLATO";
                    items.Add(i);
                }
                DataGridItemsVenta.DataSource = items;
                DataGridItemsVenta.ClearSelection();
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void ButtonClearItems_Click(object sender, EventArgs e)
        {
            TextSearchItems.Clear();
            ReloadGridItems();
        }

        private void ButtonBuscarPromosVenta_Click(object sender, EventArgs e)
        {
            if (TextSearchItems.Text == null || TextSearchItems.Text == "")
            {
                ReloadGridItems();
                return;
            }
            try
            {
                PromocionesOperations po = new PromocionesOperations();
                var promos = po.SearchByDesc(TextSearchItems.Text);
                List<Item> items = new List<Item>();
                foreach (var p in promos)
                {
                    Item i = new Item();
                    i.Descripción = p.Descripcion;
                    i.Id = p.Id;
                    i.Precio = p.Precio;
                    i.Tipo = "PROMO";
                    items.Add(i);
                }
                DataGridItemsVenta.DataSource = items;
                DataGridItemsVenta.ClearSelection();
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void ButtonAddItemVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var items = (List<Item>)DataGridItemsVenta.DataSource;
                Item i = (Item)items.ElementAt(DataGridItemsVenta.CurrentRow.Index);
                VentasOperations vo = new VentasOperations();
                if (i.Tipo == "PROMO")
                {
                    var venta_id = Convert.ToUInt32(TextIdVenta.Text);
                    vo.AddPromo(i.Id, venta_id, i.Precio);
                }
                else
                {
                    var venta_id = Convert.ToUInt32(TextIdVenta.Text);
                    vo.AddPedido(i.Id, venta_id, i.Precio);
                }
                LoadItemsActuales();
                ReloadGridVentas();
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void ButtonRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                var items = (List<ItemCargado>)DataGridItemsActuales.DataSource;
                ItemCargado i = (ItemCargado)items.ElementAt(DataGridItemsActuales.CurrentRow.Index);
                VentasOperations vo = new VentasOperations();
                if (i.Tipo == "PROMO")
                {
                    var venta_id = Convert.ToUInt32(TextIdVenta.Text);
                    vo.RemovePromo(i.Id, venta_id, i.Precio);
                }
                else
                {
                    var venta_id = Convert.ToUInt32(TextIdVenta.Text);
                    vo.RemovePedido(i.Id, venta_id, i.Precio);
                }
                LoadItemsActuales();
                ReloadGridVentas();
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }

    class Item
    {
        public string Descripción { get; set; }
        public string Tipo { get; set; }
        public float Precio { get; set; }
        public UInt32 Id { get; set; }
    }

    class ItemCargado
    {
        public string Descripción { get; set; }
        public UInt16 Cant { get; set; }
        public string Tipo { get; set; }
        public float Precio { get; set; }
        public UInt32 Id { get; set; }
    }
}
