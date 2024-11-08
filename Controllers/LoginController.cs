using CarWash1._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarWash1._0.Controllers
{
    public class LoginController : Controller
    {
        private List<LoginModel> lstLogin = new List<LoginModel>
        {
            new LoginModel { Usuario = "juan123", Clave = "password1", Estado = 1 },
            new LoginModel { Usuario = "maria456", Clave = "password2", Estado = 2 }, 
            new LoginModel { Usuario = "carlos789", Clave = "password3", Estado = 2 }  
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Usuario, string Clave)
        {
            
            var loginModel = lstLogin.FirstOrDefault(c => c.Usuario == Usuario && c.Clave == Clave);

            
            if (loginModel != null)
            {
                
                if (loginModel.Estado == 1)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                   
                    ViewBag.Error = "Tu cuenta está desactivada. Por favor, contacta al administrador al 61409659.";
                    return View("Index"); 
                }
            }
            else
            {
                
                ViewBag.Error = "Usuario o contraseña incorrectos.";
                return View("Index"); 
            }
        }
    }
}