using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //private SqlConnection Conexion = new SqlConnection("Data Source=37JPINELL\\SQLEXPRESS;Initial Catalog=dbContable;Integrated Security=True");
        private SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=dbContable;Integrated Security=True");

        public SqlConnection Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection Desconectar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
