using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TareaWeb.Pages;

namespace TareaWeb.Pages
{
    public class RegistroEmpleadoModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string Nombre { get; set; }
        [BindProperty]
        public string Apellido { get; set; }
        [BindProperty]
        public DateTime FechaDeNacimiento { get; set; }
        [BindProperty]
        public string Direccion { get; set; }
        [BindProperty]
        public string CorreoElectronico { get; set; }
        [BindProperty]
        public DateTime FechaDeContratacion { get; set; }


        public void OnGet()
        {

        }
    }
}
