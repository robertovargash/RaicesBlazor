using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class Vale
    {
        public int Id { get; set; }
        public Almacen Almacen { get; set; } = null!;
        public int Numero { get; set; }
        public string Observaciones { get; set; } = null!;
        [Column(TypeName = "nvarchar(250)")]
        public string? P_solicita { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? P_entrega { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? P_autoriza { get; set; }
        public DateTime Fecha { get; set; }
        [DefaultValue(true)]
        public bool Activo { get; set; }
        public int TipoVale { get; set; }
    }
}
