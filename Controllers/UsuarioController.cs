using CarWash1._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWash1._0.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            var lstUsuario = new List<UsuarioModel>
        {
                new UsuarioModel { IdEmpleado= 1, Nombre = "Pedro", Apellido =" Perez",Correo = "pp@gmail.com", Telefono = " +506 61685472",Direccion = "Limon", FechaIngreso = new DateTime(2020,07,15), FechaSalida = new DateTime(2022,10,13), ObservacionRenuncia = "Me voy a otra empresa", Usuario = "pedro1012", Clave = "perez1506", Estado = false },
                new UsuarioModel { IdEmpleado= 1, Nombre = "Ronald", Apellido ="Rodriguez",Correo = "RR@gmail.com", Telefono = " +506 61684675",Direccion = "Cartago", FechaIngreso = new DateTime(2023,11,19), FechaSalida = new DateTime(2024,09,22), ObservacionRenuncia = "Salario Insuficiente", Usuario ="RR1119", Clave = "perez1506", Estado = false },
               new UsuarioModel { IdEmpleado= 1, Nombre = "Kristel", Apellido =" Fonseca",Correo = "kfj@gmail.com", Telefono = " +506 61686347",Direccion = "San jose", FechaIngreso = new DateTime(2009,01,02), FechaSalida = new DateTime(2024,10,12), ObservacionRenuncia = "Temas Personales", Usuario = "Kris6347", Clave = "jim0102", Estado = false },
        };
            return View(lstUsuario);
        }
    }
}
