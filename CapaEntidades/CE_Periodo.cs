using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Periodo
    {
        public int IDPeriodo { get; set; }
        [Required]
        public string Periodo { get; set; }
        [Required]
        public DateTime FechaI { get; set; }
        [Required]
        public DateTime FechaF { get; set; }
        [Required]
        public bool Cierre { get; set; }
    }
}
