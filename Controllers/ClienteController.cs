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
            new ClienteModel { IdCliente = 1, Nombre = "Juan", Apellido = "Pérez", Telefono ="61409659", Correo = "ABL@gmail.com",Direccion = " Perez zeledon, barrio la palma", Estado = true},
            new ClienteModel { IdCliente = 2, Nombre = "kristel", Apellido = "fernandez", Telefono ="12369547", Correo = "kfj@gmail.com",Direccion = " Perez zeledon, barrio cooperativa", Estado = true},
            new ClienteModel { IdCliente = 2, Nombre = "laura", Apellido = "jimenez", Telefono ="45256318", Correo = "peg@gmail.com",Direccion = " colombia, bogota", Estado = true},
        };
            return View(lstCliente);
        }
    }
}
