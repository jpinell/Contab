using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class CE_Clasificacion
    {
        public int IDClasificacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(10)]
        [Display(Name = "Clasificación")]
        public string Clasificacion { get; set; }
    }
}
