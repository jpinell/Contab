using CapaNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class PlanCuenta : Form
    {
        CN_Grupos grupos = new CN_Grupos();
        CN_Subgrupos subgrupos = new CN_Subgrupos();
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
        }

        private void MostrarComboGrupos()
        {
            GrupoComboBox.DataSource = grupos.MostrarGrupos();
            GrupoComboBox.DisplayMember = "Cuenta";
            GrupoComboBox.ValueMember = "IDGrupo";
            GrupoComboBox.SelectedIndex = -1;
        }

        private void MostrarSubGruposByGrupos(int id)
        {
            SubgrupoComboBox.DataSource = subgrupos.MostrarSubgrupos(id);
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
    }
}
