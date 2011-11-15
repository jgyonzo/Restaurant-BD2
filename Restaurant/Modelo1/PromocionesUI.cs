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
                var newDataSource = new List<Promocion>();
                newDataSource.AddRange(promos);
                DataGridPromos.DataSource = newDataSource;
                DataGridPromos.ClearSelection();
                buttonAddPlatoPromo.Enabled = false;
                buttonRemovePlatoPromo.Enabled = false;
                buttonActivatePromo.Enabled = false;
                ButtonDeletePromo.Enabled = false;
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

        private void DataGridPromos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //ReloadCheckListPromos();

            var list = (IEnumerable<Promocion>)DataGridPromos.DataSource;
            var elem = list.ElementAt(e.RowIndex);

            PromocionesOperations po = new PromocionesOperations();
            PlatoOperations plo = new PlatoOperations();
            var platos = po.GetPlatosByPromo(elem);

            List<Plato> platosDataSource = new List<Plato>();
            float suma = 0;
            foreach (var pl in platos)
            {
                Plato p = plo.GetOne(pl.Plato_Id);
                suma += p.Precio_Venta;
                platosDataSource.Add(p);
            }
            dataGridPlatosPromo.DataSource = platosDataSource;

            labelPP.Text = "" + suma;
            TextDescPromo.Text = "" + elem.Descripcion;
            TextPricePromo.Text = "" + elem.Precio;
            TextIdPromo.Text = "" + elem.Id;

            buttonAddPlatoPromo.Enabled = true;
            buttonRemovePlatoPromo.Enabled = true;
            if (elem.Estado == "DISPONIBLE")
            {
                buttonActivatePromo.Enabled = false;
                ButtonDeletePromo.Enabled = true;
            }
            else
            {
                buttonActivatePromo.Enabled = true;
                ButtonDeletePromo.Enabled = false;
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
            labelPP.Text = "0";
            dataGridPlatosPromo.DataSource = null;
            DataGridPromos.ClearSelection();
            buttonAddPlatoPromo.Enabled = false;
            buttonRemovePlatoPromo.Enabled = false;
            buttonActivatePromo.Enabled = false;
            ButtonDeletePromo.Enabled = false;
        }

        private void ButtonNewPromo_Click(object sender, EventArgs e)
        {
            if (dataGridPlatosPromo.DataSource == null || ((List<Plato>)dataGridPlatosPromo.DataSource).Count == 0)
            {
                MessageBox.Show("Debe ingresar un plato a la promoción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextDescPromo.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextPricePromo.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea agregar la promoción?", "Confirmar agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Promocion p = new Promocion();
                p.Descripcion = TextDescPromo.Text;
                try
                {
                    p.Precio = (float)(Convert.ToDouble(TextPricePromo.Text));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Debe ingresar un valor numérico en el precio", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PromocionesOperations po = new PromocionesOperations();
                try
                {
                    po.Insert(p, (List<Plato>)dataGridPlatosPromo.DataSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al agregar promoción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ReloadGridPromos();
                ClearAllPromo();
            }
        }

        private void ButtonSavePromo_Click(object sender, EventArgs e)
        {
            if (dataGridPlatosPromo.DataSource == null || ((List<Plato>)dataGridPlatosPromo.DataSource).Count == 0)
            {
                MessageBox.Show("Debe ingresar un plato a la promoción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextDescPromo.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextPricePromo.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea actualizar la promoción?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Promocion p = new Promocion();
                p.Id = Convert.ToUInt32(TextIdPromo.Text);
                p.Descripcion = TextDescPromo.Text;
                try
                {
                    p.Precio = (float)(Convert.ToDouble(TextPricePromo.Text));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Debe ingresar un valor numérico en el precio", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PromocionesOperations po = new PromocionesOperations();
                try
                {
                    po.Update(p, (List<Plato>)dataGridPlatosPromo.DataSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado en actualización", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ReloadGridPromos();
                ClearAllPromo();
            }
        }

        private void ButtonDeletePromo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Realmente desea marcar como no disponible la promoción?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
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
            }
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

        private void buttonBuscarPlatoPromo_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new PlatoOperations().SearchByDescDisponible(textSearchPlatosPromo.Text);
                dataGridPlatosToAdd.DataSource = data;
                dataGridPlatosToAdd.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearPlatosPromo_Click(object sender, EventArgs e)
        {
            dataGridPlatosToAdd.DataSource = null;
            textSearchPlatosPromo.Clear();
        }

        private void buttonAddPlatoPromo_Click(object sender, EventArgs e)
        {
            if (dataGridPlatosToAdd.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plato para agregarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var platos = (List<Plato>)dataGridPlatosToAdd.DataSource;
                var plato = platos.ElementAt(dataGridPlatosToAdd.CurrentRow.Index);
                List<Plato> newDataSource = new List<Plato>();
                newDataSource.AddRange((List<Plato>)dataGridPlatosPromo.DataSource);
                newDataSource.Add(plato);
                dataGridPlatosPromo.DataSource = newDataSource;
                labelPP.Text = "" + (Convert.ToDouble(labelPP.Text) + plato.Precio_Venta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el plato a la promoción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonRemovePlatoPromo_Click(object sender, EventArgs e)
        {
            if (dataGridPlatosPromo.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un plato para quitarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var platos = (List<Plato>)dataGridPlatosPromo.DataSource;
                List<Plato> newDataSource = new List<Plato>();
                int i = 0;
                float precio_restar = 0;
                foreach (var p in platos)
                {
                    if (i == dataGridPlatosPromo.CurrentRow.Index)
                    {
                        //no lo agrego y lo resto del total
                        precio_restar = p.Precio_Venta;
                    }
                    else
                    {
                        newDataSource.Add(p);
                    }
                    i++;
                }
                if (newDataSource.Count == 0)
                {
                    MessageBox.Show("No se pueden quitar todos los platos de una promoción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelPP.Text = "" + (Convert.ToDouble(labelPP.Text) - precio_restar);
                dataGridPlatosPromo.DataSource = newDataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar el plato de la promoción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void buttonActivatePromo_Click(object sender, EventArgs e)
        {
            if (TextIdPromo.Text == null || TextIdPromo.Text == "")
            {
                MessageBox.Show("Debe seleccionar una promoción para marcar como disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea marcar como disponible la promoción?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                PromocionesOperations po = new PromocionesOperations();
                try
                {
                    Promocion p = new Promocion();
                    p.Id = Convert.ToUInt32(TextIdPromo.Text);
                    po.Activate(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede marcar como disponible una promoción con platos no disponibles", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ReloadGridPromos();
                ReloadGridPromos();
                ClearAllPromo();
            }
        }
    }
}
