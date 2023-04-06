namespace CapaPresentacion.Forms
{
    partial class Empresa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmpresaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.RucTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new FontAwesome.Sharp.IconButton();
            this.ActualizarButton = new FontAwesome.Sharp.IconButton();
            this.EliminarButton = new FontAwesome.Sharp.IconButton();
            this.CancelarButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpresaDataGridView
            // 
            this.EmpresaDataGridView.AllowUserToAddRows = false;
            this.EmpresaDataGridView.AllowUserToDeleteRows = false;
            this.EmpresaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpresaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpresaDataGridView.Location = new System.Drawing.Point(19, 181);
            this.EmpresaDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmpresaDataGridView.MultiSelect = false;
            this.EmpresaDataGridView.Name = "EmpresaDataGridView";
            this.EmpresaDataGridView.ReadOnly = true;
            this.EmpresaDataGridView.RowHeadersVisible = false;
            this.EmpresaDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpresaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpresaDataGridView.Size = new System.Drawing.Size(622, 191);
            this.EmpresaDataGridView.TabIndex = 0;
            this.EmpresaDataGridView.TabStop = false;
            this.EmpresaDataGridView.Click += new System.EventHandler(this.EmpresaDataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. RUC:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(160, 6);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(481, 21);
            this.NombreTextBox.TabIndex = 0;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(160, 39);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(481, 21);
            this.DireccionTextBox.TabIndex = 1;
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(160, 72);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(100, 21);
            this.TelefonoTextBox.TabIndex = 2;
            // 
            // RucTextBox
            // 
            this.RucTextBox.Location = new System.Drawing.Point(160, 105);
            this.RucTextBox.Name = "RucTextBox";
            this.RucTextBox.Size = new System.Drawing.Size(158, 21);
            this.RucTextBox.TabIndex = 3;
            // 
            // GuardarButton
            // 
            this.GuardarButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.GuardarButton.IconColor = System.Drawing.Color.DarkGreen;
            this.GuardarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarButton.IconSize = 24;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(160, 141);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 34);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ActualizarButton.IconColor = System.Drawing.Color.Navy;
            this.ActualizarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarButton.IconSize = 24;
            this.ActualizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualizarButton.Location = new System.Drawing.Point(266, 141);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(100, 34);
            this.ActualizarButton.TabIndex = 6;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.EliminarButton.IconColor = System.Drawing.Color.DarkRed;
            this.EliminarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarButton.IconSize = 24;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(372, 141);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 34);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.CancelarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarButton.IconSize = 24;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(541, 141);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(100, 34);
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 388);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.RucTextBox);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpresaDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE EMPRESAS";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpresaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.TextBox RucTextBox;
        private FontAwesome.Sharp.IconButton GuardarButton;
        private FontAwesome.Sharp.IconButton ActualizarButton;
        private FontAwesome.Sharp.IconButton EliminarButton;
        private FontAwesome.Sharp.IconButton CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

