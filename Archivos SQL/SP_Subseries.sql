create procedure SP_InsertarSubs
@idSerie int, @nombreSubserie varchar(200), @codigoSubserie nchar(5)
as
begin
insert into subseries(id_serie,nombre_subserie,codigo_subserie)values (@idSerie, @nombreSubserie, @codigoSubserie)
end
go


create procedure SP_UpdateSubs
@idSerie int, @nombreSubserie varchar(200), @codigoSubserie nchar(5), @idSubserie int
as	 
begin
UPDATE subseries set id_serie=@idSerie, nombre_subserie=@nombreSubserie, codigo_subserie=@codigoSubserie WHERE id_subserie=@idSubserie
end 
go

Create procedure SP_ReadSubs
as
begin
SELECT id_subserie as ID, nombre_subserie as Subserie, codigo_subserie as Codigo, nombre_serie as Serie, ss.id_serie
 FROM subseries ss
 INNER JOIN series s ON ss.id_serie = s.id_serie ORDER BY id_subserie
end
go

alter procedure SP_ListSer
as
begin
SELECT id_serie as ID, nombre_serie as Serie
 FROM series s
end
go
