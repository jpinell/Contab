using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Clases
    {
        private CD_Clases clases = new CD_Clases();

        public DataTable MostrarDatos() => clases.MostrarDatos();
    }
}
