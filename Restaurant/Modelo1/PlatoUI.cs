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
        private void ReloadGridPlatos()
        {
            try
            {
                PlatoOperations po = new PlatoOperations();
                var platos = po.GetAll();
                DataGridPlatos.DataSource = platos;
                DataGridPlatos.ClearSelection();
                descEstadoPlato = false;
                descRubroPlato = false;
                ButtonSavePlato.Enabled = false;
                ButtonDeletePlato.Enabled = false;
                buttonPlatoDisponible.Enabled = false;
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void TabPlatos_Enter(object sender, EventArgs e)
        {
            //Cargo listado de mozos
            ReloadGridPlatos();

            //Cargo los rubros posibles
            List<string> rubrosStr = new List<string>();

            rubrosStr.Add("Primer Plato");
            rubrosStr.Add("Segundo Plato");
            rubrosStr.Add("Postre");
            rubrosStr.Add("Bebida");

            ComboBoxPlatos.DataSource = rubrosStr;
            ClearAllPlato();
            TextBuscarPlato.Clear();
        }

        private void DataGridPlatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var list = (IEnumerable<Plato>)DataGridPlatos.DataSource;
            var elem = list.ElementAt(e.RowIndex);
            TextDescPlatos.Text = "" + elem.Descripcion;
            TextPricePlatoC.Text = "" + elem.Precio_Costo;
            TextPricePlatoV.Text = "" + elem.Precio_Venta;
            TextIdPlatos.Text = "" + elem.Id;

            ComboBoxPlatos.SelectedItem = elem.Rubro;

            ButtonSavePlato.Enabled = true;
            if (elem.Estado == "DISPONIBLE")
            {
                ButtonDeletePlato.Enabled = true;
                buttonPlatoDisponible.Enabled = false;
            }
            else
            {
                buttonPlatoDisponible.Enabled = true;
                ButtonDeletePlato.Enabled = false;
            }
        }


        private void LinkClearPlatos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllPlato();
        }

        private void ClearAllPlato()
        {
            TextDescPlatos.Clear();
            TextPricePlatoC.ResetText();
            TextPricePlatoV.ResetText();
            TextIdPlatos.Clear();
            ComboBoxPlatos.SelectedItem = "Primer Plato";
            DataGridPlatos.ClearSelection();
            ButtonSavePlato.Enabled = false;
            ButtonDeletePlato.Enabled = false;
            buttonPlatoDisponible.Enabled = false;
        }

        private void ButtonNewPlato_Click(object sender, EventArgs e)
        {
            if (TextDescPlatos.Text == null || TextDescPlatos.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextPricePlatoC.Text == null || TextPricePlatoC.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio de costo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextPricePlatoV.Text == null || TextPricePlatoV.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio de venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea agregar el plato?", "Confirmar agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Plato p = new Plato();
                p.Descripcion = TextDescPlatos.Text;
                try
                {
                    p.Precio_Costo = (float)(Convert.ToDouble(TextPricePlatoC.Text));
                    if (p.Precio_Costo <= 0)
                    {
                        MessageBox.Show("El precio debe ser mayor a cero", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    p.Precio_Venta = (float)(Convert.ToDouble(TextPricePlatoV.Text));
                    if (p.Precio_Venta <= 0)
                    {
                        MessageBox.Show("El precio debe ser mayor a cero", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Precio incorrecto", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                p.Rubro = ComboBoxPlatos.SelectedItem.ToString();

                PlatoOperations po = new PlatoOperations();
                try
                {
                    po.Insert(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al agregar el plato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ReloadGridPlatos();
                ClearAllPlato();
            }
        }

        private void ButtonSavePlato_Click(object sender, EventArgs e)
        {
            if (TextIdPlatos.Text == null || TextIdPlatos.Text == "")
            {
                MessageBox.Show("Debe seleccionar un plato para marcar actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextDescPlatos.Text == null || TextDescPlatos.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextPricePlatoC.Text == null || TextPricePlatoC.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio de costo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextPricePlatoV.Text == null || TextPricePlatoV.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio de venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea actualizar el plato?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Plato p = new Plato();
                p.Id = Convert.ToUInt32(TextIdPlatos.Text);
                p.Descripcion = TextDescPlatos.Text;
                try
                {
                    p.Precio_Costo = (float)(Convert.ToDouble(TextPricePlatoC.Text));
                    if (p.Precio_Costo <= 0)
                    {
                        MessageBox.Show("El precio debe ser mayor a cero", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    p.Precio_Venta = (float)(Convert.ToDouble(TextPricePlatoV.Text));
                    if (p.Precio_Venta <= 0)
                    {
                        MessageBox.Show("El precio debe ser mayor a cero", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Precio incorrecto", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                p.Rubro = ComboBoxPlatos.SelectedItem.ToString();

                PlatoOperations po = new PlatoOperations();
                try
                {
                    po.Update(p);
                }
                catch (Exception ex)
                {
                    //TODO:
                }

                ReloadGridPlatos();
                ClearAllPlato();
                //TODO: Mostrar cartel de update exitoso o erroneo
            }
        }

        private void ButtonDeletePlato_Click(object sender, EventArgs e)
        {
            if (TextIdPlatos.Text == null || TextIdPlatos.Text == "")
            {
                MessageBox.Show("Debe seleccionar un plato para marcar actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea marcar como no disponible el plato?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Plato p = new Plato();
                p.Id = Convert.ToUInt32(TextIdPlatos.Text);

                PlatoOperations po = new PlatoOperations();
                try
                {
                    po.Delete(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al marcar como no disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ReloadGridPlatos();
                ClearAllPlato();
            }
        }

        private void ButtonBuscarPlato_Click(object sender, EventArgs e)
        {
            searchPlato();
        }

        private void TextBuscarPlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                searchPlato();
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            ReloadGridPlatos();
            TextBuscarPlato.Clear();
            ClearAllPlato();
        }

        private void searchPlato()
        {
            if (TextBuscarPlato.Text == null || TextBuscarPlato.Text == "")
            {
                ReloadGridPlatos();
                return;
            }
            if (comboPlatoTipoBusq.SelectedItem.Equals("Descripción"))
            {
                try
                {
                    var data = new PlatoOperations().SearchByDesc(TextBuscarPlato.Text);
                    DataGridPlatos.DataSource = data;
                    DataGridPlatos.ClearSelection();
                    ClearAllPlato();
                    descEstadoPlato = false;
                    descRubroPlato = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al realizar la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGridPlatos();
                    ClearAllPlato();
                }
            }
            else if (comboPlatoTipoBusq.SelectedItem.Equals("ID"))
            {
                try
                {
                    var id = Convert.ToUInt32(TextBuscarPlato.Text);
                    var data = new PlatoOperations().GetOne(id);
                    List<Plato> list = null;
                    if (data == null)
                    {
                    }
                    else
                    {
                        list = new List<Plato>(1);
                        list.Add(data);
                    }
                    DataGridPlatos.DataSource = list;
                    DataGridPlatos.ClearSelection();
                    ClearAllPlato();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("El ID debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGridPlatos();
                    ClearAllPlato();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGridPlatos();
                    ClearAllPlato();
                }
            }
        }

        private static bool descEstadoPlato = false;
        private static bool descRubroPlato = false;
        private void DataGridPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                if (e.ColumnIndex == DataGridPlatos.Columns.IndexOf(estadoDataGridViewTextBoxColumn))
                {

                    IEnumerable<Plato> v = ((IEnumerable<Plato>)DataGridPlatos.DataSource).OrderBy(plato => plato.Estado);
                    if (!descEstadoPlato)
                    {
                        v = v.Reverse();
                        descEstadoPlato = true;
                    }
                    else
                    {
                        descEstadoPlato = false;
                    }
                    var list = new List<Plato>(v.Count());
                    foreach (var t in v)
                    {
                        list.Add(t);
                    }
                    DataGridPlatos.DataSource = list;
                    DataGridPlatos.ClearSelection();
                    ClearAllPlato();
                }
                else if (e.ColumnIndex == DataGridPlatos.Columns.IndexOf(rubroDataGridViewTextBoxColumn))
                {
                    IEnumerable<Plato> v = ((IEnumerable<Plato>)DataGridPlatos.DataSource).OrderBy(plato => plato.Rubro);
                    if (!descRubroPlato)
                    {
                        v = v.Reverse();
                        descRubroPlato = true;
                    }
                    else
                    {
                        descRubroPlato = false;
                    }
                    var list = new List<Plato>(v.Count());
                    foreach (var t in v)
                    {
                        list.Add(t);
                    }
                    DataGridPlatos.DataSource = list;
                    DataGridPlatos.ClearSelection();
                    ClearAllPlato();
                }
            }
        }

        private void buttonPlatoDisponible_Click(object sender, EventArgs e)
        {
            if (TextIdPlatos.Text == null || TextIdPlatos.Text == "")
            {
                MessageBox.Show("Debe seleccionar un plato para marcar como disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea marcar como disponible el plato?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                PlatoOperations po = new PlatoOperations();
                try
                {
                    Plato p = new Plato();
                    p.Id = Convert.ToUInt32(TextIdPlatos.Text);
                    po.Activate(p);
                    ReloadGridPlatos();
                    ClearAllPlato();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al marcar como disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
