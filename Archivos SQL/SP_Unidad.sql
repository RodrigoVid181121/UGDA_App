CREATE PROCEDURE SP_ListUn
AS
BEGIN
SELECT id_unidad_productora as ID, nombre_unidad_productora as Nombre
FROM unidades_productoras
END
GO