using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class CE_Empresa
    {
        public int IDEmpresa { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [MaxLength(100)]    
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(250)]
        [Display(Name ="Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Display(Name = "No. RUC")]
        public string Ruc { get; set; }
    }
}
