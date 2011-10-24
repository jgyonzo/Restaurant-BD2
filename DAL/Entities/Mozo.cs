using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class Mozo
    {
        public UInt32 Id { get; set; }
        public string Nombre { get; set; }
        public string Dir { get; set; }
        public UInt64 Dni { get; set; }
        public UInt32 Sector { get; set; }
    }
}
