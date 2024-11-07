using Microsoft.AspNetCore.Mvc;

namespace CarWash1._0.Controllers
{
    public class LoginController : Controller
    {

        private List<ClienteModel> lstLogin = new List<ClienteModel>
    {
        new ClienteModel { Nombre = "Juan", Apellido = "Pérez", Usuario = "juan123", Clave = "password1" },
        new ClienteModel { Nombre = "María", Apellido = "Gómez", Usuario = "maria456", Clave = "password2" },
        new ClienteModel { Nombre = "Carlos", Apellido = "Fernández", Usuario = "carlos789", Clave = "password3" }
    };
        public IActionResult Index()
        {
            

            return View();

        }
      

        [HttpPost]
        public IActionResult Login(string Usuario, string Clave)
        {
            // Busca en la lista un usuario que coincida con el ingresado
            var cliente = lstLogin.FirstOrDefault(c => c.Usuario == Usuario && c.Clave == Clave);

            if (cliente != null)
            {

             
                return RedirectToAction("Index", "Home");

            }
            else
            {
                // Si no se encontró, muestra un mensaje de error o vuelve a la vista de login
                ViewBag.Error = "Usuario o contraseña incorrectos.";
                return View("Index","Login");
            }
        }
    }
}
