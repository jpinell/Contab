using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class Mayor
    {
        public int IDMayor { get; set; }
        public Subgrupos oSubGrupo { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Cuenta { get; set; }
    }
}
