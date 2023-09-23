using System.ComponentModel.DataAnnotations;

namespace TareaWeb.Models
{
    public class Empleado
    {
        [Required(ErrorMessage = "ID es necesario")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es necesario")]
        [StringLength(50, ErrorMessage = "El nombre debe tener como máximo 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es necesario")]
        [StringLength(50, ErrorMessage = "El apellido debe tener como máximo 50 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento es necesario")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha válida.")]
        public DateTime FechaDeNacimiento { get; set; }

        [Required(ErrorMessage = "Dirección es necesario")]
        [StringLength(100, ErrorMessage = "La dirección debe tener como máximo 100 caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Fecha de contratación es necesario")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha válida.")]
        public DateTime FechaDeContratacion { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Seleccione un cargo válido.")]
        public int CargoId { get; set; } // Relación con Cargo
    }
}
