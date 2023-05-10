Create procedure SP_InsertarSer
@idSeccion int, @nombreSerie varchar(200)
as
begin
insert into series(id_seccion,nombre_serie)values (@idSeccion, @nombreSerie)
end
go

Create procedure SP_UpdateSer
@idSerie int, @idSeccion int, @nombreSerie varchar(200)
as	 
begin
UPDATE series set nombre_serie=@nombreSerie, id_seccion=@idSeccion WHERE id_serie=@idSerie
end 
go

Create procedure SP_ReadSer
as
begin
SELECT id_serie as ID, nombre_serie as Serie, nombre_seccion as Sección, id_secccion
 FROM series s 
 INNER JOIN secciones sc ON s.id_seccion = sc.id_secccion
end
go

Create procedure SP_ListSec
as
begin
SELECT id_secccion as ID, nombre_seccion as Seccion
 FROM secciones sc
end
go

