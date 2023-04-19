using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Subgrupos : CD_Conexion
    {
        private DataTable tabla = new DataTable();


        public DataTable MostrarSubgrupos()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("MostrarSubgrupos", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();

            //DataRow fila = tabla.NewRow();
            //fila["Cuenta"] = "Seleccione un Subgrupo";
            //tabla.Rows.InsertAt(fila, 0);
            da.Dispose();
            return tabla;
        }
        public DataTable MostrarSubgruposByGrupo(int id)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("MostrarSubgrupoByGrupo", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Grupo", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();

            //DataRow fila = tabla.NewRow();
            //fila["Cuenta"] = "Seleccione un Subgrupo";
            //tabla.Rows.InsertAt(fila, 0);
            da.Dispose();
            return tabla;
        }

        public List<Subgrupos> ListarSubgrupos(int id)
        {
            List<Subgrupos> lista = new List<Subgrupos>();

            try
            {
                string query = "SELECT IDSubgrupo, Grupo, Codigo, Cuenta FROM Subgrupos WHERE Grupo = " + @id;
                SqlCommand cmd = new SqlCommand(query, Conectar())
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@Grupo", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Subgrupos()
                    {
                        IDSubgrupo = Convert.ToInt32(dr["IDSubgrupo"]),
                        oGrupo = new Grupos()
                        {
                            IDGrupo = id
                        },
                        Codigo = dr["Codigo"].ToString(),
                        Cuenta = dr["Cuenta"].ToString()
                    });
                }
                dr.Close();
                Desconectar();
            }
            catch (Exception)
            {
                return new List<Subgrupos>();
            }

            return lista;
        }
    }
}
