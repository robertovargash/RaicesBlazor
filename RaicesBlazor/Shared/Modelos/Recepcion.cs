using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class Recepcion
    {
        public int Id { get; set; }
        public Almacen Almacen { get; set; } = null!;
        public int Numero { get; set; }
        public string Observaciones { get; set; } = null!;
        [Column(TypeName = "nvarchar(250)")]
        public string P_recibe { get; set; } = null!;
        [Column(TypeName = "nvarchar(250)")]
        public string P_entrega { get; set; } = null!; 
        [Column(TypeName = "nvarchar(250)")]
        public string P_autoriza { get; set; } = null!;
        [Column(TypeName = "nvarchar(50)")]
        public string Contrato { get; set; } = null!;
        [Column(TypeName = "nvarchar(50)")]
        public string Factura { get; set; } = null!; 
        [Column(TypeName = "nvarchar(50)")]
        public string? Conduce { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Sol_compra { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Manifiesto { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Partida { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Conocimiento { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Expedicion { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Casilla { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Bultos { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? T_bultos { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? Transportista { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string? T_ci { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? T_chapa { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Proveedor { get; set; } = null!;
        public DateTime Fecha { get; set; }
        [DefaultValue(true)]
        public bool Activo { get; set; }
    }
}
