using System;
using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class CE_Catalogo
    {
        public int IDCatalogo { get; set; }
        [Required]
        public int Nivel { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string NombreCuenta { get; set; }
        [Required]
        public int Clasificacion { get; set; }
        [Required]
        public bool Afectable { get; set; }
        [Required]
        public string GrupoAnterior { get; set; }
        [Required]
        public char Naturaleza { get; set; }
        [Required]
        public int Clase { get; set; }
        public Decimal Saldo { get; set; }

    }
}
