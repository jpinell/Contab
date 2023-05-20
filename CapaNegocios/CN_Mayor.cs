using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public  class CN_Mayor
    {
        CD_Mayor mayor = new CD_Mayor();
        public DataTable MostrarMayor()
        {
            return mayor.MostrarMayor();
        }
        public DataTable MostrarMayorBySubGrupo(int id)
        {
            return mayor.MostrarMayorBySubGrupo(id);
        }

        public List<Mayor> ListarMayor(int id)
        {
            return mayor.ListarMayor(id);
        }
    }
}
