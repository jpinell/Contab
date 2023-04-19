using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class PlanCuenta
    {
        public int IDPlan { get; set; }
        public int Nivel { get; set; }
        public string Codigo { get; set; }
        public string Cuenta { get; set; }
        public int Presentacion { get; set; }
        public bool Afectable { get; set; }
        public string GrupoAnterior { get; set; }
        public char Naturaleza { get; set; }
    }
}
