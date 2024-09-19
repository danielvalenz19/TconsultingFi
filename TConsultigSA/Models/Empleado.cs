﻿using System.ComponentModel.DataAnnotations;

namespace TConsultigSA.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El DPI es obligatorio")]
        public string DPI { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de contratación es obligatoria")]
        public DateTime FechaContratado { get; set; }

        [Required(ErrorMessage = "El puesto es obligatorio")]
        public int IdPuesto { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio")]
        public int IdDepartamento { get; set; }

        public int? IdUsuario { get; set; }
    }
}
