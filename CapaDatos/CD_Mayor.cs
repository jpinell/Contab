using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Mayor : CD_Conexion
    {
        private DataTable tabla = new DataTable();


        public DataTable MostrarMayor()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("MostrarMayor", Conectar())
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
        public DataTable MostrarMayorBySubGrupo(int id)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("MostrarMayorBySubGrupo", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@SubGrupo", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            Desconectar();

            //DataRow fila = tabla.NewRow();
            //fila["Cuenta"] = "Seleccione un Subgrupo";
            //tabla.Rows.InsertAt(fila, 0);
            da.Dispose();
            return tabla;
        }

        public List<Mayor> ListarMayor(int id)
        {
            List<Mayor> lista = new List<Mayor>();

            try
            {
                string query = "SELECT IDMayor, SubGrupo, Codigo, Cuenta FROM Mayor WHERE Subgrupo = " + @id;
                SqlCommand cmd = new SqlCommand(query, Conectar())
                {
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@SubGrupo", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Mayor()
                    {
                        IDMayor = Convert.ToInt32(dr["IDMayor"]),
                        oSubGrupo = new Subgrupos()
                        {
                            IDSubgrupo = id 
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
                return new List<Mayor>();
            }

            return lista;
        }
    }
}
