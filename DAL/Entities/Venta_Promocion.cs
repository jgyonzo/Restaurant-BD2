using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class Venta_Promocion
    {
        public UInt32 Promocion_Id { get; set; }
        public UInt32 Venta_Id { get; set; }
        public UInt16 Cantidad { get; set; }
    }
}
