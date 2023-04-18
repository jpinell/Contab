using System;
using System.ComponentModel.DataAnnotations;

namespace CapaEntidades
{
    public class Grupos
    {
        public int IDGrupo { get; set; }
        [Required]
        public string Cuenta { get; set; }

    }
}
