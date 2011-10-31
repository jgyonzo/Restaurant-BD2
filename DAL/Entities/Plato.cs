using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    class Plato
    {
        public UInt32 Id { get; set; }
        public string Descripcion { get; set; }
        public string Rubro { get; set; }
        public float Precio_Costo { get; set; }
        public float Precio_Venta { get; set; }
    }
}