using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class CE_Grupos
    {
        public int IDGrupo { get; set; }
        [Required]
        public string Cuenta { get; set; }
    }
}
