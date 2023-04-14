using CapaNegocios;
using System;
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
        }

        private void MostrarSubGruposByGrupos(int id)
        {
            SubgrupoComboBox.DataSource = subgrupos.MostrarSubgrupos(id);
            SubgrupoComboBox.DisplayMember = "Cuenta";
            SubgrupoComboBox.ValueMember = "IDSubgrupo";
        }

        private void GrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubgrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrupoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (GrupoComboBox.SelectedValue != -1)
            //{
            //    vIDGrupo = (int)GrupoComboBox.SelectedIndex;
            //    label3.Text = vIDGrupo.ToString();
            //    MostrarSubGruposByGrupos(vIDGrupo);
            //}
            try
            {
                vIDGrupo = int.Parse(GrupoComboBox.SelectedValue.ToString());
                label3.Text = vIDGrupo.ToString();
                MostrarSubGruposByGrupos(vIDGrupo);
            }
            catch (Exception)
            {

            }



        }

        private void GrupoComboBox_Click(object sender, EventArgs e)
        {
            //if (SubgrupoComboBox.SelectedValue != null)
            //{
            //}
        }

        private void SubgrupoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                vIDSubgrupo = int.Parse(SubgrupoComboBox.SelectedValue.ToString());
                label4.Text = vIDSubgrupo.ToString();

            }
            catch (Exception)
            {


            }

        }
    }
}
