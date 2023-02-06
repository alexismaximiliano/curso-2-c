--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: 
--Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).

select Titulo as NombreDisco ,FechaLanzamiento,E.Descripcion as Estilo from DISCOS ,ESTILOS E

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

insert into ESTILOS ( Descripcion) values ('Cumbia')
insert into ESTILOS (Descripcion) values ('Regueton')
select Descripcion as estilos from ESTILOS
select * from ESTILOS 
insert into TIPOSEDICION (Descripcion) values('casette')
select * from TIPOSEDICION

--3. Insertar al menos dos discos nuevos cargando correctamente su información.
select * from DISCOS
insert into DISCOS values ('Sube',2015-6-9,11,'https://is4-ssl.mzstatic.com/image/thumb/Music114/v4/7d/3c/8f/7d3c8fd9-28db-a459-aec7-a0600ffbb625/dj.cfiibhee.jpg/1200x1200bf-60.jpg',2,2)
insert into DISCOS values ('sonidero 2000',1999,10,'https://lastfm.freetls.fastly.net/i/u/770x0/6a30253ec17149d19342e4984c4bf39e.jpg#6a30253ec17149d19342e4984c4bf39e',7,4)

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. 
--No te olvides del Where.
update DISCOS set FechaLanzamiento ='9-6-2015' where id=5 
update DISCOS set CantidadCanciones=12 where id=6

--5. Borrar un disco a elección.
delete from DISCOS where id=4

--6. Traer todos los estilos que estén asociados a algún disco.
select Descripcion as Estilo from ESTILOS
select * from DISCOS
select Descripcion from ESTILOS where Id value(IdEstilo=2)

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).

select d.Titulo,d.CantidadCanciones,e.Descripcion as Estilo  from DISCOS D,ESTILOS E
	where d.IdEstilo =e.Id

