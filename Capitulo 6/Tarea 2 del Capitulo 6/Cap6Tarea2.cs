﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulos_6_y_7.Capitulo_6
{
    public partial class Cap6Tarea2 : Form
    {
        public Cap6Tarea2()
        {
            InitializeComponent();
        }

        private void Resultado2Button_Click(object sender, EventArgs e)
        {
            
            int quantity = 0; 
            
            int minima = 0;

            int n;

            int[] grade = new int[quantity];

            quantity = int.Parse(textBox1.Text);

            for (n = 0; n < quantity; n++)
            {
                quantity = int.Parse(textBox1.Text);
            }

            for (n = 0; n < quantity; n++) 
            { 

                if (quantity < minima)
                    minima -= quantity;

            }
            Resultado.Text = minima.ToString();

        }
    }
}