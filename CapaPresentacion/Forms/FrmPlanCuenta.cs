using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Data;
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
        int vPresentacion;
        char vNaturaleza;
        bool vAfectable;
        //*******************

        //VARIABLES PARA INICIALIZAR POR PRIMERA VEZ LOS GRUPOS Y SUBGRUPOS
        int idg;
        string ctagrupo;
        string cod;
        string ctasubgrupo;
        // ****************************************************************

        private void PlanCuenta_Load(object sender, EventArgs e)
        {
            MostrarComboGrupos();
            CargarPlanCuentas();
            FormatoGrilla();
        }

        private void FormatoGrilla()
        {
            PlanDataGridView.Columns[0].Visible = false;
            PlanDataGridView.Columns[3].Width = 300;
            PlanDataGridView.Columns[4].Visible = false;
            PlanDataGridView.Columns[6].Visible = false;
            PlanDataGridView.Columns[7].Visible = false;
        }

        private void RecuperarGrupo()
        {
            foreach (var item in grupos.ListarGrupos())
            {
                idg = item.IDGrupo;

                switch (idg)
                {
                    case 1:
                        vPresentacion = 1; break;
                    case 2:
                        vPresentacion = 1; break;
                    case 3:
                        vPresentacion = 1; break;
                    default:
                        vPresentacion = 2; break;
                }

                ctagrupo = item.Cuenta;

                objEntidad.Nivel = 1;
                objEntidad.Codigo = idg.ToString();
                objEntidad.Cuenta = ctagrupo.ToString();
                objEntidad.Presentacion = vPresentacion;
                objEntidad.Afectable = false;
                objEntidad.GrupoAnterior = "0";
                objEntidad.Naturaleza = ' ';
                objNegocio.InsertarPlanCuenta(objEntidad);

                RecuperarSubGrupo((int)idg);
            }
        }

        private void RecuperarSubGrupo(int idg)
        {
            foreach (var item in subgrupos.ListarSubgrupos(idg))
            {
                cod = item.Codigo;
                ctasubgrupo = item.Cuenta;

                objEntidad.Nivel = 2;
                objEntidad.Codigo = cod;
                objEntidad.Cuenta = ctasubgrupo.ToString();
                objEntidad.Presentacion = vPresentacion;
                objEntidad.Afectable = false;
                objEntidad.GrupoAnterior = idg.ToString();
                objEntidad.Naturaleza = ' ';
                objNegocio.InsertarPlanCuenta(objEntidad);
            }
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
                TotalCuentasTextBox.Text = plan.Count.ToString();
            }
            else
            {
                RecuperarGrupo();
                CargarPlanCuentas();
            }
        }

        private void PresentacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PresentacionComboBox.Text == "BALANCE")
            {
                vPresentacion = 1;
            }
            else
            {
                vPresentacion = 2;
            }
            MessageBox.Show(vPresentacion.ToString());
        }

        private void NaturalezaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (NaturalezaComboBox.Text == "DEUDORA")
            {
                vNaturaleza = 'D';
            }
            else
            {
                vNaturaleza = 'A';
            }
            MessageBox.Show(vNaturaleza.ToString());
        }

        private void GrupoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            vAfectable = false;
        }

        private void DetalleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            vAfectable = true;
        }

        private void PlanDataGridView_Click(object sender, EventArgs e)
        {
            NivelTextBox.Text = PlanDataGridView.CurrentRow.Cells[1].Value.ToString();
            GrupoAnteriorTextBox.Text = PlanDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
