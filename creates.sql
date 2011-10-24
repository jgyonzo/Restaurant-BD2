create table mozos (id int unsigned auto_increment primary key,
					nombre varchar(50),
					dir varchar(100),
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
					desc varchar(150),
					rubro varchar(10),
					precio_costo float,
					precio_venta float); 

create table pedidos (plato_id int unsigned,
					venta_id int unsigned,
					cant smallint unsigned,
					FOREIGN KEY(plato_id)
						REFERENCES platos(id),
					FOREIGN KEY(venta_id)
						REFERENCES ventas(id)); 