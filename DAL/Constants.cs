using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Constants
    {
        public static string QueryConn = "host=localhost;user id=root;password=asd;database=bd2;";

        public static string SelectAllMozos = "select * from mozos";

        public static string SelectAllSectores = "select distinct(sector) from mesas";

        public static string UpdateMozo = "update mozos set nombre = @Nombre, direccion =  @Direccion, dni = @Dni, sector = @Sector where id = @Id";
    }
}
