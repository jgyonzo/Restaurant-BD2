using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class ComidaTop
    {
        public UInt32 Plato_Id { get; set; }
        public Decimal Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Rubro { get; set; }

    }

    public class PromoTop
    {
        public UInt32 Promo_Id { get; set; }
        public Decimal Cantidad { get; set; }
        public string Descripcion { get; set; }
    }

    public class MozosTop
    {
        public UInt64 Dni { get; set; }
        public string Nombre { get; set; }
        public UInt32 Sector { get; set; }
        public Int64 Ventas_Realizadas { get; set; }
    }
}
