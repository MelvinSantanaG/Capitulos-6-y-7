
namespace Capitulo_6_y_7
{
    partial class MainForm

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CapituloButton6 = new System.Windows.Forms.Button();
            this.CapituloButton7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CapituloButton6
            // 
            this.CapituloButton6.Location = new System.Drawing.Point(12, 33);
            this.CapituloButton6.Name = "CapituloButton6";
            this.CapituloButton6.Size = new System.Drawing.Size(75, 23);
            this.CapituloButton6.TabIndex = 0;
            this.CapituloButton6.Text = "Capitulo 6";
            this.CapituloButton6.UseVisualStyleBackColor = true;
            this.CapituloButton6.Click += new System.EventHandler(this.CapituloButton6_Click);
            // 
            // CapituloButton7
            // 
            this.CapituloButton7.Location = new System.Drawing.Point(112, 33);
            this.CapituloButton7.Name = "CapituloButton7";
            this.CapituloButton7.Size = new System.Drawing.Size(75, 23);
            this.CapituloButton7.TabIndex = 1;
            this.CapituloButton7.Text = "Capitulo 7";
            this.CapituloButton7.UseVisualStyleBackColor = true;
            this.CapituloButton7.Click += new System.EventHandler(this.CapituloButton7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(199, 86);
            this.Controls.Add(this.CapituloButton7);
            this.Controls.Add(this.CapituloButton6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CapituloButton6;
        private System.Windows.Forms.Button CapituloButton7;
    }
}

