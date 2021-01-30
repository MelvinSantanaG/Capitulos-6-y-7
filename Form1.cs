using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulos_6_y_7
{
    public partial class Form1 : Form
    {
        public Form1()
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
