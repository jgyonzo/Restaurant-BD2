create table mozos (id int unsigned auto_increment primary key,
					nombre varchar(50),
					direccion varchar(100),
					dni BIGINT unsigned unique key,
					sector int unsigned); 
					
					
create table mesas (id int unsigned auto_increment primary key,
					sector int unsigned); 

select DISTINCT(sector) from mesas;					

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
					rubro varchar(10),
					precio_costo float,
					precio_venta float); 

create table pedidos (plato_id int unsigned,
					venta_id int unsigned,
					cantidad smallint unsigned,
					FOREIGN KEY(plato_id)
						REFERENCES platos(id),
					FOREIGN KEY(venta_id)
						REFERENCES ventas(id));

drop table promocion;

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