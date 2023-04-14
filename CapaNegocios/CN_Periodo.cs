using CapaDatos;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class CN_Periodo
    {
        CD_Periodo periodo = new CD_Periodo();
        public DataTable MostrarDatos()
        {
            return periodo.MostrarDatos();
        }

        public void InsertarPeriodo(CE_Periodo p)
        {
            periodo.Insertar(p);

        }
    }
}
