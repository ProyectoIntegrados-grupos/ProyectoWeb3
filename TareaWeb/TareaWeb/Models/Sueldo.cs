namespace TareaWeb.Models
{
    public class Sueldo
    {
        public int Id { get; set; }
        public int AñosAntiguedad { get; set; }
        public int DescuentoIV { get; set; }
        public int DescuentoSeguro { get; set; }
        public int EmpleadoId { get; set; } // Relación con Empleado
    }
}
