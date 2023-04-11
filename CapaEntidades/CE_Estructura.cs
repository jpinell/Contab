using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CapaEntidades
{
    public class CE_Estructura
    {
        public int IDNivel { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(10)]
        [Display(Name = "Clasificación")]
        public string Clasificacion { get; set; }
        public int Digitos { get; set; }
    }
}
