﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulos_6_y_7.Capitulo_6
{
    public partial class Cap6Tarea1 : Form
    {
        public Cap6Tarea1()
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