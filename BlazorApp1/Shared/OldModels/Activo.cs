using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared.OldModels
{
    public partial class Activo
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Nombre { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
