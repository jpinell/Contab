namespace CapaPresentacion.Forms
{
    partial class PlanCuenta
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
            this.GrupoComboBox = new System.Windows.Forms.ComboBox();
            this.SubgrupoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo:";
            // 
            // GrupoComboBox
            // 
            this.GrupoComboBox.FormattingEnabled = true;
            this.GrupoComboBox.Location = new System.Drawing.Point(88, 6);
            this.GrupoComboBox.Name = "GrupoComboBox";
            this.GrupoComboBox.Size = new System.Drawing.Size(212, 23);
            this.GrupoComboBox.TabIndex = 1;
            this.GrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.GrupoComboBox_SelectedIndexChanged);
            this.GrupoComboBox.SelectedValueChanged += new System.EventHandler(this.GrupoComboBox_SelectedValueChanged);
            this.GrupoComboBox.Click += new System.EventHandler(this.GrupoComboBox_Click);
            // 
            // SubgrupoComboBox
            // 
            this.SubgrupoComboBox.FormattingEnabled = true;
            this.SubgrupoComboBox.Location = new System.Drawing.Point(88, 35);
            this.SubgrupoComboBox.Name = "SubgrupoComboBox";
            this.SubgrupoComboBox.Size = new System.Drawing.Size(212, 23);
            this.SubgrupoComboBox.TabIndex = 3;
            this.SubgrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.SubgrupoComboBox_SelectedIndexChanged);
            this.SubgrupoComboBox.SelectedValueChanged += new System.EventHandler(this.SubgrupoComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subgrupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // PlanCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubgrupoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrupoComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PlanCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan de Cuenta Contables";
            this.Load += new System.EventHandler(this.PlanCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GrupoComboBox;
        private System.Windows.Forms.ComboBox SubgrupoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}