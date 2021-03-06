USE [RenoExpressPruebas]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 4/05/2021 23:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[CompraID] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompra] [varchar](150) NULL,
	[DetalleCompra] [varchar](250) NULL,
	[FechaCompra] [datetime] NULL,
	[UsuarioID] [int] NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[CompraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[CompraDteID] [int] IDENTITY(1,1) NOT NULL,
	[CompraID] [int] NOT NULL,
	[ProdID] [int] NULL,
	[CantidadCompraDte] [int] NULL,
	[PrecioCompraDte] [numeric](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulo](
	[ModuloID] [int] IDENTITY(1,1) NOT NULL,
	[RolID] [int] NULL,
	[NombreModulo] [varchar](150) NULL,
	[DescripcionModulo] [varchar](250) NULL,
	[FechaCreacionModulo] [datetime] NULL,
 CONSTRAINT [PK_Modulo] PRIMARY KEY CLUSTERED 
(
	[ModuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProdID] [int] IDENTITY(1,1) NOT NULL,
	[NombreProd] [varchar](150) NULL,
	[MarcaProd] [varchar](150) NULL,
	[DescripcionProd] [varchar](255) NULL,
	[PrecioUnitarioProd] [decimal](18, 2) NULL,
	[CantidadExistenteProd] [int] NULL,
	[FechaUltimaEntradaProd] [datetime] NULL,
	[UsuarioID] [int] NULL,
 CONSTRAINT [PK_Table1] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [varchar](50) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](150) NULL,
	[RolID] [int] NULL,
	[FechaCreacionUsuario] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[VentaID] [int] IDENTITY(1,1) NOT NULL,
	[NombreVenta] [varchar](150) NULL,
	[DescripcionVenta] [varchar](250) NULL,
	[FechaVenta] [datetime] NULL,
	[UsuarioID] [int] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[VentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 4/05/2021 23:17:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[VentaDteID] [int] IDENTITY(1,1) NOT NULL,
	[VentaID] [int] NULL,
	[ProdID] [int] NULL,
	[CantidadVentaDte] [int] NULL,
	[PrecioVentaDte] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([CompraID], [NombreCompra], [DetalleCompra], [FechaCompra], [UsuarioID]) VALUES (1, N'Prueba 1', N'Prueba de Compra', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Compra] ([CompraID], [NombreCompra], [DetalleCompra], [FechaCompra], [UsuarioID]) VALUES (2, N'Prueba 1', N'Prueba de Compra', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Compra] ([CompraID], [NombreCompra], [DetalleCompra], [FechaCompra], [UsuarioID]) VALUES (3, N'Prueba 1', N'Prueba de Compra', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Compra] OFF
SET IDENTITY_INSERT [dbo].[CompraDetalle] ON 

INSERT [dbo].[CompraDetalle] ([CompraDteID], [CompraID], [ProdID], [CantidadCompraDte], [PrecioCompraDte]) VALUES (1, 1, 1, 2, CAST(100.00 AS Numeric(18, 2)))
INSERT [dbo].[CompraDetalle] ([CompraDteID], [CompraID], [ProdID], [CantidadCompraDte], [PrecioCompraDte]) VALUES (2, 1, 2, 3, CAST(150.00 AS Numeric(18, 2)))
INSERT [dbo].[CompraDetalle] ([CompraDteID], [CompraID], [ProdID], [CantidadCompraDte], [PrecioCompraDte]) VALUES (3, 2, 1, 2, CAST(100.00 AS Numeric(18, 2)))
INSERT [dbo].[CompraDetalle] ([CompraDteID], [CompraID], [ProdID], [CantidadCompraDte], [PrecioCompraDte]) VALUES (4, 2, 2, 3, CAST(150.00 AS Numeric(18, 2)))
INSERT [dbo].[CompraDetalle] ([CompraDteID], [CompraID], [ProdID], [CantidadCompraDte], [PrecioCompraDte]) VALUES (5, 3, 1, 2, CAST(100.00 AS Numeric(18, 2)))
INSERT [dbo].[CompraDetalle] ([CompraDteID], [CompraID], [ProdID], [CantidadCompraDte], [PrecioCompraDte]) VALUES (6, 3, 2, 3, CAST(150.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[CompraDetalle] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (1, N'HotWheels', N'Mattel', N'Carros de juguete de diferentes clases', CAST(15.00 AS Decimal(18, 2)), 86, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (2, N'Barbie', N'Mattel', N'Muñecas de juguete', CAST(100.00 AS Decimal(18, 2)), 109, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (3, N'MaxSteel', N'Mattel', N'Figura de acción', CAST(200.00 AS Decimal(18, 2)), 50, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (4, N'Play-Doh', N'Hasbro', N'Plasticina de juguete', CAST(200.00 AS Decimal(18, 2)), 200, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (5, N'Monopoly', N'Hasbro', N'Juego de mesa', CAST(150.00 AS Decimal(18, 2)), 45, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (6, N'Transformers', N'Hasbro', N'Figuras de Accion', CAST(150.00 AS Decimal(18, 2)), 42, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Producto] ([ProdID], [NombreProd], [MarcaProd], [DescripcionProd], [PrecioUnitarioProd], [CantidadExistenteProd], [FechaUltimaEntradaProd], [UsuarioID]) VALUES (7, N'Lego Minecraft', N'Lego', N'Juego de para armar', CAST(500.00 AS Decimal(18, 2)), 90, CAST(N'2021-05-04T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([RolID], [NombreRol]) VALUES (1, N'Rol de pruebas')
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([UsuarioID], [NombreUsuario], [RolID], [FechaCreacionUsuario]) VALUES (2, N'Usuario Pruebas', 1, CAST(N'2021-05-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([VentaID], [NombreVenta], [DescripcionVenta], [FechaVenta], [UsuarioID]) VALUES (1, N'Prueba de compra', N'Prueba de compra de producto', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Venta] ([VentaID], [NombreVenta], [DescripcionVenta], [FechaVenta], [UsuarioID]) VALUES (2, N'Prueba de compra', N'Prueba de compra de producto', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Venta] ([VentaID], [NombreVenta], [DescripcionVenta], [FechaVenta], [UsuarioID]) VALUES (3, N'Prueba de compra', N'Prueba de compra de producto', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Venta] ([VentaID], [NombreVenta], [DescripcionVenta], [FechaVenta], [UsuarioID]) VALUES (4, N'Prueba de compra', N'Prueba de compra de producto', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Venta] ([VentaID], [NombreVenta], [DescripcionVenta], [FechaVenta], [UsuarioID]) VALUES (5, N'Prueba de compra', N'Prueba de compra de producto', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Venta] ([VentaID], [NombreVenta], [DescripcionVenta], [FechaVenta], [UsuarioID]) VALUES (6, N'Prueba de compra', N'Prueba de compra de producto', CAST(N'2021-04-05T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Venta] OFF
SET IDENTITY_INSERT [dbo].[VentaDetalle] ON 

INSERT [dbo].[VentaDetalle] ([VentaDteID], [VentaID], [ProdID], [CantidadVentaDte], [PrecioVentaDte]) VALUES (1, 4, 1, 20, CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[VentaDetalle] ([VentaDteID], [VentaID], [ProdID], [CantidadVentaDte], [PrecioVentaDte]) VALUES (2, 5, 1, 20, CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[VentaDetalle] ([VentaDteID], [VentaID], [ProdID], [CantidadVentaDte], [PrecioVentaDte]) VALUES (3, 6, 1, 20, CAST(200.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[VentaDetalle] OFF
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Compra] FOREIGN KEY([CompraID])
REFERENCES [dbo].[Compra] ([CompraID])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Compra]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Producto] FOREIGN KEY([ProdID])
REFERENCES [dbo].[Producto] ([ProdID])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Producto]
GO
ALTER TABLE [dbo].[Modulo]  WITH CHECK ADD  CONSTRAINT [FK_Modulo_Rol] FOREIGN KEY([RolID])
REFERENCES [dbo].[Rol] ([RolID])
GO
ALTER TABLE [dbo].[Modulo] CHECK CONSTRAINT [FK_Modulo_Rol]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Usuario] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuario] ([UsuarioID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([RolID])
REFERENCES [dbo].[Rol] ([RolID])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Producto] FOREIGN KEY([ProdID])
REFERENCES [dbo].[Producto] ([ProdID])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Producto]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Venta] FOREIGN KEY([VentaID])
REFERENCES [dbo].[Venta] ([VentaID])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Venta]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetProductos]    Script Date: 4/05/2021 23:17:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetProductos]
(
	@productoEspecifico int = null
)
AS
BEGIN
	select * from producto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresaCompra]    Script Date: 4/05/2021 23:17:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IngresaCompra]
(
	@nombre varchar(150),
	@observaciones varchar(250),
	@fecha datetime,
	@usuarioID int
)
AS
BEGIN
	INSERT INTO Compra VALUES (@nombre, @observaciones, @fecha, @usuarioID)

	select SCOPE_IDENTITY() as id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresaCompraDte]    Script Date: 4/05/2021 23:17:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IngresaCompraDte]
(
	@CompraID int,
	@ProdID int,
	@CantidadCompraDte int,
	@PrecioCompraDte decimal(18,2)
)
AS
BEGIN
	INSERT INTO CompraDetalle VALUES (@CompraID, @ProdID, @CantidadCompraDte, @PrecioCompraDte)

	select SCOPE_IDENTITY() as id

	update Producto set CantidadExistenteProd = CantidadExistenteProd + @CantidadCompraDte where ProdID = @ProdID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresaVenta]    Script Date: 4/05/2021 23:17:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IngresaVenta]
(
	@nombre varchar(150),
	@observaciones varchar(250),
	@fecha datetime,
	@usuarioID int
)
AS
BEGIN
	INSERT INTO Venta VALUES (@nombre, @observaciones, @fecha, @usuarioID)

	select SCOPE_IDENTITY() as id
END
GO
/****** Object:  StoredProcedure [dbo].[SP_IngresaVentaDte]    Script Date: 4/05/2021 23:17:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IngresaVentaDte]
(
	@VentaID int,
	@ProdID int,
	@CantidadVentaDte int,
	@PrecioVentaDte decimal(18,2)
)
AS
BEGIN
	INSERT INTO VentaDetalle VALUES (@VentaID, @ProdID, @CantidadVentaDte, @PrecioVentaDte)

	select SCOPE_IDENTITY() as id

	update Producto set CantidadExistenteProd = CantidadExistenteProd - @CantidadVentaDte where ProdID = @ProdID
END
GO
