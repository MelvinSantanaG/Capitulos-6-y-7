using System;
using System.Windows.Forms;

namespace Capitulo_6_y_7.Capitulo_6
{
    public partial class Capitulo6Ejercicio1 : Form
    {
        public Capitulo6Ejercicio1()
        {
            InitializeComponent();
        }

        private void Resultado1Button_Click(object sender, EventArgs e)
        {
            float plus = 0.0f;
            int quantity = 0;
            float average = 0.0f;

            quantity = int.Parse(textBox1.Text);
         
            float[] grade = new float[quantity];

            for(int number = 0; number<quantity; number++)
            {
                grade[number] = (int)float.Parse(textBox1.Text);
            }

            for(int number = 0; number<quantity; number++)
            {
                plus += grade[number];
            }
            average = plus / quantity;

            Resultado.Text = average.ToString();
        }
    }
}
