--Creacion de Store Procedure
use THE_BURGERS

--sp_Alta_Categoria
CREATE PROCEDURE sp_Alta_Categoria
@descripcion varchar(25)
as
begin
	insert into Categoria(Descripcion)
	values(@descripcion)
end

--sp_Alta_Cliente
CREATE PROCEDURE sp_Alta_Cliente
@nombre varchar(25),
@apellido varchar(25),
@tel int,
@direccion varchar(50)
as
begin
	insert into Cliente(Nombre,Apellido,Telefono,Direccion)
	values(@nombre,@apellido,@tel,@direccion)
end

--sp_Alta_Hamburgesa
CREATE PROCEDURE sp_Alta_Hamburgesa
@id_Hamburgesa int= null output,
@precio float
as
insert into Hamburgesa
	values(@precio)
	set @id_Hamburgesa =@@IDENTITY

--sp_Alta_Pedido
CREATE PROCEDURE sp_Alta_Pedido
@id_pedido int= null output,
@fecha date,
@totalP float,
@id_cliente int
as
	insert into Pedido
	values(@fecha,@totalP,@id_cliente)
	set @id_pedido =@@IDENTITY

--sp_Alta_PedidoDetalle
CREATE PROCEDURE sp_Alta_PedidoDetalle
@cantidad int,
@subtotoal float,
@id_producto int,
@id_hamburgesa int,
@id_pedido int
as
begin
	insert into DetallePedido(Cantidad,Sub_Total,Id_Producto,Id_Hamburgesa,Id_Pedido)
	values(@cantidad,@subtotoal,@id_producto,@id_hamburgesa,@id_pedido)
end

--sp_Alta_Producto
CREATE PROCEDURE sp_Alta_Producto
@nombre varchar(25),
@precio float,
@idCategoria int
as
begin
	insert into Producto(Nombre,Precio,Id_Categoria)
	values(@nombre,@precio,@idCategoria)
end

--sp_Alta_Usuario 
CREATE PROCEDURE sp_Alta_Usuario
@nombre varchar(25),
@apellido varchar(25),
@dni int,
@correo varchar(50),
@usuario varchar(50),
@contraseña varchar(20)
as
begin
	insert into Usuario(Nombre,Apellido,DNI,Correo, Usuario,Contraseña)
	values(@nombre,@apellido,@dni,@correo,@usuario,@contraseña)
end

--[sp_Crear_HamburgesaDetalle]
CREATE PROCEDURE sp_Crear_HamburgesaDetalle(
@idProducto int,
@idHamburgesa int)
as
begin
	insert into DetalleHamburgesa(Id_Producto,Id_Hamburgesa)
	values(@idProducto,@idHamburgesa)
end

--sp_Eliminar_Categoria
CREATE PROCEDURE sp_Eliminar_Categoria
@idCategoria int
as
begin
	delete Categoria where Id_Categoria=@idCategoria
	end

--sp_Eliminar_Cliente
CREATE PROCEDURE sp_Eliminar_Cliente
@idCliente int
as
begin
	delete Cliente where Id_Cliente=@idCliente
end

--sp_Eliminar_Usuario
CREATE PROCEDURE sp_Eliminar_Usuario
@idUsuario int
as
begin
	delete Usuario where Id_Usuario=@idUsuario
end

--sp_Eliminar_Hamburgesa
CREATE PROCEDURE sp_Eliminar_Hamburgesa
@idHamburgesa int
as
begin
	delete Hamburgesa where Id_Hamburgesa=@idHamburgesa
	end

--sp_Eliminar_Pedido
	CREATE PROCEDURE sp_Eliminar_Pedido
@idPedido int
as
begin
	delete Pedido where Id_Pedido=@idPedido
	end

--sp_Eliminar_Producto
CREATE	PROCEDURE sp_Eliminar_Producto
@idProducto int
as
begin
	delete Producto where Id_Producto=@idProducto
	end

--sp_Listar_Categoria
CREATE PROCEDURE sp_Listar_Categoria
as
begin
	select * from Categoria
end

--sp_Listar_Cliente
CREATE PROCEDURE sp_Listar_Cliente
as
begin
	select * from Cliente
end

