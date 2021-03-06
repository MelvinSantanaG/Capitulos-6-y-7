
namespace Capitulo_6_y_7
{
    partial class MenuCapitulo7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCapitulo7));
            this.Capitulo7Button1 = new System.Windows.Forms.Button();
            this.Capitulo7Button2 = new System.Windows.Forms.Button();
            this.Capitulo7Button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Capitulo7Button1
            // 
            this.Capitulo7Button1.Location = new System.Drawing.Point(101, 12);
            this.Capitulo7Button1.Name = "Capitulo7Button1";
            this.Capitulo7Button1.Size = new System.Drawing.Size(75, 23);
            this.Capitulo7Button1.TabIndex = 0;
            this.Capitulo7Button1.Text = "Capitulo 1";
            this.Capitulo7Button1.UseVisualStyleBackColor = true;
            this.Capitulo7Button1.Click += new System.EventHandler(this.Capitulo7Button1_Click);
            // 
            // Capitulo7Button2
            // 
            this.Capitulo7Button2.Location = new System.Drawing.Point(101, 92);
            this.Capitulo7Button2.Name = "Capitulo7Button2";
            this.Capitulo7Button2.Size = new System.Drawing.Size(75, 23);
            this.Capitulo7Button2.TabIndex = 1;
            this.Capitulo7Button2.Text = "Capitulo 2";
            this.Capitulo7Button2.UseVisualStyleBackColor = true;
            this.Capitulo7Button2.Click += new System.EventHandler(this.Capitulo7Button2_Click);
            // 
            // Capitulo7Button5
            // 
            this.Capitulo7Button5.Location = new System.Drawing.Point(101, 172);
            this.Capitulo7Button5.Name = "Capitulo7Button5";
            this.Capitulo7Button5.Size = new System.Drawing.Size(75, 23);
            this.Capitulo7Button5.TabIndex = 4;
            this.Capitulo7Button5.Text = "Capitulo 5";
            this.Capitulo7Button5.UseVisualStyleBackColor = true;
            this.Capitulo7Button5.Click += new System.EventHandler(this.Capitulo7Button5_Click);
            // 
            // MenuCapitulo7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.Capitulo7Button5);
            this.Controls.Add(this.Capitulo7Button2);
            this.Controls.Add(this.Capitulo7Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCapitulo7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Capitulo 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capitulo7Button1;
        private System.Windows.Forms.Button Capitulo7Button2;
        private System.Windows.Forms.Button Capitulo7Button5;
    }
}