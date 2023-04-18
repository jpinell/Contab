using CapaEntidades;
using System;
using System.Collections.Generic;
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
            da.Dispose();
            return tabla;
        }

        public List<Grupos> ListarGrupos()
        {
            List<Grupos> lista = new List<Grupos>();

            try
            {
                string query = "SELECT IDGrupo, Cuenta FROM Grupos ORDER BY IDGrupo ASC";
                SqlCommand cmd = new SqlCommand(query, Conectar());
                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Grupos()
                    {
                        IDGrupo = Convert.ToInt32(dr["IDGrupo"]),
                        Cuenta = dr["Cuenta"].ToString()
                    });
                }
                dr.Close();
                Desconectar();
            }
            catch (Exception)
            {
                return new List<Grupos>();
            }

            return lista;
        }
    }
}
