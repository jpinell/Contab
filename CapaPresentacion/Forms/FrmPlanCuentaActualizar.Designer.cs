namespace CapaPresentacion.Forms
{
    partial class FrmPlanCuentaActualizar
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
            this.ActualiarButton = new FontAwesome.Sharp.IconButton();
            this.DetalleRadioButton = new System.Windows.Forms.RadioButton();
            this.GrupoRadioButton = new System.Windows.Forms.RadioButton();
            this.NaturalezaComboBox = new System.Windows.Forms.ComboBox();
            this.PresentacionComboBox = new System.Windows.Forms.ComboBox();
            this.CuentaTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDPlanTextBox = new System.Windows.Forms.TextBox();
            this.NivelTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrupoAnteriorTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActualiarButton
            // 
            this.ActualiarButton.BackColor = System.Drawing.Color.White;
            this.ActualiarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualiarButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualiarButton.ForeColor = System.Drawing.Color.Navy;
            this.ActualiarButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ActualiarButton.IconColor = System.Drawing.Color.Navy;
            this.ActualiarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualiarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ActualiarButton.Location = new System.Drawing.Point(123, 323);
            this.ActualiarButton.Name = "ActualiarButton";
            this.ActualiarButton.Size = new System.Drawing.Size(101, 77);
            this.ActualiarButton.TabIndex = 40;
            this.ActualiarButton.Text = "Actualizar";
            this.ActualiarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualiarButton.UseVisualStyleBackColor = false;
            this.ActualiarButton.Click += new System.EventHandler(this.ActualiarButton_Click);
            // 
            // DetalleRadioButton
            // 
            this.DetalleRadioButton.AutoSize = true;
            this.DetalleRadioButton.Location = new System.Drawing.Point(183, 199);
            this.DetalleRadioButton.Name = "DetalleRadioButton";
            this.DetalleRadioButton.Size = new System.Drawing.Size(58, 17);
            this.DetalleRadioButton.TabIndex = 39;
            this.DetalleRadioButton.TabStop = true;
            this.DetalleRadioButton.Text = "Detalle";
            this.DetalleRadioButton.UseVisualStyleBackColor = true;
            this.DetalleRadioButton.CheckedChanged += new System.EventHandler(this.DetalleRadioButton_CheckedChanged);
            // 
            // GrupoRadioButton
            // 
            this.GrupoRadioButton.AutoSize = true;
            this.GrupoRadioButton.Location = new System.Drawing.Point(123, 199);
            this.GrupoRadioButton.Name = "GrupoRadioButton";
            this.GrupoRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GrupoRadioButton.TabIndex = 38;
            this.GrupoRadioButton.TabStop = true;
            this.GrupoRadioButton.Text = "Grupo";
            this.GrupoRadioButton.UseVisualStyleBackColor = true;
            this.GrupoRadioButton.CheckedChanged += new System.EventHandler(this.GrupoRadioButton_CheckedChanged);
            // 
            // NaturalezaComboBox
            // 
            this.NaturalezaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NaturalezaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NaturalezaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NaturalezaComboBox.FormattingEnabled = true;
            this.NaturalezaComboBox.Items.AddRange(new object[] {
            "DEUDORA",
            "ACREEDORA"});
            this.NaturalezaComboBox.Location = new System.Drawing.Point(123, 282);
            this.NaturalezaComboBox.Name = "NaturalezaComboBox";
            this.NaturalezaComboBox.Size = new System.Drawing.Size(169, 21);
            this.NaturalezaComboBox.TabIndex = 37;
            this.NaturalezaComboBox.SelectedIndexChanged += new System.EventHandler(this.NaturalezaComboBox_SelectedIndexChanged);
            // 
            // PresentacionComboBox
            // 
            this.PresentacionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PresentacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PresentacionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PresentacionComboBox.FormattingEnabled = true;
            this.PresentacionComboBox.Items.AddRange(new object[] {
            "BALANCE",
            "RESULTADO"});
            this.PresentacionComboBox.Location = new System.Drawing.Point(123, 156);
            this.PresentacionComboBox.Name = "PresentacionComboBox";
            this.PresentacionComboBox.Size = new System.Drawing.Size(169, 21);
            this.PresentacionComboBox.TabIndex = 36;
            this.PresentacionComboBox.SelectedIndexChanged += new System.EventHandler(this.PresentacionComboBox_SelectedIndexChanged);
            // 
            // CuentaTextBox
            // 
            this.CuentaTextBox.Location = new System.Drawing.Point(123, 114);
            this.CuentaTextBox.Name = "CuentaTextBox";
            this.CuentaTextBox.Size = new System.Drawing.Size(169, 20);
            this.CuentaTextBox.TabIndex = 35;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(123, 72);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoTextBox.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(38, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Naturaleza:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Afectable:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Presentación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(62, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(63, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Código:";
            // 
            // IDPlanTextBox
            // 
            this.IDPlanTextBox.Location = new System.Drawing.Point(229, 72);
            this.IDPlanTextBox.Name = "IDPlanTextBox";
            this.IDPlanTextBox.Size = new System.Drawing.Size(39, 20);
            this.IDPlanTextBox.TabIndex = 41;
            // 
            // NivelTextBox
            // 
            this.NivelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NivelTextBox.Location = new System.Drawing.Point(122, 31);
            this.NivelTextBox.Name = "NivelTextBox";
            this.NivelTextBox.ReadOnly = true;
            this.NivelTextBox.Size = new System.Drawing.Size(36, 20);
            this.NivelTextBox.TabIndex = 43;
            this.NivelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nivel Siguiente:";
            // 
            // GrupoAnteriorTextBox
            // 
            this.GrupoAnteriorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrupoAnteriorTextBox.Location = new System.Drawing.Point(123, 240);
            this.GrupoAnteriorTextBox.Name = "GrupoAnteriorTextBox";
            this.GrupoAnteriorTextBox.ReadOnly = true;
            this.GrupoAnteriorTextBox.Size = new System.Drawing.Size(81, 20);
            this.GrupoAnteriorTextBox.TabIndex = 45;
            this.GrupoAnteriorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Grupo Anterior:";
            // 
            // FrmPlanCuentaActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(324, 421);
            this.Controls.Add(this.GrupoAnteriorTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NivelTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDPlanTextBox);
            this.Controls.Add(this.ActualiarButton);
            this.Controls.Add(this.DetalleRadioButton);
            this.Controls.Add(this.GrupoRadioButton);
            this.Controls.Add(this.NaturalezaComboBox);
            this.Controls.Add(this.PresentacionComboBox);
            this.Controls.Add(this.CuentaTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlanCuentaActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualización de Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ActualiarButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CuentaTextBox;
        public System.Windows.Forms.TextBox CodigoTextBox;
        public System.Windows.Forms.RadioButton DetalleRadioButton;
        public System.Windows.Forms.RadioButton GrupoRadioButton;
        public System.Windows.Forms.ComboBox NaturalezaComboBox;
        public System.Windows.Forms.ComboBox PresentacionComboBox;
        public System.Windows.Forms.TextBox IDPlanTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox NivelTextBox;
        public System.Windows.Forms.TextBox GrupoAnteriorTextBox;
        private System.Windows.Forms.Label label10;
    }
}