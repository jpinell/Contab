using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Empresa : CD_Conexion
    {
        //SqlDataReader leer;
        readonly DataTable tabla = new DataTable();
        //readonly SqlCommand cmd = new SqlCommand();

        public DataTable MostrarDatos()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Empresa", Conectar());
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();
            return tabla;

            //cmd.Connection = Conectar();
            //cmd.CommandText = "SELECT * FROM Empresa";
            //leer = cmd.ExecuteReader();
            //tabla.Load(leer);
            //Desconectar();
            //return tabla;
        }

        public void Insertar(CE_Empresa emp)
        {
            SqlCommand cmd = new SqlCommand("InsertEmpresa", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", emp.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
            cmd.Parameters.AddWithValue("@Ruc", emp.Ruc);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void Actualizar(CE_Empresa emp)
        {
            SqlCommand cmd = new SqlCommand("UpdateEmpresa", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDEmpresa", emp.IDEmpresa);
            cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", emp.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
            cmd.Parameters.AddWithValue("@Ruc", emp.Ruc);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteEmpresa", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDEmpresa", id);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

    }
}
