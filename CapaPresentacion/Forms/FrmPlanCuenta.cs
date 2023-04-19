using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FrmPlanCuenta : Form
    {

        CN_Grupos grupos = new CN_Grupos();
        CN_Subgrupos subgrupos = new CN_Subgrupos();

        PlanCuenta objEntidad = new PlanCuenta();
        CN_PlanCuenta objNegocio = new CN_PlanCuenta();

        public FrmPlanCuenta()
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
            var sg = subgrupos.MostrarSubgrupos();

        }

     

        private void MostrarComboGrupos()
        {
            //List<Grupos> gr = new CN_Grupos().ListarGrupos();
            GrupoComboBox.DataSource = grupos.MostrarGrupos();
            GrupoComboBox.DisplayMember = "Cuenta";
            GrupoComboBox.ValueMember = "IDGrupo";
            GrupoComboBox.SelectedIndex = -1;
        }

        private void MostrarSubGruposByGrupos(int id)
        {
            //List<Subgrupos> sgr = new CN_Subgrupos().ListarSubgrupos(id);
            SubgrupoComboBox.DataSource = subgrupos.MostrarSubgruposByGrupo(id);
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
            List<PlanCuenta> plan = new CN_PlanCuenta().ListarPlanCuenta();

            if (plan.Count > 0)
            {
                PlanDataGridView.DataSource = plan;
            }
            else
            {
                //// RECORREMOS LA TABLA GRUPOS Y SUBGRUPOS
                //for (int i = 0; i < gr.Count; i++)
                //{
                //    gr.Add(gr[i]);
                //    for (int j = 0; j < sgr.Count; j++)
                //    {
                //        sgr.Add(sgr[j]);
                //    }
                //}



                // MAPEAMOS LOS CAMPOS EN LAS ENTIDADES 

                //objEntidad.Codigo = vIDGrupo;
                //objEntidad.Cuenta =
            }
        }
    }
}
