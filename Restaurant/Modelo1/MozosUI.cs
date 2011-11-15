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
        private void ReloadGridMozos()
        {
            try
            {
                MozoOperations mo = new MozoOperations();
                var mozos = mo.GetAll();
                DataGridMozos.DataSource = mozos;
                DataGridMozos.ClearSelection();
                descMozo = false;
                ButtonSaveMozos.Enabled = false;
                ButtonDeleteMozo.Enabled = false;
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void TabMozos_Enter(object sender, EventArgs e)
        {
            //Cargo listado de mozos
            ReloadGridMozos();

            //Cargo los sectores posibles
            try
            {
                MesaOperations meo = new MesaOperations();
                var sectores = meo.GetAllSectores();
                List<string> sectoresStr = new List<string>();
                foreach (var s in sectores)
                {
                    sectoresStr.Add(s.sector.ToString());
                }
                ComboMozoSector.DataSource = sectoresStr;
            }
            catch (Exception ex)
            {
                //TODO: 
            }

            //limpio todos los text
            ClearAllMozo();
            textSearchMozos.Clear();
        }

        private void DataGridMozos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var list = (IEnumerable<Mozo>)DataGridMozos.DataSource;
            var elem = list.ElementAt(e.RowIndex);
            TextDniMozo.Text = "" + elem.Dni;
            TextDirMozo.Text = "" + elem.Direccion;
            TextNombreMozo.Text = "" + elem.Nombre;
            TextIdMozo.Text = "" + elem.Id;

            ComboMozoSector.SelectedItem = elem.Sector.ToString();

            ButtonSaveMozos.Enabled = true;
            ButtonDeleteMozo.Enabled = true;
        }

        private void LinkClearMozos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllMozo();
        }

        private void ClearAllMozo()
        {
            TextDniMozo.ResetText();
            TextDirMozo.Clear();
            TextNombreMozo.Clear();
            TextIdMozo.Clear();
            ComboMozoSector.SelectedItem = "1";
            DataGridMozos.ClearSelection();
            ButtonSaveMozos.Enabled = false;
            ButtonDeleteMozo.Enabled = false;
        }

        private void ButtonSaveMozos_Click(object sender, EventArgs e)
        {
            if (TextIdMozo.Text == null || TextIdMozo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un mozo para actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextDirMozo.Text == null || TextDirMozo.Text == "")
            {
                MessageBox.Show("Debe ingresar una dirección", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextDniMozo.Text == null || TextDniMozo.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextNombreMozo.Text == null || TextNombreMozo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea actualizar el mozo?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Mozo m = new Mozo();
                m.Id = Convert.ToUInt32(TextIdMozo.Text);
                m.Direccion = TextDirMozo.Text;
                m.Dni = Convert.ToUInt64(TextDniMozo.Text);
                if (m.Dni <= 1000000)
                {
                    MessageBox.Show("DNI incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m.Nombre = TextNombreMozo.Text;
                m.Sector = Convert.ToUInt32(ComboMozoSector.SelectedItem);

                MozoOperations mo = new MozoOperations();
                try
                {
                    mo.Update(m);
                }
                catch (Exception ex)
                {
                    //TODO:
                    MessageBox.Show("DNI duplicado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ReloadGridMozos();
                ClearAllMozo();
                //TODO: Mostrar cartel de update exitoso o erroneo
            }
        }

        private void ButtonNewMozo_Click(object sender, EventArgs e)
        {
            if (TextDirMozo.Text == null || TextDirMozo.Text == "")
            {
                MessageBox.Show("Debe ingresar una dirección", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextDniMozo.Text == null || TextDniMozo.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextNombreMozo.Text == null || TextNombreMozo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea agregar el mozo?", "Confirmar agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Mozo m = new Mozo();
                m.Direccion = TextDirMozo.Text;
                m.Dni = Convert.ToUInt64(TextDniMozo.Text);
                if (m.Dni <= 1000000)
                {
                    MessageBox.Show("DNI incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m.Nombre = TextNombreMozo.Text;
                m.Sector = Convert.ToUInt32(ComboMozoSector.SelectedItem);

                MozoOperations mo = new MozoOperations();
                try
                {
                    mo.Insert(m);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DNI duplicado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ReloadGridMozos();
                ClearAllMozo();
                //TODO: Mostrar cartel de update exitoso o erroneo
            }
        }

        private void ButtonDeleteMozo_Click(object sender, EventArgs e)
        {
            if (TextIdMozo.Text == null || TextIdMozo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un mozo para dar de baja", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea dar de baja el mozo?", "Confirmar baja de mozo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Mozo m = new Mozo();
                m.Id = Convert.ToUInt32(TextIdMozo.Text);

                MozoOperations mo = new MozoOperations();
                try
                {
                    mo.Delete(m);
                }
                catch (Exception ex)
                {
                    //TODO:
                    MessageBox.Show("Error inesperado al dar de baja el mozo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ReloadGridMozos();
                ClearAllMozo();
                //TODO: Mostrar cartel de update exitoso o erroneo
            }
        }

        private void buttonSearchMozos_Click(object sender, EventArgs e)
        {
            searchMozo();
        }

        private void textSearchMozos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                searchMozo();
        }

        private void searchMozo()
        {
            if (textSearchMozos.Text == null || textSearchMozos.Text == "")
            {
                ReloadGridMozos();
                return;
            }
            if (comboMozoTipoBusq.SelectedItem.Equals("Nombre"))
            {
                try
                {
                    var data = new MozoOperations().SearchByNombre(textSearchMozos.Text);
                    DataGridMozos.DataSource = data;
                    DataGridMozos.ClearSelection();
                    ClearAllMozo();
                    descMozo = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al realizar la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGridMozos();
                    ClearAllMozo();
                }
            }
            else if (comboMozoTipoBusq.SelectedItem.Equals("DNI"))
            {
                try
                {
                    var dni = Convert.ToUInt64(textSearchMozos.Text);
                    var data = new MozoOperations().GetOneByDni(dni);
                    List<Mozo> list = null;
                    if (data == null)
                    {
                    }
                    else
                    {
                        list = new List<Mozo>(1);
                        list.Add(data);
                    }            
                    DataGridMozos.DataSource = list;
                    DataGridMozos.ClearSelection();
                    ClearAllMozo();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("El DNI debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGridMozos();
                    ClearAllMozo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGridMozos();
                    ClearAllMozo();
                }
            }
        }

        private void buttonClearSearchMozos_Click(object sender, EventArgs e)
        {
            ReloadGridMozos();
            ClearAllMozo();
            textSearchMozos.Clear();
        }

        private static bool descMozo = false;
        private void DataGridMozos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                if (e.ColumnIndex == DataGridMozos.Columns.IndexOf(sectorDataGridViewTextBoxColumn))
                {

                    IEnumerable<Mozo> v = ((IEnumerable<Mozo>)DataGridMozos.DataSource).OrderBy(mozo => mozo.Sector.ToString());
                    if (!descMozo)
                    {
                        v = v.Reverse();
                        descMozo = true;
                    }
                    else
                    {
                        descMozo = false;
                    }
                    var list = new List<Mozo>(v.Count());
                    foreach (var t in v)
                    {
                        list.Add(t);
                    }
                    DataGridMozos.DataSource = list;
                    DataGridMozos.ClearSelection();
                    ClearAllMozo();
                }
            }
        }
    }
}
