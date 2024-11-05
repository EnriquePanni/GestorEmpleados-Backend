﻿using System.ComponentModel.DataAnnotations;

namespace MiWebAPI.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public decimal Sueldo { get; set; }
        public string FechaContrato { get; set; }
    }
}
