using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TareaWeb.Pages
{
    public class RegistroSueldoModel : PageModel
    {   
        
        public int AñosAntiguedad { get; set; }
        public double DescuentoIV { get; set; }
        public double DescuentoSeguro { get; set; }
        public void OnGet()
        {
        }
    }
}
