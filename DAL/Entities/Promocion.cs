using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class Promocion
    {
        public UInt32 Id { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Estado { get; set; }
    }
}
