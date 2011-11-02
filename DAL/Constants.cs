using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Constants
    {
        public static string QueryConn = "host=localhost;user id=root;password=asd;database=bd2;";

        public static string SelectAllMozos = "select * from mozos order by nombre";

        public static string SelectAllSectores = "select distinct(sector) from mesas order by sector";

        public static string UpdateMozo = "update mozos set nombre = @Nombre, direccion =  @Direccion, dni = @Dni, sector = @Sector where id = @Id";

        public static string InsertMozo = "insert into mozos(nombre,direccion,dni,sector) values (@Nombre,@Direccion,@Dni,@Sector)";

        public static string DeleteMozo = "delete from mozos where id = @Id";

        //PLATOS
        public static string SelectAllPlatos = "select * from platos order by rubro,descripcion";

        public static string SelectOnePlato = "select * from platos where id = @Id";

        public static string UpdatePlato = "update platos set descripcion = @Descripcion, rubro =  @Rubro,precio_costo  = @Precio_Costo, precio_venta = @Precio_Venta where id = @Id";

        public static string InsertPlato = "insert into platos(descripcion,rubro,precio_costo,precio_venta) values (@Descripcion,@Rubro,@Precio_Costo,@Precio_Venta)";

        public static string DeletePlato = "delete from platos where id = @Id";

        //PROMOCIONES
        public static string SelectAllPromociones = "select * from promociones order by descripcion";

        public static string SelectPlatosByPromo = "select * from platos_promociones where promocion_id = @Id";

        public static string UpdatePromo = "update promociones set descripcion = @Descripcion,precio = @Precio where id = @Id";

        public static string InsertPlatoPromo = "insert into platos_promociones (plato_id,promocion_id) values (@Plato_Id,@Promocion_Id)";

        public static string InsertPromo = "insert into promociones(descripcion,precio) values (@Descripcion,@Precio)";

        public static string DeletePlatoPromo = "delete from platos_promociones where plato_id = @Plato_Id and promocion_id = @Promocion_Id";

        public static string DeletePlatosByPromo = "delete from platos_promociones where promocion_id = @Id";

        public static string DeletePromo = "delete from promociones where id = @Id";

        //Genericas
        public static string SelectLastId = "select LAST_INSERT_ID() as id";
    }
}
