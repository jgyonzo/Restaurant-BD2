using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
    }
}
