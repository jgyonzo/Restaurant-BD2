using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    class Venta
    {
        public UInt32 Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public float Importe_Total { get; set; }
        public UInt32 Mozo_Id { get; set; }
        public UInt32 Mesa_Id { get; set; }
    }
}
