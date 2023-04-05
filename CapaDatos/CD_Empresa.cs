using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Empresa
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarDatos()
        {
            cmd.Connection = conexion.Conectar();
            cmd.CommandText = "SELECT * FROM Empresa";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.Desconectar();
            return tabla;
        }
    }
}
