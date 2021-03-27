using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7
{
    public partial class Capitulo6EjerciciosForm : Form
    {
        public Capitulo6EjerciciosForm()
        {
            InitializeComponent();
        }

        private void Capitulo6Button1_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea1 = new Capitulo_6.Capitulo6Ejercicio1();
            Cap6Tarea1.Show();
        }

        private void Capitulo6Button2_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea2 = new Capitulo_6.Capitulo6Ejercicio2();
            Cap6Tarea2.Show();
        }

        private void Capitulo6Button3_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea3 = new Capitulo_6.Capitulo6Ejercicio3();
            Cap6Tarea3.Show();
        }

        private void Capitulo6Button4_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea4 = new Capitulo_6.Capitulo6Ejercicio4();
            Cap6Tarea4.Show();
        }

        private void Capitulo6Button5_Click(object sender, EventArgs e)
        {
            Form Cap6Tarea5 = new Capitulo_6.Capitulo6Ejercicio5();
            Cap6Tarea5.Show();
        }
    }
}
