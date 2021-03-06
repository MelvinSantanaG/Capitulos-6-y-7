
namespace Capitulo_6_y_7.Capitulo_7
{
    partial class Cap7Tarea5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cap7Tarea5));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultado1 = new System.Windows.Forms.Label();
            this.Resultado2 = new System.Windows.Forms.Label();
            this.Resultado3 = new System.Windows.Forms.Label();
            this.Resultado4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Presione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Resultado7Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda Telefonica";
            // 
            // Resultado1
            // 
            this.Resultado1.AutoSize = true;
            this.Resultado1.Location = new System.Drawing.Point(155, 109);
            this.Resultado1.Name = "Resultado1";
            this.Resultado1.Size = new System.Drawing.Size(0, 15);
            this.Resultado1.TabIndex = 2;
            // 
            // Resultado2
            // 
            this.Resultado2.AutoSize = true;
            this.Resultado2.Location = new System.Drawing.Point(155, 138);
            this.Resultado2.Name = "Resultado2";
            this.Resultado2.Size = new System.Drawing.Size(0, 15);
            this.Resultado2.TabIndex = 3;
            // 
            // Resultado3
            // 
            this.Resultado3.AutoSize = true;
            this.Resultado3.Location = new System.Drawing.Point(155, 169);
            this.Resultado3.Name = "Resultado3";
            this.Resultado3.Size = new System.Drawing.Size(0, 15);
            this.Resultado3.TabIndex = 4;
            // 
            // Resultado4
            // 
            this.Resultado4.AutoSize = true;
            this.Resultado4.Location = new System.Drawing.Point(155, 196);
            this.Resultado4.Name = "Resultado4";
            this.Resultado4.Size = new System.Drawing.Size(0, 15);
            this.Resultado4.TabIndex = 5;
            // 
            // Cap7Tarea5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 326);
            this.Controls.Add(this.Resultado4);
            this.Controls.Add(this.Resultado3);
            this.Controls.Add(this.Resultado2);
            this.Controls.Add(this.Resultado1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cap7Tarea5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Resultado1;
        private System.Windows.Forms.Label Resultado2;
        private System.Windows.Forms.Label Resultado3;
        private System.Windows.Forms.Label Resultado4;
    }
}