namespace CapaPresentacion.Forms
{
    partial class FrmPlanCuenta
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
            this.PlanDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GrupoAnteriorTextBox = new System.Windows.Forms.TextBox();
            this.NivelTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.CuentaTextBox = new System.Windows.Forms.TextBox();
            this.PresentacionComboBox = new System.Windows.Forms.ComboBox();
            this.NaturalezaComboBox = new System.Windows.Forms.ComboBox();
            this.GrupoRadioButton = new System.Windows.Forms.RadioButton();
            this.DetalleRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PlanDataGridView)).BeginInit();
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
            this.GrupoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrupoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrupoComboBox.FormattingEnabled = true;
            this.GrupoComboBox.Location = new System.Drawing.Point(88, 6);
            this.GrupoComboBox.Name = "GrupoComboBox";
            this.GrupoComboBox.Size = new System.Drawing.Size(212, 23);
            this.GrupoComboBox.TabIndex = 1;
            this.GrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.GrupoComboBox_SelectedIndexChanged);
            // 
            // SubgrupoComboBox
            // 
            this.SubgrupoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SubgrupoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubgrupoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubgrupoComboBox.FormattingEnabled = true;
            this.SubgrupoComboBox.Location = new System.Drawing.Point(88, 35);
            this.SubgrupoComboBox.Name = "SubgrupoComboBox";
            this.SubgrupoComboBox.Size = new System.Drawing.Size(212, 23);
            this.SubgrupoComboBox.TabIndex = 3;
            this.SubgrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.SubgrupoComboBox_SelectedIndexChanged);
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
            // PlanDataGridView
            // 
            this.PlanDataGridView.AllowUserToAddRows = false;
            this.PlanDataGridView.AllowUserToDeleteRows = false;
            this.PlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanDataGridView.Location = new System.Drawing.Point(12, 64);
            this.PlanDataGridView.Name = "PlanDataGridView";
            this.PlanDataGridView.ReadOnly = true;
            this.PlanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlanDataGridView.Size = new System.Drawing.Size(866, 443);
            this.PlanDataGridView.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nivel:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(946, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Código:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(944, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cuenta:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(908, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Presentación:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(930, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Afectable:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(894, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Grupo Anterior:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(920, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Naturaleza:";
            // 
            // GrupoAnteriorTextBox
            // 
            this.GrupoAnteriorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoAnteriorTextBox.Location = new System.Drawing.Point(1004, 266);
            this.GrupoAnteriorTextBox.Name = "GrupoAnteriorTextBox";
            this.GrupoAnteriorTextBox.Size = new System.Drawing.Size(100, 23);
            this.GrupoAnteriorTextBox.TabIndex = 14;
            // 
            // NivelTextBox
            // 
            this.NivelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NivelTextBox.Location = new System.Drawing.Point(1004, 61);
            this.NivelTextBox.Name = "NivelTextBox";
            this.NivelTextBox.Size = new System.Drawing.Size(36, 23);
            this.NivelTextBox.TabIndex = 15;
            this.NivelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CodigoTextBox.Location = new System.Drawing.Point(1004, 102);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(100, 23);
            this.CodigoTextBox.TabIndex = 16;
            // 
            // CuentaTextBox
            // 
            this.CuentaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CuentaTextBox.Location = new System.Drawing.Point(1004, 143);
            this.CuentaTextBox.Name = "CuentaTextBox";
            this.CuentaTextBox.Size = new System.Drawing.Size(169, 23);
            this.CuentaTextBox.TabIndex = 17;
            // 
            // PresentacionComboBox
            // 
            this.PresentacionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PresentacionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PresentacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PresentacionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PresentacionComboBox.FormattingEnabled = true;
            this.PresentacionComboBox.Items.AddRange(new object[] {
            "BALANCE",
            "RESULTADO"});
            this.PresentacionComboBox.Location = new System.Drawing.Point(1004, 184);
            this.PresentacionComboBox.Name = "PresentacionComboBox";
            this.PresentacionComboBox.Size = new System.Drawing.Size(169, 23);
            this.PresentacionComboBox.TabIndex = 18;
            this.PresentacionComboBox.SelectedIndexChanged += new System.EventHandler(this.PresentacionComboBox_SelectedIndexChanged);
            // 
            // NaturalezaComboBox
            // 
            this.NaturalezaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NaturalezaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NaturalezaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NaturalezaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NaturalezaComboBox.FormattingEnabled = true;
            this.NaturalezaComboBox.Items.AddRange(new object[] {
            "DEUDORA",
            "ACREEDORA"});
            this.NaturalezaComboBox.Location = new System.Drawing.Point(1004, 307);
            this.NaturalezaComboBox.Name = "NaturalezaComboBox";
            this.NaturalezaComboBox.Size = new System.Drawing.Size(169, 23);
            this.NaturalezaComboBox.TabIndex = 19;
            this.NaturalezaComboBox.SelectedIndexChanged += new System.EventHandler(this.NaturalezaComboBox_SelectedIndexChanged);
            // 
            // GrupoRadioButton
            // 
            this.GrupoRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoRadioButton.AutoSize = true;
            this.GrupoRadioButton.Location = new System.Drawing.Point(1005, 226);
            this.GrupoRadioButton.Name = "GrupoRadioButton";
            this.GrupoRadioButton.Size = new System.Drawing.Size(63, 20);
            this.GrupoRadioButton.TabIndex = 20;
            this.GrupoRadioButton.TabStop = true;
            this.GrupoRadioButton.Text = "Grupo";
            this.GrupoRadioButton.UseVisualStyleBackColor = true;
            // 
            // DetalleRadioButton
            // 
            this.DetalleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleRadioButton.AutoSize = true;
            this.DetalleRadioButton.Location = new System.Drawing.Point(1074, 226);
            this.DetalleRadioButton.Name = "DetalleRadioButton";
            this.DetalleRadioButton.Size = new System.Drawing.Size(68, 20);
            this.DetalleRadioButton.TabIndex = 21;
            this.DetalleRadioButton.TabStop = true;
            this.DetalleRadioButton.Text = "Detalle";
            this.DetalleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FrmPlanCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 545);
            this.Controls.Add(this.DetalleRadioButton);
            this.Controls.Add(this.GrupoRadioButton);
            this.Controls.Add(this.NaturalezaComboBox);
            this.Controls.Add(this.PresentacionComboBox);
            this.Controls.Add(this.CuentaTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.NivelTextBox);
            this.Controls.Add(this.GrupoAnteriorTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlanDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubgrupoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrupoComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPlanCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan de Cuenta Contables";
            this.Load += new System.EventHandler(this.PlanCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView PlanDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GrupoAnteriorTextBox;
        private System.Windows.Forms.TextBox NivelTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox CuentaTextBox;
        private System.Windows.Forms.ComboBox PresentacionComboBox;
        private System.Windows.Forms.ComboBox NaturalezaComboBox;
        private System.Windows.Forms.RadioButton GrupoRadioButton;
        private System.Windows.Forms.RadioButton DetalleRadioButton;
    }
}