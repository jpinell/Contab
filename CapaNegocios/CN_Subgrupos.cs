using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class CN_Subgrupos
    {
        CD_Subgrupos subgrupos = new CD_Subgrupos();

        public DataTable MostrarSubgrupos()
        {
            return subgrupos.MostrarSubgrupos();
        }
        public DataTable MostrarSubgruposByGrupo(int id)
        {
            return subgrupos.MostrarSubgruposByGrupo(id);
        }
        public List<Subgrupos> ListarSubgrupos(int id)
        {
            return subgrupos.ListarSubgrupos(id);
        }
    }
}
