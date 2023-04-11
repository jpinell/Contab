using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Estructura : CD_Conexion
    {
        readonly DataTable tabla = new DataTable();

        public DataTable MostrarDatos()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Estructura ORDER BY IDNivel ASC", Conectar());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();
            return tabla;
        }
    }
}
