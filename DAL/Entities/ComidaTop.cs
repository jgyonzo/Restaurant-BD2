using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class ComidaTop
    {
        public UInt32 Plato_Id { get; set; }
        public UInt64 Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Rubro { get; set; }

    }
}
