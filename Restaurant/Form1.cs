using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_mozo_alta_aceptar_Click(object sender, EventArgs e)
        {
            textBox_mozo_alta_exito.Visible = true;
        }

        private void button_mozo_alta_cancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox_mozo_alta_nombre.Clear();
            textBox_mozo_alta_dir.Clear();
            textBox_mozo_alta_dni.Clear();
            textBox_mozo_alta_exito.Visible = false;
            
        }

        private void textBox_mozo_alta_dir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_mozo_alta_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_mozo_alta_exito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