--sp_Listar_Hamburgesa
CREATE PROCEDURE sp_Listar_Hamburgesa
as
SELECT        dbo.Hamburgesa.Id_Hamburgesa, dbo.Hamburgesa.Precio as PrecioHamburgesa, dbo.DetalleHamburgesa.Id_Producto, dbo.Producto.Nombre, dbo.Producto.Precio AS PrecioProducto
FROM            dbo.DetalleHamburgesa INNER JOIN
                         dbo.Hamburgesa ON dbo.DetalleHamburgesa.Id_Hamburgesa = dbo.Hamburgesa.Id_Hamburgesa INNER JOIN
                         dbo.Producto ON dbo.DetalleHamburgesa.Id_Producto = dbo.Producto.Id_Producto

--sp_Listar_Pedido
create procedure sp_Listar_Pedido
as
select Pedido.Id_Pedido, Pedido.Fecha,Pedido.Precio, Cliente.Nombre,Cliente.Direccion
from Pedido inner join Cliente on Pedido.Id_Cliente= Cliente.Id_Cliente

--[sp_ListarProducto]
create PROCEDURE sp_ListarProducto
@categoria int
as
begin
SELECT        dbo.Categoria.Descripcion as Categoria, dbo.Producto.Nombre AS Producto, dbo.Producto.Precio, dbo.Producto.Id_Producto
FROM            dbo.Categoria INNER JOIN
                         dbo.Producto ON dbo.Categoria.Id_Categoria = dbo.Producto.Id_Categoria
WHERE        (dbo.Categoria.Descripcion = @categoria)
end

--sp_ListaTodosProducto
create PROCEDURE sp_ListaTodosProducto as
begin
SELECT        dbo.Categoria.Descripcion as Categoria, dbo.Producto.Nombre AS Producto, dbo.Producto.Precio, dbo.Producto.Id_Producto
FROM            dbo.Categoria INNER JOIN
                         dbo.Producto ON dbo.Categoria.Id_Categoria = dbo.Producto.Id_Categoria
						 end

--sp_LOGEO
create PROCEDURE sp_LOGEO(
	@User nvarchar(50),
	@Contra nvarchar(50)
)
as 
begin 
	select COUNT(*) from Usuario
		where Usuario=@User and Contraseña=@Contra
end

--sp_Modificar_Categoria
create PROCEDURE sp_Modificar_Categoria
@idCategoria int,
@descripcion varchar(25)
as
begin
	update Categoria set Descripcion=@descripcion
	where Id_Categoria=@idCategoria
end

--sp_Modificar_Cliente
create PROCEDURE sp_Modificar_Cliente
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@tel int,
@direccion varchar(100)
as
begin
	update Cliente set Nombre=@nombre,Apellido=@apellido,Telefono=@tel,Direccion=@direccion
	where Id_Cliente=@idCliente
end

--sp_Modificar_ContraseñaUsuario
create PROCEDURE sp_Modificar_ContraseñaUsuario
@idUsuario int,
@contraseña varchar(25)
as
begin
	update Usuario set Contraseña=@contraseña
	where Id_Usuario=@idUsuario
end

--sp_Modificar_Producto
CREATE PROCEDURE sp_Modificar_Producto
@idProducto int,
@nombre varchar(25),
@precio float,
@idCategoria int
as
begin
	update Producto set Nombre=@nombre,Precio=@precio,Id_Categoria=@idCategoria
	where Id_Producto=@idProducto
end

--[sp_Seleccionar_Categoria]
CREATE PROCEDURE sp_Seleccionar_Categoria
@idCategoria int
as
begin
	select * from Categoria
	where Id_Categoria=@idCategoria
end

--sp_Seleccionar_Cliente
CREATE PROCEDURE sp_Seleccionar_Cliente
@idCliente int
as
begin
	select * from Cliente
	where Id_Cliente=@idCliente
end

--sp_Seleccionar_Hamburgesa
CREATE PROCEDURE sp_Seleccionar_Hamburgesa
@idHamburgesa int
as
begin
	select * from Hamburgesa
	where Id_Hamburgesa=@idHamburgesa
end

--[sp_Seleccionar_Producto]
CREATE PROCEDURE sp_Seleccionar_Producto
@idProducto int
as
begin
	select * from Producto
	where Id_Producto=@idProducto
end

