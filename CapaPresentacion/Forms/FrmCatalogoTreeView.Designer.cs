﻿namespace CapaPresentacion.Forms
{
    partial class FrmCatalogoTreeView
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
            this.CatalogoTreeView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CatalogoTreeView
            // 
            this.CatalogoTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.CatalogoTreeView.Location = new System.Drawing.Point(0, 0);
            this.CatalogoTreeView.Name = "CatalogoTreeView";
            this.CatalogoTreeView.Size = new System.Drawing.Size(330, 450);
            this.CatalogoTreeView.TabIndex = 0;
            this.CatalogoTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.CatalogoTreeView_BeforeExpand);
            this.CatalogoTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CatalogoTreeView_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(330, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(349, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FrmCatalogoTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.CatalogoTreeView);
            this.Name = "FrmCatalogoTreeView";
            this.Text = "Catalogo de Cuentas";
            this.Load += new System.EventHandler(this.FrmCatalogoTreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView CatalogoTreeView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
    }
}