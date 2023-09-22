using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TareaWeb.Pages
{
    public class RegistroEmpleadoModel : PageModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Puesto { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public string Direccion { get; set; }

        public string CorreoElectronico { get; set; }

        public decimal Salario { get; set; }

        public DateTime FechaDeContratacion { get; set; }


        public void OnGet()
        {
        }
    }
}
