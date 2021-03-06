using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7
{
    public partial class MenuCapitulo6 : Form
    {
        public MenuCapitulo6()
        {
            InitializeComponent();
        }

        private void Capitulo6Button1_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea1 = new Capitulo_6.Cap6Tarea1();
            Cap6Tarea1.Show();
        }

        private void Capitulo6Button2_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea2 = new Capitulo_6.Cap6Tarea2();
            Cap6Tarea2.Show();
        }

        private void Capitulo6Button3_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea3 = new Capitulo_6.Cap6Tarea3();
            Cap6Tarea3.Show();
        }

        private void Capitulo6Button4_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea4 = new Capitulo_6.Cap6Tarea4();
            Cap6Tarea4.Show();
        }

        private void Capitulo6Button5_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea5 = new Capitulo_6.Cap6Tarea5();
            Cap6Tarea5.Show();
        }
    }
}
