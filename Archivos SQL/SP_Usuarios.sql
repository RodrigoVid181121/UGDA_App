create procedure SP_InsertarUsu

@nombre varchar(50), @apellido varchar(50), @carnet nchar(6), @correo varchar(150), @contrasenia varchar(20)
as
insert into usuarios(apellido,nombre,carnet,correo,contrasenia)values (@apellido,@nombre,@carnet,@correo,@contrasenia)
go

create procedure SP_UpdateUsu

@nombre varchar(50), @apellido varchar(50), @carnet nchar(6), @correo varchar(150), @contrasenia varchar(20)
as
DECLARE @Idus int
if EXISTS(SELECT id_usuario from usuarios where carnet = @carnet) 
	SET @Idus = (SELECT id_usuario from usuarios where carnet = @carnet)
	 
UPDATE usuarios set nombre=@nombre, apellido=@apellido, carnet=@carnet, correo=@correo, contrasenia=@contrasenia
WHERE id_usuario=@Idus
go

create procedure SP_DeleteUsu

 @carnet nchar(6)
as
DECLARE @Idus int
if EXISTS(SELECT id_usuario from usuarios where carnet = @carnet) 
	SET @Idus = (SELECT id_usuario from usuarios where carnet = @carnet)

DELETE from usuarios WHERE id_usuario=@Idus
go


Create procedure SP_Usu_Index
as
begin
SELECT u.carnet as Carnet, u.nombre as Nombre, u.apellido as Apellido, u.correo as Correo, c.nombre_cargo as Cargo
 FROM usuarios u 
 Inner JOIN cargos c ON c.id_cargo = u.id_cargo
 end 
 go

Create procedure SP_Cargos_CB
as
begin
SELECT  c.nombre_cargo as Cargo
 FROM cargos c 
end
go

ALTER PROCEDURE SP_Login
@Contraseña varchar(50), @carnet nchar(6)
as
begin
SELECT c.id_cargo as Cargo, u.nombre as Nombre, u.apellido as Apellido
FROM usuarios u
INNER JOIN cargos c on c.id_cargo = u.id_cargo
WHERE u.carnet = @carnet AND u.contrasenia = @Contraseña
end
go


