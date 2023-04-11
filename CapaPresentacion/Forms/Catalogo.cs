﻿using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        readonly CN_Clasificacion objCla = new CN_Clasificacion();
        readonly CN_Estructura objEst = new CN_Estructura();
        readonly CN_Clases objClase = new CN_Clases ();


        int vClasificacion;
        int vNivel;
        int vClase;

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboClasificacion();
            CargarComboEstructura();
            CargarComboClases();
        }

        private void CargarComboClasificacion()
        {
            ClasificacionComboBox.DataSource = objCla.MostrarDatos();
            ClasificacionComboBox.DisplayMember = "Clasificacion";
            ClasificacionComboBox.ValueMember = "IDClasificacion";
            ClasificacionComboBox.SelectedIndex = -1;
        }
        private void CargarComboEstructura()
        {
            EstructuraComboBox.DataSource = objEst.MostrarDatos();
            EstructuraComboBox.DisplayMember = "Clasificacion";
            EstructuraComboBox.ValueMember = "IDNivel";
            EstructuraComboBox.SelectedIndex = -1;
        }
        private void CargarComboClases()
        {
            ClasesComboBox.DataSource = objClase .MostrarDatos();
            ClasesComboBox.DisplayMember = "Clase";
            ClasesComboBox.ValueMember = "IDClase";
            ClasesComboBox.SelectedIndex = -1;
        }
        private void ClasificacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vClasificacion = ClasificacionComboBox.SelectedIndex + 1;
            label2.Text = vClasificacion.ToString();
        }
        private void EstructuraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vNivel = EstructuraComboBox.SelectedIndex + 1;
            label4.Text = vNivel.ToString();
        }

        private void ClasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vClase = ClasesComboBox.SelectedIndex + 1;
            label5.Text = vClase.ToString();
        }
    }
}