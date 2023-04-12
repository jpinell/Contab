using CapaEntidades;
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

        public int Digitos(int id)
        {
            
            SqlCommand cmd = new SqlCommand("ScalarDigitoByNivel", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDNivel", id);
            int digito = (int)cmd.ExecuteScalar();
            Desconectar();
            return digito;
        }

    }
}
