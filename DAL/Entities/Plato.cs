using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class Plato
    {
        public UInt32 Id { get; set; }
        public string Descripcion { get; set; }
        public string Rubro { get; set; }
        public float Precio_Costo { get; set; }
        public float Precio_Venta { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Plato other = obj as Plato;
            if (other != null)
                return Id == other.Id;
            else
                return false;
        }
    }
}