using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7.Capitulo_6
{
    public partial class Cap6Tarea4 : Form
    {
        public Cap6Tarea4()
        {
            InitializeComponent();
        }

        private void Resultado4Button_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            int salones = 0;

            salones = int.Parse(textBox1.Text);

            // Creamos el arreglo
            float[][] calif = new float[salones][];
            
            for (int n = 0; n < salones; n++)
            {
                calif[n] = new float[cantidad];
            }
            
            for(int n=0; n<salones; n++)
            {
                for(int m=0; m<calif[n].GetLength(0); m++) 
                {

                    calif[n] = calif[n];
                }
            }

           
            for (int n = 0; n < salones; n++)
            {
                for (int m = 0; m < calif[n].GetLength(0); m++)
                {
                    
                    label2.Text = calif[n][m].ToString();

                }
            }
        }
    }
}

