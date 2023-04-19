using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocios
{
    public class CN_PlanCuenta
    {
        CD_PlanCuenta plan = new CD_PlanCuenta();
        public List<PlanCuenta> ListarPlanCuenta()
        {
            return plan.ListarPlanCuenta();
        }

        public void InsertarPlanCuenta(PlanCuenta cta)
        {
            plan.InsertarPlanCuenta(cta);
        }
    }
}
