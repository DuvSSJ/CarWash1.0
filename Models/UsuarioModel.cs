namespace CarWash1._0.Models
{
    public class UsuarioModel
    {
        public int IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string Correo { get; set; }
        public string? Telefono { get; set;}
        public string ? Direccion  { get; set; }
        public DateTime FechaIngreso { get; set;}
        public DateTime FechaSalida { get; set;}
        public string? ObservacionRenuncia { get; set;}
        public string? Usuario { get; set;}
        public string? Clave { get; set;}
        public int? Estado { get; set;}
}
}
