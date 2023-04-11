using System;

namespace CapaEntidades
{
    public class CE_Catalogo
    {
        public int IDCatalogo { get; set; }
        public int Nivel { get; set; }
        public string Codigo { get; set; }
        public string NombreCuenta { get; set; }
        public int Clasificacion { get; set; }
        public bool Afectable { get; set; }
        public string GrupoAnterior { get; set; }
        public string Naturaleza { get; set; }
        public int Clase { get; set; }
        public Decimal Saldo { get; set; }

    }
}
