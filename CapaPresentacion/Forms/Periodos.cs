using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class Periodos : Form
    {
        public Periodos()
        {
            InitializeComponent();
        }

        CN_Periodo objNegocio = new CN_Periodo();
        CE_Periodo objEntidad = new CE_Periodo();

        private void Periodos_Load(object sender, EventArgs e)
        {
            CargarGrillaPeriodos();
        }

        private void CargarGrillaPeriodos()
        {
            PeriodoDataGridView.DataSource = objNegocio.MostrarDatos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Mapeamos los datos en las entidades
            objEntidad.Periodo = PeriodoTextBox.Text;
            objEntidad.FechaI = DTPFechaI.Value;
            objEntidad.FechaF = DTPFechaF.Value;

            bool valido = new Helpers.ValidacionDatos(objEntidad).Validate();
            if (valido)
            {
                objNegocio.InsertarPeriodo(objEntidad);
                CargarGrillaPeriodos();
                MessageBox.Show("Registro guardado");
            }
        }
    }
}
