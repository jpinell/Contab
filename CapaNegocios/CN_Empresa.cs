using CapaDatos;
using CapaEntidades;
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

        public void InsertarEmpresa(CE_Empresa emp)
        {
            empresa.Insertar(emp);

        }

        public void ActualizarEmpresa(CE_Empresa emp)
        {
            empresa.Actualizar(emp);
        }

        public void EliminarEmpresa(int id)
        {
            empresa.Eliminar(id);
        }
    }
}
