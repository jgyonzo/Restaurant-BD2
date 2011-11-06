create table mozos (id int unsigned auto_increment primary key,
					nombre varchar(50),
					direccion varchar(100),
					dni BIGINT unsigned unique key,
					sector int unsigned); 
					
					
create table mesas (id int unsigned auto_increment primary key,
					sector int unsigned); 				

create table ventas (id int unsigned auto_increment primary key,
					fecha datetime,
					estado smallint unsigned,
					importe_total float,
					mozo_id int unsigned,
					mesa_id int unsigned,
					FOREIGN KEY(mozo_id)
						REFERENCES mozos(id),
					FOREIGN KEY(mesa_id)
						REFERENCES mesas(id)); 

create table platos (id int unsigned auto_increment primary key,
					descripcion varchar(150),
					rubro varchar(20),
					precio_costo float,
					precio_venta float); 

create table pedidos (plato_id int unsigned,
					venta_id int unsigned,
					cantidad smallint unsigned,
					FOREIGN KEY(plato_id)
						REFERENCES platos(id),
					FOREIGN KEY(venta_id)
						REFERENCES ventas(id));

create table promociones (id int unsigned auto_increment primary key,
					descripcion varchar(150),
					precio float); 						
						
create table ventas_promociones (promocion_id int unsigned,
					venta_id int unsigned,
					cantidad smallint unsigned,
					FOREIGN KEY(promocion_id)
						REFERENCES promociones(id),
					FOREIGN KEY(venta_id)
						REFERENCES ventas(id));

create table platos_promociones (promocion_id int unsigned,
					plato_id int unsigned,
					FOREIGN KEY(promocion_id)
						REFERENCES promociones(id),
					FOREIGN KEY(plato_id)
						REFERENCES platos(id)); 						


insert into mozos(nombre,direccion,dni,sector) values ('pepe1','dsf',34355957,1);
insert into mozos(nombre,direccion,dni,sector) values ('pepe2','asd',35355957,3);
commit;

insert into mesas(sector) values (1);
insert into mesas(sector) values (2);
insert into mesas(sector) values (3);
insert into mesas(sector) values (3);
insert into mesas(sector) values (3);


insert into platos(descripcion,precio_costo,precio_venta,rubro) values ('Milanesa de Ternera con Guarnicion',10.0,22.0,'Segundo Plato');
insert into platos(descripcion,precio_costo,precio_venta,rubro) values ('Sopa de Caracol',4.0,8.50,'Primer Plato');
insert into platos(descripcion,precio_costo,precio_venta,rubro) values ('Flan de Huevo',2.0,6.0,'Postre');

select * from platos;
select * from promociones;

insert into promociones(descripcion,precio) values ('Mila + Papas + Coca',30);
insert into promociones(descripcion,precio) values ('Mila + Papas + Cerveza',35);
insert into promociones(descripcion,precio) values ('Sopa + Flan + Cerveza',31);
insert into promociones(descripcion,precio) values ('Prueba',31);
insert into promociones(descripcion,precio) values ('Prueba2',31);

select LAST_INSERT_ID() as id;

insert into platos_promociones(plato_id,promocion_id) values (1,1);
insert into platos_promociones(plato_id,promocion_id) values (1,2);
insert into platos_promociones(plato_id,promocion_id) values (2,3);
insert into platos_promociones(plato_id,promocion_id) values (3,3);
