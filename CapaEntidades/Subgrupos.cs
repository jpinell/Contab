using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class Subgrupos
    {
        public int IDSubgrupo { get; set; }
        public Grupos oGrupo { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Cuenta { get; set; }
    }
}
