﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entities
{
    public class Mesa
    {
        public UInt32 Id { get; set; }
        public UInt32 Sector { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return "Mesa " + Id;
        }
    }
}
