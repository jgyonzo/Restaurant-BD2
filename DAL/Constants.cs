using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Constants
    {
        public static string QueryConn = "host=localhost;user id=root;password=asd;database=bd2;";

        //MOZOS
        public static string SelectAllMozos = "select * from mozos where estado = 'ACTIVO' order by sector,nombre";
        public static string UpdateMozo = "update mozos set nombre = @Nombre, direccion =  @Direccion, dni = @Dni, sector = @Sector where id = @Id";
        public static string InsertMozo = "insert into mozos(nombre,direccion,dni,sector) values (@Nombre,@Direccion,@Dni,@Sector)";
        public static string DeleteMozo = "update mozos set estado = 'DESVINCULADO' where id = @Id";
        public static string SelectOneMozoByDni = "select * from mozos where dni = @Dni";
        public static string SearchMozosBySector = "select * from mozos where sector = @Sector order by nombre";

        //PLATOS
        public static string SelectAllPlatos = "select * from platos order by estado,rubro,descripcion";
        public static string SearchPlatosByEstado = "select * from platos where estado = @Estado order by rubro,descripcion";
        public static string SelectOnePlato = "select * from platos where id = @Id";
        public static string UpdatePlato = "update platos set descripcion = @Descripcion, rubro =  @Rubro,precio_costo  = @Precio_Costo, precio_venta = @Precio_Venta where id = @Id";
        public static string ActivatePlato = "update platos set estado = 'DISPONIBLE' where id = @Id";
        public static string InsertPlato = "insert into platos(descripcion,rubro,precio_costo,precio_venta) values (@Descripcion,@Rubro,@Precio_Costo,@Precio_Venta)";
        public static string DeletePlato = "update platos set estado = 'NO DISPONIBLE' where id = @Id";

        //PROMOCIONES
        public static string SelectAllPromociones = "select * from promociones order by estado,descripcion";
        public static string SelectPlatosByPromo = "select * from platos_promociones where promocion_id = @Id";
        public static string UpdatePromo = "update promociones set descripcion = @Descripcion,precio = @Precio where id = @Id";
        public static string ActivatePromo = "update promociones set estado = 'DISPONIBLE' where id = @Id";
        public static string InsertPlatoPromo = "insert into platos_promociones (plato_id,promocion_id) values (@Plato_Id,@Promocion_Id)";
        public static string InsertPromo = "insert into promociones(descripcion,precio) values (@Descripcion,@Precio)";
        public static string DeletePlatoPromo = "delete from platos_promociones where plato_id = @Plato_Id and promocion_id = @Promocion_Id";
        public static string DeletePlatosByPromo = "delete from platos_promociones where promocion_id = @Id";
        public static string DeletePromo = "update promociones set estado = 'NO DISPONIBLE' where id = @Id";
        public static string SelectPromocion = "select * from promociones where id = @Id";
        public static string SelectPromosByPlato = "select * from platos_promociones where plato_id = @Id";
        public static string SearchPromocionesByEstado = "select * from promociones where estado = @Estado order by descripcion";

        //Genericas
        public static string SelectLastId = "select LAST_INSERT_ID() as id";

        //MESAS
        public static string SelectAllMesas = "select * from mesas order by estado,sector,id";
        public static string SearchMesasByEstado = "select * from mesas where estado = @Estado order by sector,id";
        public static string SelectMesasDisponiblesBySector = "select * from mesas m where sector = @Sector and estado = 'EN SERVICIO' and not exists(select 1 from ventas v where v.mesa_id = m.id and estado = 'ABIERTA') order by sector,id";
        public static string SelectAllSectores = "select distinct(sector) from mesas order by sector";
        public static string InsertMesa = "insert into mesas(id,sector) values (@Id,@Sector)";
        public static string InactivateMesa = "update mesas set estado = 'FUERA DE SERVICIO' where id = @Id";
        public static string ActivateMesa = "update mesas set estado = 'EN SERVICIO' where id = @Id";

        //VENTAS
        public static string SelectVentasAbiertas = "select v.*, (select nombre from mozos m where m.id = v.mozo_id) nombre_mozo from ventas v where estado = 'ABIERTA' order by fecha";
        public static string InsertVenta = "insert into ventas(fecha,estado,mozo_id,mesa_id,importe_total) values (sysdate(),'ABIERTA', @Mozo_Id , @Mesa_Id , 0)";
        public static string CerrarVenta = "update ventas set estado = 'CERRADA' where id = @Id";
        public static string SelectPromosByVenta = "select * from ventas_promociones where venta_id = @Id";
        public static string SelectPlatosByVenta = "select * from pedidos where venta_id = @Id";
        public static string InsertPedido = "insert into pedidos (plato_id,venta_id,cantidad) values (@Plato_Id , @Venta_Id , 1)";
        public static string InsertVenta_Promo = "insert into ventas_promociones (promocion_id,venta_id,cantidad) values (@Promocion_Id , @Venta_Id , 1)";
        public static string AddPedido = "update pedidos set cantidad = cantidad + 1 where plato_id = @Plato_Id and venta_id = @Venta_Id";
        public static string AddPromo = "update ventas_promociones set cantidad = cantidad + 1 where promocion_id = @Promocion_Id and venta_id = @Venta_Id";
        public static string ExistPedido = "select * from pedidos where plato_id = @Plato_Id and venta_id = @Venta_Id ";
        public static string ExistPromo = "select * from ventas_promociones where promocion_id = @Promocion_Id and venta_id = @Venta_Id ";
        public static string UpdatePrice = "update ventas set importe_total = importe_total + @Precio where id = @Id";
        public static string DeletePedido = "delete from pedidos where plato_id = @Plato_Id and venta_id = @Venta_Id";
        public static string DeleteVenta_Promo = "delete from ventas_promociones where promocion_id = @Promocion_Id and venta_id = @Venta_Id";
        public static string SubsPedido = "update pedidos set cantidad = cantidad - 1 where plato_id = @Plato_Id and venta_id = @Venta_Id";
        public static string SubsPromo = "update ventas_promociones set cantidad = cantidad - 1 where promocion_id = @Promocion_Id and venta_id = @Venta_Id";
        public static string SelectOneVenta = "select * from ventas where id = @Id";
    }
}
