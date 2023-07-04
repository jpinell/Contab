using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Helpers;
using System;
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
        readonly CN_Clases objClase = new CN_Clases();

        readonly CN_Catalogo objNegocio = new CN_Catalogo();
        readonly CE_Catalogo objEntidad = new CE_Catalogo();

        int vClasificacion;
        int vNivel;
        int vClase;
        char vNaturaleza;
        bool vAfectable;

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboClasificacion();
            CargarComboEstructura();
            CargarComboClases();
            CargarGrillaCatalogo();
            //ClasificacionComboBox.SelectedIndex = -1;
            //EstructuraComboBox.SelectedIndex = -1;
            //ClasesComboBox.SelectedIndex = -1;
        }

        private void CargarGrillaCatalogo()
        {
            CatalogoDataGridView.DataSource = objNegocio.MostrarDatos();
        }

        private void CargarComboClasificacion()
        {
            ClasificacionComboBox.DataSource = objCla.MostrarDatos();
            ClasificacionComboBox.DisplayMember = "Clasificacion";
            ClasificacionComboBox.ValueMember = "IDClasificacion";

        }
        private void CargarComboEstructura()
        {
            EstructuraComboBox.DataSource = objEst.MostrarDatos();
            EstructuraComboBox.DisplayMember = "Clasificacion";
            EstructuraComboBox.ValueMember = "IDNivel";
        }
        private void CargarComboClases()
        {
            ClasesComboBox.DataSource = objClase.MostrarDatos();
            ClasesComboBox.DisplayMember = "Clase";
            ClasesComboBox.ValueMember = "IDClase";
        }
        private void ClasificacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vClasificacion = ClasificacionComboBox.SelectedIndex + 1;
        }
        private void EstructuraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vNivel = EstructuraComboBox.SelectedIndex + 1;
            DigitosTextBox.Text = objEst.NumeroDigitos(vNivel).ToString();
            CodigoMax(vNivel);
        }

        private void ClasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vClase = ClasesComboBox.SelectedIndex + 1;
        }
        private void CodigoMax(int vNivel)
        {
            switch (vNivel)
            {
                case 1:
                    CodigoTextBox.MaxLength = (int)Digitos.grupo;
                    break;
                case 2:
                    CodigoTextBox.MaxLength = (int)Digitos.subgrupo;
                    break;
                case 3:
                    CodigoTextBox.MaxLength = (int)Digitos.mayor;
                    break;
                case 4:
                    CodigoTextBox.MaxLength = (int)Digitos.auxiliar;
                    break;
                case 5:
                    CodigoTextBox.MaxLength = (int)Digitos.cuenta;
                    break;
            }
        }

        private void NaturalezaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NaturalezaComboBox.Text == "DEUDORA")
            {
                vNaturaleza = 'D';
            }
            else vNaturaleza = 'A';
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //GUARDAMOS LOS DATOS EN LAS ENTIDADES
            objEntidad.Nivel = vNivel;
            objEntidad.Codigo = CodigoTextBox.Text;
            objEntidad.NombreCuenta = CuentaTextBox.Text;
            objEntidad.Clasificacion = vClasificacion;
            objEntidad.Afectable = vAfectable;
            objEntidad.GrupoAnterior = GrupoTextBox.Text;
            objEntidad.Naturaleza = vNaturaleza;
            objEntidad.Clase = vClase;
            objEntidad.Saldo = 0;

            bool valido = new ValidacionDatos(objEntidad).Validate();
            if (valido)
            {
                objNegocio.InsertarCatalogo(objEntidad);
                CargarGrillaCatalogo();
                MessageBox.Show("Registro guardado");
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

        private void CatalogoDataGridView_Click(object sender, EventArgs e)
        {
            if (CatalogoDataGridView.Rows.Count == 0 || CatalogoDataGridView.CurrentRow == null) return;
            vNivel = (int)CatalogoDataGridView.CurrentRow.Cells[1].Value + 1;
            GrupoTextBox.Text = (string)CatalogoDataGridView.CurrentRow.Cells[2].Value;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
