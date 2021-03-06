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
            Form menuCap6 = new MenuCapitulo6();
            menuCap6.Show();
        }

        private void CapituloButton7_Click(object sender, EventArgs e)
        {
            Form menuCap7 = new MenuCapitulo7();
            menuCap7.Show();
        }
    }
}
