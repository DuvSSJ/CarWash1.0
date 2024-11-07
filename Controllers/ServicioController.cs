using CarWash1._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWash1._0.Controllers
{
    public class ServicioController : Controller
    {
        public IActionResult Index()
        {
            var lstServicio = new List<ServicioModel>
        {
                new ServicioModel {IdServicio = 1, Servicio =" lavado",Descripcion ="Lavado exterior y secado", Precio = 2500},
                new ServicioModel {IdServicio = 2, Servicio ="Aspirado",Descripcion ="Aspirado interior", Precio = 2000},
                new ServicioModel {IdServicio = 3, Servicio ="Pulido faros",Descripcion ="Pulido de faros con cera", Precio = 10000},
        };
            return View(lstServicio);
        }
    }
}
