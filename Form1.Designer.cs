﻿
namespace Capitulos_6_y_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CapituloButton6 = new System.Windows.Forms.Button();
            this.CapituloButton7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CapituloButton6
            // 
            this.CapituloButton6.Location = new System.Drawing.Point(88, 84);
            this.CapituloButton6.Name = "CapituloButton6";
            this.CapituloButton6.Size = new System.Drawing.Size(75, 23);
            this.CapituloButton6.TabIndex = 0;
            this.CapituloButton6.Text = "Capitulo 6";
            this.CapituloButton6.UseVisualStyleBackColor = true;
            this.CapituloButton6.Click += new System.EventHandler(this.CapituloButton6_Click);
            // 
            // CapituloButton7
            // 
            this.CapituloButton7.Location = new System.Drawing.Point(264, 84);
            this.CapituloButton7.Name = "CapituloButton7";
            this.CapituloButton7.Size = new System.Drawing.Size(75, 23);
            this.CapituloButton7.TabIndex = 1;
            this.CapituloButton7.Text = "Capitulo 7";
            this.CapituloButton7.UseVisualStyleBackColor = true;
            this.CapituloButton7.Click += new System.EventHandler(this.CapituloButton7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 211);
            this.Controls.Add(this.CapituloButton7);
            this.Controls.Add(this.CapituloButton6);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CapituloButton6;
        private System.Windows.Forms.Button CapituloButton7;
    }
}

