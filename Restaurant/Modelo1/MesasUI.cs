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
        private void ReloadGridMesas()
        {
            try
            {
                MesaOperations po = new MesaOperations();
                var mesas = po.GetAll();
                DataGridMesas.DataSource = mesas;
                DataGridMesas.ClearSelection();
                ButtonDeleteMesa.Enabled = false;
                buttonActivateMesa.Enabled = false;
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void TabMesas_Enter(object sender, EventArgs e)
        {
            ReloadGridMesas();
            ClearAllMesa();
        }

        private void ClearAllMesa()
        {
            TextNroMesa.Clear();
            TextIdMesas.Clear();
            TextIdMesa.ResetText();
            TextSectorMesa.ResetText();
            DataGridMesas.ClearSelection();
            ButtonDeleteMesa.Enabled = false;
            buttonActivateMesa.Enabled = false;
        }

        private void LinkClearMesas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllMesa();
        }

        private void DataGridMesas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var list = (IEnumerable<Mesa>)DataGridMesas.DataSource;
            var elem = list.ElementAt(e.RowIndex);
            TextNroMesa.Text = "" + elem.Id;
            TextIdMesas.Text = "" + elem.Id;
            if (elem.Estado == "EN SERVICIO")
            {
                ButtonDeleteMesa.Enabled = true;
                buttonActivateMesa.Enabled = false;
            }
            else
            {
                ButtonDeleteMesa.Enabled = false;
                buttonActivateMesa.Enabled = true;
            }
        }

        private void ButtonNewMesa_Click(object sender, EventArgs e)
        {
            if (TextIdMesa.Text == null || TextIdMesa.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID para la mesa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TextSectorMesa.Text == null || TextSectorMesa.Text == "")
            {
                MessageBox.Show("Debe ingresar un sector para la mesa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mesa p = new Mesa();
            try
            {
                p.Sector = Convert.ToUInt32(TextSectorMesa.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El sector debe ser numérico", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                p.Id = Convert.ToUInt32(TextIdMesa.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID debe ser numérico", "Error numérico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea agregar la mesa?", "Confirmar agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                MesaOperations po = new MesaOperations();
                try
                {
                    po.Insert(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ID duplicado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ReloadGridMesas();
                ClearAllMesa();
            }
        }

        private void ButtonDeleteMesa_Click(object sender, EventArgs e)
        {
            if (TextIdMesas.Text == null || TextIdMesas.Text == "")
            {
                MessageBox.Show("Debe seleccionar una mesa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea marcar como fuera de servicio la mesa?", "Confirmar fuera de servicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Mesa p = new Mesa();
                p.Id = Convert.ToUInt32(TextIdMesas.Text);

                MesaOperations po = new MesaOperations();
                try
                {
                    po.Inactivate(p);
                }
                catch (Exception ex)
                {
                    //TODO:
                }

                ReloadGridMesas();
                ClearAllMesa();
            }
        }

        private void buttonActivateMesa_Click(object sender, EventArgs e)
        {
            if (TextIdMesas.Text == null || TextIdMesas.Text == "")
            {
                MessageBox.Show("Debe seleccionar una mesa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("¿Realmente desea marcar como en servicio la mesa?", "Confirmar en servicio", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                Mesa p = new Mesa();
                p.Id = Convert.ToUInt32(TextIdMesas.Text);

                MesaOperations po = new MesaOperations();
                try
                {
                    po.Activate(p);
                }
                catch (Exception ex)
                {
                    //TODO:
                }

                ReloadGridMesas();
                ClearAllMesa();
            }
        }
    }
}
