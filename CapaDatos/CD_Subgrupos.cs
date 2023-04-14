using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Subgrupos : CD_Conexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarSubgrupos(int id)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("MostrarSubgrupoByGrupo", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Grupo", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();

            DataRow fila = tabla.NewRow();
            fila["Cuenta"] = "Seleccione un Subgrupo";
            tabla.Rows.InsertAt(fila, 0);
            return tabla;
        }
    }
}
