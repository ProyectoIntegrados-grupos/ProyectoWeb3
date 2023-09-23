namespace TareaWeb.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaDeContratacion { get; set; }
        public int CargoId { get; set; } // Relación con Cargo
    }
}
