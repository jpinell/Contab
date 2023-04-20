using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_PlanCuenta : CD_Conexion
    {
        public List<PlanCuenta> ListarPlanCuenta()
        {
            List<PlanCuenta> lista = new List<PlanCuenta>();

            try
            {
                SqlCommand cmd = new SqlCommand("SelectPlanCuenta", Conectar())
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new PlanCuenta()
                    {
                        IDPlan = Convert.ToInt32(dr["IDPlan"]),
                        Nivel = Convert.ToInt32(dr["Nivel"]),
                        Codigo = dr["Codigo"].ToString(),
                        Cuenta = dr["Cuenta"].ToString(),
                        Presentacion = Convert.ToInt32(dr["Presentacion"]),
                        Afectable = Convert.ToBoolean(dr["Afectable"]),
                        GrupoAnterior = dr["GrupoAnterior"].ToString(),
                        Naturaleza = Convert.ToChar(dr["Naturaleza"])
                    });
                }
                dr.Close();
                Desconectar();
            }
            catch (Exception)

            {
                return new List<PlanCuenta>();
            }

            return lista;
        }

        public void InsertarPlanCuenta(PlanCuenta cta)
        {
            SqlCommand cmd = new SqlCommand("InsertPlanCuenta", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nivel", cta.Nivel);
            cmd.Parameters.AddWithValue("@Codigo", cta.Codigo);
            cmd.Parameters.AddWithValue("@Cuenta", cta.Cuenta);
            cmd.Parameters.AddWithValue("@Presentacion", cta.Presentacion);
            cmd.Parameters.AddWithValue("@Afectable", cta.Afectable);
            cmd.Parameters.AddWithValue("@GrupoAnterior", cta.GrupoAnterior);
            cmd.Parameters.AddWithValue("@Naturaleza", cta.Naturaleza);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Desconectar();
        }

        public void ActualizarPlanCuenta(PlanCuenta cta)
        {
            SqlCommand cmd = new SqlCommand("UpdatePlanCuenta", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IDPlan", cta.IDPlan);
            cmd.Parameters.AddWithValue("@Nivel", cta.Nivel);
            cmd.Parameters.AddWithValue("@Codigo", cta.Codigo);
            cmd.Parameters.AddWithValue("@Cuenta", cta.Cuenta);
            cmd.Parameters.AddWithValue("@Presentacion", cta.Presentacion);
            cmd.Parameters.AddWithValue("@Afectable", cta.Afectable);
            cmd.Parameters.AddWithValue("@GrupoAnterior", cta.GrupoAnterior);
            cmd.Parameters.AddWithValue("@Naturaleza", cta.Naturaleza);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Desconectar();
        }

        public void EliminarPlanCuenta(int id)
        {
            SqlCommand cmd = new SqlCommand("DeletePlanCuenta", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IDPlan", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            Desconectar();
        }
    }
}
