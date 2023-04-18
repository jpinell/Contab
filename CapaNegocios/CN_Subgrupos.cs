using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class CN_Subgrupos
    {
        CD_Subgrupos subgrupos = new CD_Subgrupos();
        public DataTable MostrarSubgrupos(int id)
        {
            return subgrupos.MostrarSubgrupos(id);
        }
        public List<Subgrupo> ListarSubgrupos(int id)
        {
            return subgrupos.ListarSubgrupos(id);
        }
    }
}
