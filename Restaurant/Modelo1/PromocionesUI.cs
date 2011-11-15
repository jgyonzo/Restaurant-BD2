using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BSL;
using DAL.Entities;


namespace Restaurant
{
    public partial class MainWindow
    {
        private void ReloadGridPromos()
        {
            try
            {
                PromocionesOperations po = new PromocionesOperations();
                var promos = po.GetAll();
                DataGridPromos.DataSource = promos;
                DataGridPromos.ClearSelection();
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void ReloadCheckListPromos()
        {
            try
            {
                PlatoOperations po = new PlatoOperations();
                var platos = po.GetAll();
                CheckListPromos.DataSource = platos;
                CheckListPromos.ClearSelected();
                for (int i = 0; i < CheckListPromos.Items.Count; i++)
                {
                    CheckListPromos.SetItemChecked(i, false);
                }
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void TabPromos_Enter(object sender, EventArgs e)
        {
            //Cargo listado de mozos
            ReloadGridPromos();
            ClearAllPromo();
        }

        private void DataGridPromos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ReloadCheckListPromos();

            var list = (IEnumerable<Promocion>)DataGridPromos.DataSource;
            var elem = list.ElementAt(e.RowIndex);
            TextDescPromo.Text = "" + elem.Descripcion;
            TextPricePromo.Text = "" + elem.Precio;
            TextIdPromo.Text = "" + elem.Id;

            PlatoOperations plo = new PlatoOperations();
            PromocionesOperations po = new PromocionesOperations();
            Promocion p = new Promocion();
            p.Id = elem.Id;
            var platos = po.GetPlatosByPromo(p);

            foreach (var plato in platos)
            {
                Plato pl = plo.GetOne(plato.Plato_Id);
                int pos = CheckListPromos.Items.IndexOf(pl);
                if (pos == -1)
                {
                    //ERROR plato no encontrado...
                }
                CheckListPromos.SetItemChecked(pos, true);
            }
        }

        private void LinkClearPromo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllPromo();
        }

        private void ClearAllPromo()
        {
            TextDescPromo.Clear();
            TextPricePromo.ResetText();
            TextIdPromo.Clear();
            ReloadCheckListPromos();
            DataGridPromos.ClearSelection();
        }

        private void ButtonNewPromo_Click(object sender, EventArgs e)
        {
            Promocion p = new Promocion();
            p.Descripcion = TextDescPromo.Text;
            p.Precio = (float)(Convert.ToDouble(TextPricePromo.Text));

            PromocionesOperations po = new PromocionesOperations();
            try
            {
                po.Insert(p,CheckListPromos.CheckedItems.Cast<Plato>());
            }
            catch (Exception ex)
            {
                //TODO:
            }

            ReloadGridPromos();
            ClearAllPromo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }

        private void ButtonSavePromo_Click(object sender, EventArgs e)
        {
            Promocion p = new Promocion();
            p.Id = Convert.ToUInt32(TextIdPromo.Text);
            p.Descripcion = TextDescPromo.Text;
            p.Precio = (float)(Convert.ToDouble(TextPricePromo.Text));

            PromocionesOperations po = new PromocionesOperations();
            try
            {
                po.Update(p, CheckListPromos.CheckedItems.Cast<Plato>());
            }
            catch (Exception ex)
            {
                //TODO:
            }

            ReloadGridPromos();
            ClearAllPromo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }

        private void ButtonDeletePromo_Click(object sender, EventArgs e)
        {
            Promocion p = new Promocion();
            p.Id = Convert.ToUInt32(TextIdPromo.Text);

            PromocionesOperations po = new PromocionesOperations();
            try
            {
                po.Inactivate(p);
            }
            catch (Exception ex)
            {
                //TODO:
            }

            ReloadGridPromos();
            ClearAllPromo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }

        private void ButtonBuscarPromo_Click(object sender, EventArgs e)
        {
            if (TextBuscarPromo.Text == null || TextBuscarPromo.Text == "")
            {
                ReloadGridPromos();
                return;
            }
            try
            {
                PromocionesOperations po = new PromocionesOperations();
                var platos = po.SearchByDesc(TextBuscarPromo.Text);
                DataGridPromos.DataSource = platos;
                DataGridPromos.ClearSelection();
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void ButtonClearSearchPromos_Click(object sender, EventArgs e)
        {
            ReloadGridPromos();
            TextBuscarPromo.Clear();
            ClearAllPromo();
        }
    }
}
