using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class CN_Empresa
    {
        private CD_Empresa empresa = new CD_Empresa();

        public DataTable MostrarDatos()
        {
            DataTable tabla = new DataTable();
            tabla = empresa.MostrarDatos();
            return tabla;
        }
    }
}
