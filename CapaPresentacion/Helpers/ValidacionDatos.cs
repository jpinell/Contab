using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CapaPresentacion.Helpers
{
    public class ValidacionDatos
    {
        private ValidationContext context;
        private List<ValidationResult> results;
        private bool valido;
        private string mensaje;

        public ValidacionDatos(object instance)
        {
            context = new ValidationContext(instance);
            results = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instance, context, results, true);
        }

        public bool Validate()
        {
            if (!valido)
            {
                foreach (ValidationResult result in results)
                {
                    mensaje += result.ErrorMessage + "\n";
                }
                MessageBox.Show(mensaje, "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return valido;
        }
    }
}
