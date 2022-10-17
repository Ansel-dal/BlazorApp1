using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre válido.")]
        [MaxLength(20, ErrorMessage = "Ha superado los carácteres máximos (20).")]
        public string? NombreEmpresa { get; set; }
        //pedrito capo
        public string? Cuit { get; set; }
        public string? Calle { get; set; }
        public string? Mail { get; set; }
        public string? Telefono { get; set; }
        public string? Cp { get; set; }
        public string? Cf { get; set; }
        public string? NombreContacto { get; set; }
        public string? Observaciones { get; set; }
    }
}
