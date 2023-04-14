using CapaDatos;
using CapaEntidades;
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
    }
}
