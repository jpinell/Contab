using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Catalogo : CD_Conexion
    {
        readonly DataTable tabla = new DataTable();

        public DataTable MostrarDatos()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("spMostrarCatalogo", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();
            return tabla;
        }

        public void Insertar(CE_Catalogo cat)
        {
            SqlCommand cmd = new SqlCommand("spInsertCatalogo", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Nivel", cat.Nivel);
            cmd.Parameters.AddWithValue("@Codigo", cat.Codigo);
            cmd.Parameters.AddWithValue("@NombreCuenta", cat.NombreCuenta);
            cmd.Parameters.AddWithValue("@Clasificacion", cat.Clasificacion);
            cmd.Parameters.AddWithValue("@Afectable", cat.Afectable);
            cmd.Parameters.AddWithValue("@GrupoAnterior", cat.GrupoAnterior);
            cmd.Parameters.AddWithValue("@Naturaleza", cat.Naturaleza);
            cmd.Parameters.AddWithValue("@Clase", cat.Clase);
            cmd.Parameters.AddWithValue("@Saldo", 0);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void Actualizar(CE_Catalogo cat)
        {
            SqlCommand cmd = new SqlCommand("spUpdateCatalogo", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@IDCatalogo", cat.IDCatalogo);
            cmd.Parameters.AddWithValue("@Nivel", cat.Nivel);
            cmd.Parameters.AddWithValue("@Codigo", cat.Codigo);
            cmd.Parameters.AddWithValue("@NombreCuenta", cat.NombreCuenta);
            cmd.Parameters.AddWithValue("@Clasificacion", cat.Clasificacion);
            cmd.Parameters.AddWithValue("@Afectable", cat.Afectable);
            cmd.Parameters.AddWithValue("@GrupoAnterior", cat.GrupoAnterior);
            cmd.Parameters.AddWithValue("@Naturaleza", cat.Naturaleza);
            cmd.Parameters.AddWithValue("@Clase", cat.Clase);
            cmd.Parameters.AddWithValue("@Saldo", 0);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("spDeleteCatalogo", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@IDCatalogo", id);
            cmd.ExecuteNonQuery();
            Desconectar();
        }
    }
}
