using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BlazorApp1.Shared.Models
{
    public partial class OrdenCompra
    {
        public int Id { get; set; }
        public string? Estado { get; set; }
        public string? Identificador { get; set; }
        public string? Especificacion { get; set; }
        public string? Archivo { get; set; }
        public string? Control { get; set; }
    }
}
