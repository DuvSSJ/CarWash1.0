using CarWash1._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWash1._0.Controllers
{
    public class VehiculoController : Controller
    {
        public IActionResult Index()
        {
            var lstVehiculo  = new List<VehiculoModel>
        {
                new VehiculoModel {IdVehiculo = 1, IdCliente = 1,IdMarca = 1, Anio = 2024, Placa ="BZC-851", Estado = true},
                new VehiculoModel {IdVehiculo = 2, IdCliente = 2,IdMarca = 2, Anio = 2025, Placa ="BZC-999", Estado = true},                
                new VehiculoModel { IdVehiculo = 3, IdCliente = 3, IdMarca = 3, Anio = 1994, Placa = "BZC-234", Estado = true },
            };   
            return View(lstVehiculo);
        }
    }
}
