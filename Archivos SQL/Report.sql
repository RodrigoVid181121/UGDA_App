CREATE PROCEDURE Report
as
begin
SELECT sc.nombre_seccion as 'Sección', s.nombre_serie as 'Serie', ss.nombre_subserie as 'Subserie', d.codigo_documento as 'Código',
us.carnet as 'Usuario', u.nombre_unidad_productora as 'Unidad productora', bd.fecha
FROM documentos d
INNER JOIN usuarios us ON us.id_usuario = d.id_usuario
INNER JOIN subseries ss ON ss.id_subserie = d.id_subserie
INNER JOIN series s ON s.id_serie  = ss.id_serie
INNER JOIN secciones sc ON sc.id_secccion = s.id_seccion
INNER JOIN unidades_productoras u ON u.id_unidad_productora = d.id_unidad_productora
INNER JOIN bitacora_documentos bd ON bd.codigo_documento = d.codigo_documento
WHERE MONTH(bd.fecha) BETWEEN MONTH(bd.fecha) -1 AND MONTH(bd.fecha)
end