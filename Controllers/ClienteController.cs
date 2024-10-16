using CarWash1._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWash1._0.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            var lstCliente = new List<ClienteModel>
        {
            new ClienteModel { Nombre = "Juan", Apellido = "Pérez" },
            new ClienteModel { Nombre = "María", Apellido = "Gómez" },
            new ClienteModel { Nombre = "Carlos", Apellido = "Fernández" }
        };
            return View(lstCliente);
        }
    }
}
