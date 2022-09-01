using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class ValeItem
    {
        public int Id { get; set; }
        public Vale Vale { get; set; } = null!;
        public Mercancia Mercancia { get; set; } = null!;
        [Column(TypeName = "decimal(18,6)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal Precio { get; set; }
    }
}
