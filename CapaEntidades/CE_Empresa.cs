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
        [MaxLength(9, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [RegularExpression(@"\d{4}-\d{4}", ErrorMessage = "El campo {0} se debe ingresar con el formato 9999-9999")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(16, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Display(Name = "No. RUC")]
        [RegularExpression(@"\d{3}-\d{6}-\d{4}[A-Za-z]", ErrorMessage = "El campo {0} se debe ingresar con el formato 999-999999-9999?")]
        public string Ruc { get; set; }
    }
}
