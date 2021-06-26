Go
Use master
Go
---------------CREACION DE BASE DE DATOS---------------
Go
------------VALIDACION DE EXISTENCIA DE BASE DE DATOS EMPRESA------------------
If Exists(Select Top 1 1 From sysdatabases Where Name='BD_Empresa')
	Begin
		Drop DataBase BD_Empresa
	End
Go
Go
Create DataBase BD_Empresa
Go

Go
Use BD_Empresa
Go
------------------CREACION DE TABLAS------------------
Go
------------VALIDACION DE EXISTENCIA DE TABLA EMPLEADO------------------
If Exists(Select Top 1 1 From INFORMATION_SCHEMA.TABLES Where TABLE_SCHEMA='dbo' and TABLE_NAME='Tb_Producto')
	Begin
		Drop Table Tb_Producto
	End
Go
------------CREACION DE TABLA PRODUCTO------------------
Go
Create Table Tb_Producto
(
	Codi_Producto				Int Primary Key Identity,
	Descripcion_Producto		Varchar(100),
	Cantidad_Producto			Int,
	Precio_Producto				Decimal,
	Activo						Bit
)
Go

------------CREACION DE PROCEDIMIENTOS ALMACENADOS------------------
-------------Listar Todos los Productos----------------
Go
Create Procedure usp_Producto_Listar
as
	Select 
		Codi_Producto				,
		Descripcion_Producto		,
		Cantidad_Producto			,
		Precio_Producto				,
		Activo						
	From Tb_Producto
Go

-------------Filtrar los Productos----------------
Go
Create Procedure usp_Producto_Filtrar
@Descripcion_Producto		Varchar(100)
as
	Select 
		Codi_Producto				,
		Descripcion_Producto		,
		Cantidad_Producto			,
		Precio_Producto				,
		Activo						
	From Tb_Producto
	Where Descripcion_Producto like '%'+ @Descripcion_Producto +'%'
Go


------------Registrar el Producto------------------
Go
Create Procedure usp_Producto_Registrar
@Descripcion_Producto		Varchar(100),
@Cantidad_Producto			Int,
@Precio_Producto			Decimal,
@Activo						Bit
As
	
	Insert Into Tb_Producto
	(
		Descripcion_Producto		, 
		Cantidad_Producto			, 
		Precio_Producto				, 
		Activo						
	)
	Values
	(
		@Descripcion_Producto		, 
		@Cantidad_Producto			, 
		@Precio_Producto			,  
		@Activo							
	)
Go

------------Modificar el Producto------------------
Go
Create Procedure usp_Producto_Modificar
@Codi_Producto				Int,
@Descripcion_Producto		Varchar(100),
@Cantidad_Producto			Int,
@Precio_Producto			Decimal,
@Activo						Bit
As
	
	Update Tb_Producto
	Set
		Descripcion_Producto		= @Descripcion_Producto		, 
		Cantidad_Producto			= @Cantidad_Producto		, 
		Precio_Producto				= @Precio_Producto			,
		Activo						= @Activo
	Where Codi_Producto = @Codi_Producto
Go

------------Eliminar el Producto------------------
Go
Create Procedure usp_Producto_Eliminar
@Codi_Producto				Int
As
	
	Delete From Tb_Producto
	Where Codi_Producto = @Codi_Producto
Go

-----------Insertar Datos-------------
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Computadora',100,1520,1);
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Lavadora',300,750,1);
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Cocina',35,960,1);
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Tablet',250,800,1);
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Impresora',85,450,1);
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Microondas',78,500,1);
Insert Into Tb_Producto(Descripcion_Producto, Cantidad_Producto	, Precio_Producto, Activo)
Values('Celular',49,560,1);

