namespace CapaPresentacion.Forms
{
    partial class Catalogo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClasificacionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EstructuraComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClasesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clasificacion de la Cuenta:";
            // 
            // ClasificacionComboBox
            // 
            this.ClasificacionComboBox.FormattingEnabled = true;
            this.ClasificacionComboBox.Location = new System.Drawing.Point(150, 6);
            this.ClasificacionComboBox.Name = "ClasificacionComboBox";
            this.ClasificacionComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClasificacionComboBox.TabIndex = 1;
            this.ClasificacionComboBox.SelectedIndexChanged += new System.EventHandler(this.ClasificacionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // EstructuraComboBox
            // 
            this.EstructuraComboBox.FormattingEnabled = true;
            this.EstructuraComboBox.Location = new System.Drawing.Point(150, 33);
            this.EstructuraComboBox.Name = "EstructuraComboBox";
            this.EstructuraComboBox.Size = new System.Drawing.Size(121, 21);
            this.EstructuraComboBox.TabIndex = 3;
            this.EstructuraComboBox.SelectedIndexChanged += new System.EventHandler(this.EstructuraComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estructura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // ClasesComboBox
            // 
            this.ClasesComboBox.FormattingEnabled = true;
            this.ClasesComboBox.Location = new System.Drawing.Point(150, 60);
            this.ClasesComboBox.Name = "ClasesComboBox";
            this.ClasesComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClasesComboBox.TabIndex = 6;
            this.ClasesComboBox.SelectedIndexChanged += new System.EventHandler(this.ClasesComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Clases:";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClasesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EstructuraComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClasificacionComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Cuentas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClasificacionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EstructuraComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClasesComboBox;
        private System.Windows.Forms.Label label6;
    }
}