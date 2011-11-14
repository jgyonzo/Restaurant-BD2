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
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void TabMesas_Enter(object sender, EventArgs e)
        {
            ReloadGridMesas();
            List<UInt32> sectores = new List<UInt32>();
            sectores.Add(1);
            sectores.Add(2);
            sectores.Add(3);
            ComboSectoresMesas.DataSource = sectores;
            ClearAllMesa();
        }

        private void ClearAllMesa()
        {
            TextNroMesa.Clear();
            TextIdMesas.Clear();
            ComboSectoresMesas.SelectedItem = Convert.ToUInt32(1);
            DataGridMesas.ClearSelection();
        }

        private void LinkClearMesas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllMesa();
        }

        private void DataGridMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var list = (IEnumerable<Mesa>)DataGridMesas.DataSource;
            var elem = list.ElementAt(e.RowIndex);
            TextNroMesa.Text = "" + elem.Id;
            TextIdMesas.Text = "" + elem.Id;
            ComboSectoresMesas.SelectedItem = elem.Sector;
        }

        private void ButtonNewMesa_Click(object sender, EventArgs e)
        {
            Mesa p = new Mesa();
            p.Sector = (UInt32)ComboSectoresMesas.SelectedItem;

            MesaOperations po = new MesaOperations();
            try
            {
                po.Insert(p);
            }
            catch (Exception ex)
            {
                //TODO:
            }

            ReloadGridMesas();
            ClearAllMesa();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }

        private void ButtonDeleteMesa_Click(object sender, EventArgs e)
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

        private void buttonActivateMesa_Click(object sender, EventArgs e)
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
