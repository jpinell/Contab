using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class CN_Estructura
    {
        private CD_Estructura estructura = new CD_Estructura();

        public DataTable MostrarDatos() => estructura.MostrarDatos();

        public int NumeroDigitos(int id) => estructura.Digitos(id);
    }
}
