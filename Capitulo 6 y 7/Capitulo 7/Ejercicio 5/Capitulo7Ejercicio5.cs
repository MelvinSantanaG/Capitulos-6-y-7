using System;
using System.Collections;
using System.Windows.Forms;

namespace Capitulo_6_y_7.Capitulo_7
{
    public partial class Capitulo7Ejercicio5 : Form
    {
        public Capitulo7Ejercicio5()
        {
            InitializeComponent();
        }

        private void Resultado7Button_Click(object sender, EventArgs e)
        {
            Hashtable definition = new Hashtable
            {
                { "Julian ", "809-456-8903" },
                { "Ana ", "829-331-2415" },
                { "Pedro ", "849-501-5691" },
                { "Juan ", "809-881-2244" }
            };

            foreach (DictionaryEntry elemento in definition)
            {
                Resultado1.Text = elemento.Key + elemento.Value.ToString();
                Resultado2.Text = elemento.Key + elemento.Value.ToString();
                Resultado3.Text = elemento.Key + elemento.Value.ToString();
                Resultado4.Text = elemento.Key + elemento.Value.ToString();
            }
        }
    }
}
