﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesBlazor.Shared.Modelos
{
    public class Clasificacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Detalle { get; set; }
    }
}
