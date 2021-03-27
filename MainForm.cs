using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CapituloButton6_Click(object sender, EventArgs e)
        {
            var menuCap6 = new Capitulo6EjerciciosForm();
            menuCap6.Show();
        }

        private void CapituloButton7_Click(object sender, EventArgs e)
        {
            var menuCap7 = new Capitulo7EjerciciosForm();
            menuCap7.Show();
        }
    }
}
