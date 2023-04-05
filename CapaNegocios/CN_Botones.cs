using FontAwesome.Sharp;

namespace CapaNegocios
{
    public class CN_Botones
    {
        public static void HabilitarBotones(bool activo, IconButton boton1, IconButton boton2, IconButton boton3)
        {
            //ACTIVA O DESACTIVA LOS BOTONES
            boton1.Enabled = activo;
            boton2.Enabled = !activo;
            boton3.Enabled = !activo;
        }
    }
}
