Create procedure SP_ReadBita
as
begin
SELECT 
CASE evento 
WHEN 'I' THEN 'Guardar' 
WHEN 'U' THEN 'Editar' 
WHEN 'D' THEN 'Eliminar' 
ELSE 'Desconocido' 
END as Evento, CASE tipo_reg 
WHEN 'NEW' THEN 'Nuevo' 
WHEN 'OLD' THEN 'Antiguo' ELSE 'Desconocido' 
END as Tipo, 
hostame as Computadora, 
CONVERT(varchar, FORMAT( fecha, 'dd/mm/yyyy hh:mm:ss')) as Fecha, 
ss.nombre_subserie as Subserie, 
up.nombre_unidad_productora as Unidad, 
u.carnet as Usuario, 
codigo_documento as ID, 
descripcion as Descripción, 
anio as Año, 
ubicacion as Ubicación 
FROM bitacora_documentos bd 
INNER JOIN subseries ss ON bd.id_subserie = ss.id_subserie 
INNER JOIN unidades_productoras up ON bd.id_unidad_productora = up.id_unidad_productora  
INNER JOIN usuarios u ON bd.id_usuario = u.id_usuario
end
go

Create procedure SP_DeleteBita
as
begin
DELETE FROM bitacora_documentos
end
go

