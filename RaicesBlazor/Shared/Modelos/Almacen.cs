using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class Almacen
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public List<AlmacenItems>? AlmacenItemList { get; set; }
        public List<Recepcion>? RecepcionList { get; set; }
        public List<Vale>? ValeList { get; set; }
    }
}
