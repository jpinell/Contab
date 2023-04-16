using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Grupos : CD_Conexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarGrupos()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("MostrarGrupos", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();

            //DataRow fila = tabla.NewRow();
            //fila["Cuenta"] = "Seleccione un grupo";
            //tabla.Rows.InsertAt(fila, 0);
            return tabla;
        }
    }
}
