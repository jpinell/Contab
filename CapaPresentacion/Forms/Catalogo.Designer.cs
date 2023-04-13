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
            this.EstructuraComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClasesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatalogoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DigitosTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            this.NaturalezaComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupoTextBox = new System.Windows.Forms.TextBox();
            this.CuentaTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DetalleRadioButton = new System.Windows.Forms.RadioButton();
            this.GrupoRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clasificación de la Cuenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClasificacionComboBox
            // 
            this.ClasificacionComboBox.FormattingEnabled = true;
            this.ClasificacionComboBox.Location = new System.Drawing.Point(14, 81);
            this.ClasificacionComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClasificacionComboBox.Name = "ClasificacionComboBox";
            this.ClasificacionComboBox.Size = new System.Drawing.Size(231, 23);
            this.ClasificacionComboBox.TabIndex = 1;
            this.ClasificacionComboBox.SelectedIndexChanged += new System.EventHandler(this.ClasificacionComboBox_SelectedIndexChanged);
            // 
            // EstructuraComboBox
            // 
            this.EstructuraComboBox.FormattingEnabled = true;
            this.EstructuraComboBox.Location = new System.Drawing.Point(14, 33);
            this.EstructuraComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EstructuraComboBox.Name = "EstructuraComboBox";
            this.EstructuraComboBox.Size = new System.Drawing.Size(231, 23);
            this.EstructuraComboBox.TabIndex = 3;
            this.EstructuraComboBox.SelectedIndexChanged += new System.EventHandler(this.EstructuraComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione la clasificación";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClasesComboBox
            // 
            this.ClasesComboBox.FormattingEnabled = true;
            this.ClasesComboBox.Location = new System.Drawing.Point(14, 132);
            this.ClasesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClasesComboBox.Name = "ClasesComboBox";
            this.ClasesComboBox.Size = new System.Drawing.Size(231, 23);
            this.ClasesComboBox.TabIndex = 6;
            this.ClasesComboBox.SelectedIndexChanged += new System.EventHandler(this.ClasesComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de Cuenta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CatalogoDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 481);
            this.panel1.TabIndex = 9;
            // 
            // CatalogoDataGridView
            // 
            this.CatalogoDataGridView.AllowUserToAddRows = false;
            this.CatalogoDataGridView.AllowUserToDeleteRows = false;
            this.CatalogoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CatalogoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatalogoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CatalogoDataGridView.Name = "CatalogoDataGridView";
            this.CatalogoDataGridView.ReadOnly = true;
            this.CatalogoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatalogoDataGridView.Size = new System.Drawing.Size(673, 481);
            this.CatalogoDataGridView.TabIndex = 0;
            this.CatalogoDataGridView.Click += new System.EventHandler(this.CatalogoDataGridView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DigitosTextBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ClasesComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ClasificacionComboBox);
            this.panel2.Controls.Add(this.EstructuraComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(690, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 481);
            this.panel2.TabIndex = 10;
            // 
            // DigitosTextBox
            // 
            this.DigitosTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DigitosTextBox.Enabled = false;
            this.DigitosTextBox.Location = new System.Drawing.Point(249, 33);
            this.DigitosTextBox.Name = "DigitosTextBox";
            this.DigitosTextBox.Size = new System.Drawing.Size(33, 23);
            this.DigitosTextBox.TabIndex = 9;
            this.DigitosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.GuardarButton);
            this.panel4.Controls.Add(this.NaturalezaComboBox);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.GrupoTextBox);
            this.panel4.Controls.Add(this.CuentaTextBox);
            this.panel4.Controls.Add(this.CodigoTextBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.DetalleRadioButton);
            this.panel4.Controls.Add(this.GrupoRadioButton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 301);
            this.panel4.TabIndex = 1;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.GuardarButton.IconColor = System.Drawing.Color.Black;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.Location = new System.Drawing.Point(98, 249);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(121, 33);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NaturalezaComboBox
            // 
            this.NaturalezaComboBox.FormattingEnabled = true;
            this.NaturalezaComboBox.Items.AddRange(new object[] {
            "DEUDORA",
            "ACREEDORA"});
            this.NaturalezaComboBox.Location = new System.Drawing.Point(121, 210);
            this.NaturalezaComboBox.Name = "NaturalezaComboBox";
            this.NaturalezaComboBox.Size = new System.Drawing.Size(98, 23);
            this.NaturalezaComboBox.TabIndex = 9;
            this.NaturalezaComboBox.SelectedValueChanged += new System.EventHandler(this.NaturalezaComboBox_SelectedValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 29);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUEVA CUENTA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrupoTextBox
            // 
            this.GrupoTextBox.Location = new System.Drawing.Point(121, 175);
            this.GrupoTextBox.Name = "GrupoTextBox";
            this.GrupoTextBox.Size = new System.Drawing.Size(98, 23);
            this.GrupoTextBox.TabIndex = 8;
            // 
            // CuentaTextBox
            // 
            this.CuentaTextBox.Location = new System.Drawing.Point(96, 104);
            this.CuentaTextBox.Name = "CuentaTextBox";
            this.CuentaTextBox.Size = new System.Drawing.Size(186, 23);
            this.CuentaTextBox.TabIndex = 7;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(96, 67);
            this.CodigoTextBox.MaxLength = 10;
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(100, 23);
            this.CodigoTextBox.TabIndex = 6;
            this.CodigoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Naturaleza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Grupo Anterior:";
            // 
            // DetalleRadioButton
            // 
            this.DetalleRadioButton.AutoSize = true;
            this.DetalleRadioButton.Location = new System.Drawing.Point(177, 133);
            this.DetalleRadioButton.Name = "DetalleRadioButton";
            this.DetalleRadioButton.Size = new System.Drawing.Size(68, 20);
            this.DetalleRadioButton.TabIndex = 3;
            this.DetalleRadioButton.TabStop = true;
            this.DetalleRadioButton.Text = "Detalle";
            this.DetalleRadioButton.UseVisualStyleBackColor = true;
            this.DetalleRadioButton.CheckedChanged += new System.EventHandler(this.DetalleRadioButton_CheckedChanged);
            // 
            // GrupoRadioButton
            // 
            this.GrupoRadioButton.AutoSize = true;
            this.GrupoRadioButton.Location = new System.Drawing.Point(98, 133);
            this.GrupoRadioButton.Name = "GrupoRadioButton";
            this.GrupoRadioButton.Size = new System.Drawing.Size(63, 20);
            this.GrupoRadioButton.TabIndex = 2;
            this.GrupoRadioButton.TabStop = true;
            this.GrupoRadioButton.Text = "Grupo";
            this.GrupoRadioButton.UseVisualStyleBackColor = true;
            this.GrupoRadioButton.CheckedChanged += new System.EventHandler(this.GrupoRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Cuentas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatalogoDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClasificacionComboBox;
        private System.Windows.Forms.ComboBox EstructuraComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClasesComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CatalogoDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton GuardarButton;
        private System.Windows.Forms.ComboBox NaturalezaComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GrupoTextBox;
        private System.Windows.Forms.TextBox CuentaTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton DetalleRadioButton;
        private System.Windows.Forms.RadioButton GrupoRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DigitosTextBox;
    }
}