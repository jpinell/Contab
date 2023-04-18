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

        public DataTable MostrarSubgrupos(int id)
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

        public List<Subgrupo> ListarSubgrupos(int id)
        {
            List<Subgrupo> lista = new List<Subgrupo>();

            try
            {
                string query = "SELECT IDSubgrupo, Grupo, Codigo, Cuenta FROM Subgrupos WHERE Grupo = " + @id;
                SqlCommand cmd = new SqlCommand(query, Conectar());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Grupo", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Subgrupo()
                    {
                        IDSubgrupo = Convert.ToInt32(dr["IDSubgrupo"]),
                        oGrupo = new Grupos()
                        {
                            IDGrupo = id //Convert.ToInt32(dr["Grupo"]) 
                        },
                        Codigo = dr["Codigo"].ToString(),
                        Cuenta = dr["Cuenta"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                return new List<Subgrupo>();
            }

            return lista;
        }
    }
}
