using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    class Pedido
    {
        public UInt32 Plato_Id { get; set; }
        public UInt32 Venta_Id { get; set; }
        public UInt16 Cantidad { get; set; }
    }
}
