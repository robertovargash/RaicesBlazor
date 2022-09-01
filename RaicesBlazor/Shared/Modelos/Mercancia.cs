using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class Mercancia
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public Clasificacion Clasificacion { get; set; } = null!;
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Maximum 50 characters")]
        public string Codigo { get; set; } = null!;

        public string? Descripcion { get; set; }

        [StringLength(10, MinimumLength = 1, ErrorMessage = "Maximum 10 characters")]
        public string Um { get; set; } = null!;
    }
}
