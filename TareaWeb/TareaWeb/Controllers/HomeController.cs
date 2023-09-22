using Microsoft.AspNetCore.Mvc;
using TareaWeb.Pages;
namespace TareaWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "programacion web 3";
            return View();
        }
        public string Welcome()
        {
            return "Bienvenido al Registro de Empleado Exitoso";
        }
        public IActionResult OnPost(RegistroEmpleadoModel empleado)
        {
            if (ModelState.IsValid)
            {
                // Aquí puedes procesar los datos del empleado, por ejemplo, guardarlos en una base de datos.

                // Después de procesar los datos, puedes redirigir a una página de éxito o realizar alguna otra acción.
                return RedirectToAction("RegistroExitoso");
            }

            // Si el modelo no es válido, vuelve a mostrar el formulario con errores.
            return View(empleado);
        }
    }
}
