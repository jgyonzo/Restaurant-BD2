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
                
            ComboBoxPlatos.DataSource = rubrosStr;
            ClearAllPlato();
        }

         private void DataGridPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.RowIndex < 0) return;
             var list = (IEnumerable<Plato>)DataGridPlatos.DataSource;
             var elem = list.ElementAt(e.RowIndex);
             TextDescPlatos.Text = "" + elem.Descripcion;
             TextPricePlatoC.Text = "" + elem.Precio_Costo;
             TextPricePlatoV.Text = "" + elem.Precio_Venta;
             TextIdPlatos.Text = "" + elem.Id;

             ComboBoxPlatos.SelectedItem = elem.Rubro;
         }


         private void LinkClearPlatos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             ClearAllPlato();
         }

         private void ClearAllPlato()
         {
             TextDescPlatos.Clear();
             TextPricePlatoC.Clear();
             TextPricePlatoV.Clear();
             TextIdPlatos.Clear();
             ComboBoxPlatos.SelectedItem = "Primer Plato";
             DataGridPlatos.ClearSelection();
         }

         private void ButtonNewPlato_Click(object sender, EventArgs e)
         {
             Plato p = new Plato();
             p.Descripcion = TextDescPlatos.Text;
             p.Precio_Costo = (float)(Convert.ToDouble(TextPricePlatoC.Text));
             p.Precio_Venta = (float)(Convert.ToDouble(TextPricePlatoV.Text));
             p.Rubro = ComboBoxPlatos.SelectedItem.ToString();

             PlatoOperations po = new PlatoOperations();
             try
             {
                 po.Insert(p);
             }
             catch (Exception ex)
             {
                 //TODO:
             }

             ReloadGridPlatos();
             ClearAllPlato();
             //TODO: Mostrar cartel de update exitoso o erroneo
         }

         private void ButtonSavePlato_Click(object sender, EventArgs e)
         {
             Plato p = new Plato();
             p.Id = Convert.ToUInt32(TextIdPlatos.Text);
             p.Descripcion = TextDescPlatos.Text;
             p.Precio_Costo = (float)(Convert.ToDouble(TextPricePlatoC.Text));
             p.Precio_Venta = (float)(Convert.ToDouble(TextPricePlatoV.Text));
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

         private void ButtonDeletePlato_Click(object sender, EventArgs e)
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
                 //TODO:
             }

             ReloadGridPlatos();
             ClearAllPlato();
             //TODO: Mostrar cartel de update exitoso o erroneo
         }

         private void ButtonBuscarPlato_Click(object sender, EventArgs e)
         {
             if (TextBuscarPlato.Text == null || TextBuscarPlato.Text == "")
             {
                 ReloadGridPlatos();
                 return;
             }
             try
             {
                 PlatoOperations po = new PlatoOperations();
                 var platos = po.GetAllFiltering(TextBuscarPlato.Text);
                 DataGridPlatos.DataSource = platos;
                 DataGridPlatos.ClearSelection();
             }
             catch (Exception ex)
             {
                 //TODO:
             }
         }

         private void ButtonClearSearch_Click(object sender, EventArgs e)
         {
             ReloadGridPlatos();
             TextBuscarPlato.Clear();
             ClearAllPlato();
         }
    }
}
