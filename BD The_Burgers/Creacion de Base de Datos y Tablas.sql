--Creacion de Base de Datos
CREATE DATABASE THE_BURGERS

--Usamos la Base Creada
USE THE_BURGERS

--Creacion de tablas 
--Usuario
CREATE TABLE Usuario(
Id_Usuario		INT IDENTITY(1,1)Primary key,
Nombre Varchar(25) not null,
Apellido Varchar(25) not null,
DNI	int,
Correo	Varchar(50),
Usuario Varchar(50) not null,
Contraseña Varchar(20) not null)

insert into Usuario values('Daniela', 'Arriazu', 38140022, 'Daniela@correo.com','DanielaArriazu','Daniela94')

--Cliente
CREATE TABLE Cliente(
Id_Cliente		INT IDENTITY(1,1)Primary key,
Nombre Varchar(25) not null,
Apellido Varchar(25) not null,
Telefono	int not null,
Direccion	varchar(100) not null)

insert into Cliente values('Tatiana', 'Ainchil', 11234567, 'Las Heras 580 Lanus')


--Categoria
CREATE TABLE Categoria(
Id_Categoria		INT IDENTITY(1,1)Primary key,
Descripcion Varchar(25) not null);

insert into Categoria values('Medallon')
insert into Categoria values('Helado')


--Producto
CREATE TABLE Producto(
Id_Producto		INT IDENTITY(1,1)Primary key,
Nombre Varchar(25) not null,
Precio Float not null,
Id_Categoria int not null
constraint FK_Categoria foreign key (Id_Categoria)
references Categoria (Id_Categoria)
on update cascade
on delete cascade);

--Hamburgesa
CREATE TABLE Hamburgesa(
Id_Hamburgesa INT IDENTITY(1,1)Primary key,
Precio float);

--DetalleHamburgesa
create table DetalleHamburgesa(
Id_Producto int not null,
Id_Hamburgesa int not null
constraint FK_Id_Hamburgesa foreign key (Id_Hamburgesa)
references Hamburgesa (Id_Hamburgesa)
on update cascade
on delete cascade)

alter table DetalleHamburgesa
add constraint FK_Producto foreign key (Id_Producto)
references Producto (Id_Producto)
on update cascade
on delete cascade

--Pedido
CREATE TABLE Pedido(
Id_Pedido INT IDENTITY(1,1)Primary key,
Fecha date,
Precio float,
Id_Cliente int not null
constraint FK_Id_Cliente foreign key (Id_Cliente)
references Cliente (Id_Cliente));

--DetallePedidio
create table DetallePedido(
Cantidad int not null,
Sbu_Total float not null,
Id_Producto int not null,
Id_Hamburgesa int not null,
Id_Pedido int not null
constraint FK_Id_Pedido foreign key (Id_Pedido)
references Pedido (Id_Pedido)
on update cascade
on delete cascade)

alter table DetallePedido
add constraint FK_IdProducto foreign key (Id_Producto)
references Producto (Id_Producto)
on update cascade
on delete cascade

alter table DetallePedido
add constraint FK_IdHamburgesa foreign key (Id_Hamburgesa)
references Hamburgesa (Id_Hamburgesa)
on update cascade
on delete cascade
