using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TareaWeb.Pages
{
    public class RegistroCargoModel : PageModel
    {
        public string Nombre_de_Cargo { get; set; }   
        public string Tipo_de_Cargo { get; set; }
        public string SueldoFijo { get; set; }


        public void OnGet()
        {
        }
    }
}
