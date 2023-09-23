using System.ComponentModel.DataAnnotations;

namespace TareaWeb.Models
{
    public class Sueldo
    {
        [Required(ErrorMessage = "ID es necesario")]
        public int Id { get; set; }

        public int DescuentoIV { get; set; }

        public int Bono { get; set; }

        public int DescuentoSeguro { get; set; }

        [Required(ErrorMessage = "Empleado es necesario")]
        public int EmpleadoId { get; set; } // Relación con Empleado
    }
}
