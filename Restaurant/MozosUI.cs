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
        private void reloadGridMozos()
        {
            try
            {
                MozoOperations mo = new MozoOperations();
                var mozos = mo.getAll();
                DataGridMozos.DataSource = mozos;
            }
            catch (Exception ex)
            {
                //TODO:
            }
        }

        private void TabMozos_Enter(object sender, EventArgs e)
        {
            //Cargo listado de mozos
            reloadGridMozos();

            //Cargo los sectores posibles
            try
            {
                MesaOperations meo = new MesaOperations();
                var sectores = meo.getAllSectores();
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
        }

        private void DataGridMozos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = (IEnumerable<Mozo>)DataGridMozos.DataSource;
            var elem = list.ElementAt(e.RowIndex);
            TextDniMozo.Text = "" + elem.Dni;
            TextDirMozo.Text = "" + elem.Direccion;
            TextNombreMozo.Text = "" + elem.Nombre;
            TextIdMozo.Text = "" + elem.Id;

            ComboMozoSector.SelectedItem = elem.Sector.ToString();
        }

        private void LinkClearMozos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clearAllMozo();
        }

        private void clearAllMozo()
        {
            TextDniMozo.Clear();
            TextDirMozo.Clear();
            TextNombreMozo.Clear();
            TextIdMozo.Clear();
            ComboMozoSector.SelectedItem = "1";
        }

        private void ButtonSaveMozos_Click(object sender, EventArgs e)
        {
            Mozo m = new Mozo();
            m.Id = Convert.ToUInt32(TextIdMozo.Text);
            m.Direccion = TextDirMozo.Text;
            m.Dni = Convert.ToUInt64(TextDniMozo.Text);
            m.Nombre = TextNombreMozo.Text;
            m.Sector = Convert.ToUInt32(ComboMozoSector.SelectedItem);

            MozoOperations mo = new MozoOperations();
            try
            {
                mo.update(m);
            }
            catch (Exception ex)
            {
                //TODO:
            }

            reloadGridMozos();
            clearAllMozo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }
    }
}
