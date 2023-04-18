using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class CN_Grupos
    {
        CD_Grupos grupos = new CD_Grupos();
        public DataTable MostrarGrupos()
        {
            return grupos.MostrarGrupos();
        }

        public List<Grupos> ListarGrupos()
        {
            return grupos.ListarGrupos();
        }

    }
}
