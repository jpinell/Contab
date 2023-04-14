using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class CE_Subgrupo
    {
        public int IDSubgrupo { get; set; }
        public int Grupo { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Cuenta { get; set; }
    }
}
