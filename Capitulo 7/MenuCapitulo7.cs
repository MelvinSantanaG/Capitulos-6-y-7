using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7
{
    public partial class MenuCapitulo7 : Form
    {
        public MenuCapitulo7()
        {
            InitializeComponent();
        }

        private void Capitulo7Button1_Click(object sender, EventArgs e)
        {
            Form Cap7Tarea1 = new Capitulo_7.Cap7Tarea1();
            Cap7Tarea1.Show();

        }

        private void Capitulo7Button2_Click(object sender, EventArgs e)
        {
            Form Cap7Tarea2 = new Capitulo_7.Cap7Tarea2();
            Cap7Tarea2.Show();
        }

        private void Capitulo7Button5_Click(object sender, EventArgs e)
        {
            Form Cap7Tarea5 = new Capitulo_7.Cap7Tarea5();
            Cap7Tarea5.Show();
        }
    }
}
