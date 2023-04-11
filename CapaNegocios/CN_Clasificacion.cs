using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Clasificacion
    {
        private CD_Clasificacion clasificacion = new CD_Clasificacion();

        public DataTable MostrarDatos() => clasificacion.MostrarDatos();
    }
}
