using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        CE_Empresa CE_Empresa  = new CE_Empresa();
        CN_Empresa CN_Empresa  = new CN_Empresa();
        int vIDEmpresa;

        private void Empresa_Load(object sender, EventArgs e)
        {
            ListarEmpresas();
            CN_Botones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            CN_Botones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            errorProvider1.Dispose(); //QUITAR EL ICONO DEL ERROR!!!
        }

        private void EmpresaDataGridView_Click(object sender, EventArgs e)
        {
            if (EmpresaDataGridView.Rows.Count == 0) return;
            vIDEmpresa = (int)EmpresaDataGridView.CurrentRow.Cells[0].Value;
            NombreTextBox.Text = EmpresaDataGridView.CurrentRow.Cells[1].Value.ToString();
            DireccionTextBox.Text = EmpresaDataGridView.CurrentRow.Cells[2].Value.ToString();
            TelefonoTextBox.Text = EmpresaDataGridView.CurrentRow.Cells[2].Value.ToString();
            RucTextBox.Text = EmpresaDataGridView.CurrentRow.Cells[2].Value.ToString();

            CN_Botones.HabilitarBotones(false, GuardarButton, ActualizarButton, EliminarButton);
        }

        #region CRUD
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            CE_Empresa.Nombre = NombreTextBox.Text;
            CE_Empresa.Direccion = DireccionTextBox.Text;
            CE_Empresa.Telefono = TelefonoTextBox.Text;
            CE_Empresa.Ruc = RucTextBox.Text;

            //GUARDAR EL REGISTRO
            //CN_Empresa.insertEmpresa(emp);

            ListarEmpresas();
            LimpiarCajas();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            CE_Empresa.IDEmpresa = vIDEmpresa;
            CE_Empresa.Nombre = NombreTextBox.Text;
            CE_Empresa.Direccion = DireccionTextBox.Text;
            CE_Empresa.Telefono = TelefonoTextBox.Text;
            CE_Empresa.Ruc = RucTextBox.Text;

            //ACTUALIZAR EL REGISTRO
            //CN_Empresa.UpdateEmpresa(emp);

            LimpiarCajas();
            CN_Botones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            ListarEmpresas();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Está seguro de borrar el registro actual?",
           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                LimpiarCajas();
                CN_Botones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
                return;
            }

            //CN_Empresa.DeleteEmpresa(vIDEmpresa);

            LimpiarCajas();
            CN_Botones.HabilitarBotones(true, GuardarButton, ActualizarButton, EliminarButton);
            ListarEmpresas();
        }

        #endregion 

        private void ListarEmpresas()
        {
            EmpresaDataGridView.DataSource = CN_Empresa.MostrarDatos();
            EmpresaDataGridView.Columns[0].Visible = false;
            EmpresaDataGridView.Columns[2].HeaderText = "Dirección";
            EmpresaDataGridView.Columns[3].HeaderText = "Teléfono";
            EmpresaDataGridView.Columns[4].HeaderText = "No. RUC";

        }

        private void LimpiarCajas()
        {
            NombreTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            RucTextBox.Text = string.Empty;
            NombreTextBox.Focus();
        }

        private bool ValidarCampos()
        {
            if (NombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese el Nombre de la Empresa");
                NombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (DireccionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DireccionTextBox, "Ingrese la dirección de la Empresa");
                DireccionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (TelefonoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(TelefonoTextBox, "Ingrese el teléfono de la Empresa");
                TelefonoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (RucTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(RucTextBox, "Ingrese el número de RUC de la Empresa");
                RucTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }
    }
}
