create procedure SP_InsertarDoc

@descripcion varchar(250), @año nchar(4), @ubicacion varchar(25), @carnet nchar(6), @unidad varchar(250), @subs varchar(200)
as
DECLARE @Idsub int,  @Idunidad int, @Idus int
if EXISTS(SELECT id_usuario from usuarios where carnet = @carnet) 
	SET @Idus = (SELECT id_usuario from usuarios where carnet = @carnet)

if EXISTS (SELECT id_unidad_productora from unidades_productoras where nombre_unidad_productora = @unidad)
	SET @Idunidad = (SELECT id_unidad_productora from unidades_productoras where nombre_unidad_productora = @unidad)

if EXISTS (SELECT id_subserie from subseries where nombre_subserie = @subs)
	SET @Idsub = (SELECT id_subserie from subseries where nombre_subserie = @subs)


insert into documentos (id_subserie,id_unidad_productora,id_usuario, descripcion, anio, ubicacion)values (@Idsub, @Idunidad, @Idus, @descripcion, @año, @ubicacion)
go

create procedure SP_UpdateDoc

@codigodoc nchar(9), @descripcion varchar(250), @año nchar(4), @ubicacion varchar(25), @carnet nchar(6), @unidad varchar(250), @subs varchar(200)
as
DECLARE @Idsub int,  @Idunidad int, @Idus int, @Iddoc int
if EXISTS(SELECT id_usuario from usuarios where carnet = @carnet) 
	SET @Idus = (SELECT id_usuario from usuarios where carnet = @carnet)

if EXISTS (SELECT id_unidad_productora from unidades_productoras where nombre_unidad_productora = @unidad)
	SET @Idunidad = (SELECT id_unidad_productora from unidades_productoras where nombre_unidad_productora = @unidad)

if EXISTS (SELECT id_subserie from subseries where nombre_subserie = @subs)
	SET @Idsub = (SELECT id_subserie from subseries where nombre_subserie = @subs)

if EXISTS (SELECT id_documento from documentos where codigo_documento = @codigodoc)
	SET @Iddoc = (SELECT id_documento from documentos where codigo_documento = @codigodoc )
	 

update documentos set id_subserie=@Idsub,id_unidad_productora=@Idunidad,id_usuario=@Idus, descripcion=@descripcion, 
codigo_documento = CONCAT(RTRIM((select ss.codigo_subserie from subseries ss where ss.id_subserie = @Idsub)),id_documento),
anio=@año, ubicacion=@ubicacion  
WHERE id_documento=@Iddoc
go

create procedure SP_DeleteDoc
@codigodoc nchar(9), @carnet nchar(6)
as
DECLARE @Idus int, @Iddoc int
if EXISTS(SELECT id_usuario from usuarios where carnet = @carnet) 
	SET @Idus = (SELECT id_usuario from usuarios where carnet = @carnet)

if EXISTS (SELECT id_documento from documentos where codigo_documento = @codigodoc)
	SET @Iddoc = (SELECT id_documento from documentos where codigo_documento = @codigodoc )
	 

UPDATE documentos set id_usuario=@Idus,codigo_documento= @codigodoc WHERE id_documento=@Iddoc

DELETE from documentos WHERE id_documento=@Iddoc 
go


Create procedure SP_Docs_Index
as
begin
SELECT s.nombre_seccion as Sección, sr.nombre_serie as Serie,ss.nombre_subserie as Subserie,up.nombre_unidad_productora as 'Unidad productora',
 u.carnet as Usuario, codigo_documento as ID,descripcion as Descripción,anio as Año,ubicacion as Ubicación
 FROM documentos d INNER JOIN subseries ss ON d.id_subserie = ss.id_subserie
 Inner JOIN series sr ON ss.id_serie = sr.id_serie
 Inner JOIN secciones s ON sr.id_seccion = s.id_secccion
 INNER JOIN unidades_productoras up ON d.id_unidad_productora = up.id_unidad_productora
 INNER JOIN usuarios u ON d.id_usuario = u.id_usuario
end
