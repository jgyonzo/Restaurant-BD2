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
            //limpio todos los text
            ClearAllMozo();
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
        }

        private void DataGridMozos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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
                mo.Update(m);
            }
            catch (Exception ex)
            {
                //TODO:
            }

            ReloadGridMozos();
            ClearAllMozo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }

        private void ButtonNewMozo_Click(object sender, EventArgs e)
        {
            Mozo m = new Mozo();
            m.Direccion = TextDirMozo.Text;
            m.Dni = Convert.ToUInt64(TextDniMozo.Text);
            m.Nombre = TextNombreMozo.Text;
            m.Sector = Convert.ToUInt32(ComboMozoSector.SelectedItem);

            MozoOperations mo = new MozoOperations();
            try
            {
                mo.Insert(m);
            }
            catch (Exception ex)
            {
                //TODO:
            }

            ReloadGridMozos();
            ClearAllMozo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }

        private void ButtonDeleteMozo_Click(object sender, EventArgs e)
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
            }

            ReloadGridMozos();
            ClearAllMozo();
            //TODO: Mostrar cartel de update exitoso o erroneo
        }
    }
}
