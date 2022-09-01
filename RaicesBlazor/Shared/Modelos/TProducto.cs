using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class TProducto
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public TipoTProducto TipoTProducto { get; set; } = null!;
        [Column(TypeName = "decimal(18,6)")]
        public decimal Preciomanoobra { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal ValorBruto { get; set; }
        [DefaultValue(true)]
        public bool Disponible { get; set; }
        [DefaultValue(true)]
        public bool DisponibleMP { get; set; }
    }
}
