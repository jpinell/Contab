using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocios
{
    public class CN_Catalogo
    {
        private CD_Catalogo catalogo = new CD_Catalogo();

        public DataTable MostrarDatos() => catalogo.MostrarDatos();

        public void InsertarCatalogo(CE_Catalogo cat)
        {
            catalogo.Insertar(cat);
        }

        public void ActualizarCatalogo(CE_Catalogo cat)
        {
            catalogo.Actualizar(cat);
        }

        public void EliminarCatalogo(int id)
        {
            catalogo.Eliminar(id);
        }
    }
}
