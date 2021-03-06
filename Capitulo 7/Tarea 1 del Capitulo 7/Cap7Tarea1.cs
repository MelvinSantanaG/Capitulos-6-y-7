using System;
using System.Collections;
using System.Windows.Forms;

namespace Capitulo_6_y_7.Capitulo_7
{
    public partial class Cap7Tarea1 : Form
    {
        public Cap7Tarea1()
        {
            InitializeComponent();
        }

        private void ResultadoButton_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList
            {
                "Cantidad de Alumnos son 100",
                "Cantidad de Salones son 10",
                "Promedio de Alumnos son 10",
                "Calificacion de Alumnos Maxima es 90",
                "Calificacion de Alumnos minima es 70",
            };

            foreach(var datos in lista)
            {
                MessageBox.Show("Precione Enter Para Continuar",datos.ToString());
            }
        }
    }
}
