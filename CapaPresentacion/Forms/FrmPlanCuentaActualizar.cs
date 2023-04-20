using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FrmPlanCuentaActualizar : Form
    {
        PlanCuenta objEntidad = new PlanCuenta();
        CN_PlanCuenta objNegocio = new CN_PlanCuenta();

        public FrmPlanCuentaActualizar()
        {
            InitializeComponent();
        }
        int vPresentacion;
        char vNaturaleza;
        bool vAfectable;

        private void ActualiarButton_Click(object sender, EventArgs e)
        {
            objEntidad.IDPlan = Convert.ToInt32(IDPlanTextBox.Text);
            objEntidad.Nivel = Convert.ToInt32(NivelTextBox.Text);
            objEntidad.Codigo = CodigoTextBox.Text;
            objEntidad.Cuenta = CuentaTextBox.Text;
            objEntidad.Presentacion = vPresentacion;
            objEntidad.Afectable = vAfectable;
            objEntidad.GrupoAnterior = GrupoAnteriorTextBox.Text;
            objEntidad.Naturaleza = vNaturaleza;

            objNegocio.ActualizarPlanCuenta(objEntidad);
            Close();
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
        }

        private void GrupoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            vAfectable = false;
        }

        private void DetalleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            vAfectable = true;
        }
    }
}