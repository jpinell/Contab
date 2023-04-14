namespace CapaPresentacion.Forms
{
    partial class Periodos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PeriodoTextBox = new System.Windows.Forms.TextBox();
            this.DTPFechaI = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaF = new System.Windows.Forms.DateTimePicker();
            this.PeriodoDataGridView = new System.Windows.Forms.DataGridView();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Período";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(121, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicial";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(233, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Final";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeriodoTextBox
            // 
            this.PeriodoTextBox.Location = new System.Drawing.Point(30, 34);
            this.PeriodoTextBox.Name = "PeriodoTextBox";
            this.PeriodoTextBox.Size = new System.Drawing.Size(85, 23);
            this.PeriodoTextBox.TabIndex = 3;
            this.PeriodoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTPFechaI
            // 
            this.DTPFechaI.CustomFormat = "";
            this.DTPFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaI.Location = new System.Drawing.Point(121, 34);
            this.DTPFechaI.Name = "DTPFechaI";
            this.DTPFechaI.Size = new System.Drawing.Size(101, 23);
            this.DTPFechaI.TabIndex = 4;
            // 
            // DTPFechaF
            // 
            this.DTPFechaF.CustomFormat = "";
            this.DTPFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaF.Location = new System.Drawing.Point(233, 34);
            this.DTPFechaF.Name = "DTPFechaF";
            this.DTPFechaF.Size = new System.Drawing.Size(101, 23);
            this.DTPFechaF.TabIndex = 5;
            // 
            // PeriodoDataGridView
            // 
            this.PeriodoDataGridView.AllowUserToAddRows = false;
            this.PeriodoDataGridView.AllowUserToDeleteRows = false;
            this.PeriodoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PeriodoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeriodoDataGridView.Location = new System.Drawing.Point(30, 63);
            this.PeriodoDataGridView.Name = "PeriodoDataGridView";
            this.PeriodoDataGridView.ReadOnly = true;
            this.PeriodoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PeriodoDataGridView.Size = new System.Drawing.Size(396, 167);
            this.PeriodoDataGridView.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.GuardarButton.IconColor = System.Drawing.Color.Black;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.Location = new System.Drawing.Point(165, 236);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(121, 33);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // Periodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.PeriodoDataGridView);
            this.Controls.Add(this.DTPFechaF);
            this.Controls.Add(this.DTPFechaI);
            this.Controls.Add(this.PeriodoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Periodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Períodos Contables";
            this.Load += new System.EventHandler(this.Periodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PeriodoTextBox;
        private System.Windows.Forms.DateTimePicker DTPFechaI;
        private System.Windows.Forms.DateTimePicker DTPFechaF;
        private System.Windows.Forms.DataGridView PeriodoDataGridView;
        private FontAwesome.Sharp.IconButton GuardarButton;
    }
}