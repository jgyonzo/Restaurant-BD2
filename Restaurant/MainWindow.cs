using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BSL;
using DAL;
using DAL.Entities;
using DGVPrinterHelper;

namespace Restaurant
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = TextDetallePrint.Text;
            printer.SubTitle = "Resultado de la consulta solicitada";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = ".::Restaurant.NET::. Juan Yonzo - Matias Soria";
            printer.FooterSpacing = 15;

            printer.PrintDataGridView(DataGridConsultas);
        }

        private void LinkMozoTop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string fecha_from = DateTimePickerFrom.Value.ToString("dd/MM/yyyy HH:mm:ss");
                string fecha_to = DateTimePickerTo.Value.ToString("dd/MM/yyyy HH:mm:ss");
                Mozo mozoTop = ConsultasDao.GetMozoTop(fecha_from, fecha_to);
                List<MozoTop> datasource = new List<MozoTop>();
                MozoTop m = new MozoTop();
                m.Consulta = "Mozo que más ventas realizó";
                m.Nombre = mozoTop.Nombre;
                m.Dni = mozoTop.Dni;
                m.Id = mozoTop.Id;
                m.Sector = mozoTop.Sector;
                datasource.Add(m);
                DataGridConsultas.DataSource = datasource;
                TextDetallePrint.Text = "Mozo que más ventas realizó";
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void LinkComidasTop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string fecha_from = DateTimePickerFrom.Value.ToString("dd/MM/yyyy HH:mm:ss");
                string fecha_to = DateTimePickerTo.Value.ToString("dd/MM/yyyy HH:mm:ss");
                var comidas = ConsultasDao.GetComidaTop(fecha_from, fecha_to);
                DataGridConsultas.DataSource = comidas;
                TextDetallePrint.Text = "Comidas más vendidas";
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }

    public class MozoTop
    {
        public string Consulta { get; set; }
        public string Nombre { get; set; }
        public UInt64 Dni { get; set; }
        public UInt32 Id { get; set; }
        public UInt32 Sector { get; set; }
    }
}
