using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7.Capitulo_6
{
    public partial class Cap6Tarea5 : Form
    {
        public Cap6Tarea5()
        {
            InitializeComponent();
        }

        private void Resultado5Button_Click(object sender, EventArgs e)
        {

            int[] numeros = new int[5];

            for (int n = 0; n < 5; n++)
            {
                numeros[5] = int.Parse(textBox1.Text);
            }

            void Imprime(int[] arreglo)
            {
                for (int n = 0; n < 5; n++)
                {
                    
                    label3.Text = numeros.ToString();
                }
            }
            Imprime(numeros);
        }
    }
}
  
