using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class CE_Clases
    {
        public int IDClases { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(8)]
        public string Clase { get; set; }
    }
}
