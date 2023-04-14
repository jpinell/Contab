using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Periodo : CD_Conexion
    {
        private readonly DataTable tabla = new DataTable();

        public DataTable MostrarDatos()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Periodo", Conectar())
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();
            return tabla;
        }

        public void Insertar(CE_Periodo p)
        {
            SqlCommand cmd = new SqlCommand("InsertPeriodo", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Periodo", p.Periodo);
            cmd.Parameters.AddWithValue("@FechaI", p.FechaI);
            cmd.Parameters.AddWithValue("@FechaF", p.FechaF);
            cmd.ExecuteNonQuery();
            Desconectar();

        }
    }
}
