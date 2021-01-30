﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulos_6_y_7.Capitulo_7
{
    public partial class Cap7Tarea2 : Form
    {
        public Cap7Tarea2()
        {
            InitializeComponent();
        }

        private void Resultado7Button_Click(object sender, EventArgs e)
        {
            Hashtable definition = new Hashtable
            {
                { "Libro ", "es el conjunto de hojas de papel, vitela, u otra sustancia, manuscritas o impresas, colocadas en el orden en que se han para leer." },
                { "Lapiz ", "es un instrumento de escritura o de dibujo consistente en una mina o barrita de pigmento y encapsulado." },
                { "Lapicero ", "es un instrumento de escritura o de dibujo consistente en una mina o barrita de pigmento (generalmente de grafito y una grasa o arcilla especial." },
                { "Borra ", "es un instrumento de mano cuya finalidad es eliminar trazos generalmente de lápiz." }
            };

            foreach (DictionaryEntry elemento in definition)
            {
                Resultado.Text = elemento.Key + elemento.Value.ToString();
            }

        }
    }
}
