using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class TipoTProducto
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DefaultValue("")]
        public string? Tipo { get; set; }
    }
}
