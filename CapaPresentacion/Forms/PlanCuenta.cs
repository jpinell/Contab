using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class PlanCuenta : Form
    {

        //CN_Grupos grupos = new CN_Grupos();
        //CN_Subgrupos subgrupos = new CN_Subgrupos();

        public PlanCuenta()
        {
            InitializeComponent();

        }

        // VARIABLES GLOBALES 
        int vIDGrupo;
        int vIDSubgrupo;

        private void PlanCuenta_Load(object sender, EventArgs e)
        {
            MostrarComboGrupos();
            CargarPlanCuentas();
        }

        private void MostrarComboGrupos()
        {
            List<Grupos> gr = new CN_Grupos().ListarGrupos();
            GrupoComboBox.DataSource = gr;
            GrupoComboBox.DisplayMember = "Cuenta";
            GrupoComboBox.ValueMember = "IDGrupo";
            GrupoComboBox.SelectedIndex = -1;
        }
        private void MostrarSubGruposByGrupos(int id)
        {
            List<Subgrupo> sgr = new CN_Subgrupos().ListarSubgrupos(id);
            SubgrupoComboBox.DataSource = sgr; //subgrupos.MostrarSubgrupos(id);
            SubgrupoComboBox.DisplayMember = "Cuenta";
            SubgrupoComboBox.ValueMember = "IDSubgrupo";
            SubgrupoComboBox.SelectedIndex = -1;
        }
        private void GrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GrupoComboBox.SelectedIndex != -1)
            {
                try
                {
                    vIDGrupo = (int)GrupoComboBox.SelectedValue;
                    label3.Text = vIDGrupo.ToString();
                    MostrarSubGruposByGrupos(vIDGrupo);
                }
                catch (InvalidCastException)
                {
                    return;
                }
            }
        }
        private void SubgrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubgrupoComboBox.SelectedIndex != -1)
            {
                try
                {
                    vIDSubgrupo = (int)SubgrupoComboBox.SelectedValue;
                    label4.Text = vIDSubgrupo.ToString();
                }
                catch (InvalidCastException)
                {
                    return;
                }
            }
        }

        private void CargarPlanCuentas()
        {
            //PlanDataGridView.DataSource = 
        }
    }
}
