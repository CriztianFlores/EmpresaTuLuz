USE [master]
GO
/****** Object:  Database [EmpresaTuLuz2]    Script Date: 17/10/2022 23:49:50 ******/
/*CREATE DATABASE [EmpresaTuLuz2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmpresaTuLuz2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EmpresaTuLuz2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmpresaTuLuz2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EmpresaTuLuz2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EmpresaTuLuz2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmpresaTuLuz2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmpresaTuLuz2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EmpresaTuLuz2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmpresaTuLuz2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmpresaTuLuz2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EmpresaTuLuz2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmpresaTuLuz2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmpresaTuLuz2] SET  MULTI_USER 
GO
ALTER DATABASE [EmpresaTuLuz2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmpresaTuLuz2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmpresaTuLuz2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmpresaTuLuz2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmpresaTuLuz2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EmpresaTuLuz2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EmpresaTuLuz2] SET QUERY_STORE = OFF
GO*/
USE [EmpresaTuLuz2]
GO
/****** Object:  Table [dbo].[barrios]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[barrios](
	[barrio_id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[localidad_id] [int] NOT NULL,
 CONSTRAINT [barrio_id_pk] PRIMARY KEY CLUSTERED 
(
	[barrio_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[cliente_id] [int] IDENTITY(1,1) NOT NULL,
	[cliente_cuit] [varchar](50) NOT NULL,
	[cliente_nombre] [varchar](50) NOT NULL,
	[cliente_apellido] [varchar](50) NOT NULL,
	[cliente_activo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cliente_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cotizaciones]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cotizaciones](
	[numCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_vendedor] [int] NOT NULL,
	[estado] [int] NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[apellidoCliente] [varchar](50) NULL,
	[fecha] [datetime] NOT NULL,
	[observaciones] [varchar](200) NULL,
	[precioTotal] [float] NULL,
	[motivo_perdida] [varchar](100) NULL,
 CONSTRAINT [PK_cotizaciones] PRIMARY KEY CLUSTERED 
(
	[numCotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_cotizacion]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_cotizacion](
	[numCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[cod_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_detalle_cotizacion] PRIMARY KEY CLUSTERED 
(
	[numCotizacion] ASC,
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[empleado_id] [int] IDENTITY(1,1) NOT NULL,
	[empleado_num_doc] [int] NOT NULL,
	[empleado_tipo_doc] [int] NOT NULL,
	[empleado_nombre] [varchar](50) NOT NULL,
	[empleado_apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NULL,
	[barrio_id] [int] NOT NULL,
	[telefono] [varchar](50) NULL,
	[empleado_id_jefe] [int] NULL,
	[empleado_activo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estados_cotizaciones]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estados_cotizaciones](
	[id_estado] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_estados_cotizaciones] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[localidades](
	[localidad_id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[provincia_id] [int] NOT NULL,
 CONSTRAINT [localidad_id_pk] PRIMARY KEY CLUSTERED 
(
	[localidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[cantStock] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[proveedor_id] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [varchar](50) NOT NULL,
	[mail] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[proveedor_activo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[proveedor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provincias]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provincias](
	[provincia_id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [provincia_id_pk] PRIMARY KEY CLUSTERED 
(
	[provincia_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipos_doc]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipos_doc](
	[tipo_doc_id] [int] NOT NULL,
	[siglas] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [tipo_doc_id_pk] PRIMARY KEY CLUSTERED 
(
	[tipo_doc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 17/10/2022 23:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[usuario_nombre] [varchar](50) NOT NULL,
	[usuario_pass] [varchar](50) NOT NULL,
	[empleado_id] [int] NULL,
	[usuario_activo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (1, N'Barrio1', 1)
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (2, N'Barrio2', 1)
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (3, N'Barrio3', 1)
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (4, N'Barrio1', 2)
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (5, N'Barrio1', 3)
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (6, N'Barrio1', 4)
INSERT [dbo].[barrios] ([barrio_id], [nombre], [localidad_id]) VALUES (7, N'Barrio1', 5)
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (1, N'A2345678910', N'Rodrigo', N'Calmalha', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (2, N'B2345S78910', N'Pedro', N'Salinas', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (3, N'C2345W78910', N'Myrella', N'Moncada', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (4, N'DD23W5678910', N'Cindy', N'Jimenez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (5, N'E2345678910', N'Rodrigo', N'Grados', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (6, N'F2345678910', N'Raul', N'Rodriguez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (7, N'G2345678910', N'Jose', N'Lopez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (8, N'H2345678910', N'Miguel', N'Martinez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (9, N'I2345678910', N'Xiomara', N'Rodriguez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (10, N'J2345678910', N'Agustina', N'Lopez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (11, N'K2345678910', N'Lizet', N'Fernandez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (12, N'L2345678910', N'Maria', N'Fernandez', 0)
INSERT [dbo].[clientes] ([cliente_id], [cliente_cuit], [cliente_nombre], [cliente_apellido], [cliente_activo]) VALUES (13, N'M2345678910', N'Brigitte', N'Castillo', 0)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[cotizaciones] ON 

INSERT [dbo].[cotizaciones] ([numCotizacion], [id_cliente], [id_vendedor], [estado], [nombreCliente], [apellidoCliente], [fecha], [observaciones], [precioTotal], [motivo_perdida]) VALUES (1, 1, 1, 1, NULL, NULL, CAST(N'2022-10-17T00:00:00.000' AS DateTime), NULL, 2000, NULL)
INSERT [dbo].[cotizaciones] ([numCotizacion], [id_cliente], [id_vendedor], [estado], [nombreCliente], [apellidoCliente], [fecha], [observaciones], [precioTotal], [motivo_perdida]) VALUES (2, 2, 2, 3, NULL, NULL, CAST(N'2022-10-16T00:00:00.000' AS DateTime), NULL, 3500, NULL)
SET IDENTITY_INSERT [dbo].[cotizaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[empleados] ON 

INSERT [dbo].[empleados] ([empleado_id], [empleado_num_doc], [empleado_tipo_doc], [empleado_nombre], [empleado_apellido], [direccion], [barrio_id], [telefono], [empleado_id_jefe], [empleado_activo]) VALUES (1, 12123465, 1, N'Cristian', N'Flores', N'Tandil 1000', 1, N'351264879', NULL, 0)
INSERT [dbo].[empleados] ([empleado_id], [empleado_num_doc], [empleado_tipo_doc], [empleado_nombre], [empleado_apellido], [direccion], [barrio_id], [telefono], [empleado_id_jefe], [empleado_activo]) VALUES (2, 15646523, 2, N'Tom', N'Lopez', N'Ituzaingo 2000', 1, N'351123812', 1, 0)
INSERT [dbo].[empleados] ([empleado_id], [empleado_num_doc], [empleado_tipo_doc], [empleado_nombre], [empleado_apellido], [direccion], [barrio_id], [telefono], [empleado_id_jefe], [empleado_activo]) VALUES (3, 16764543, 1, N'Raul', N'Jimenez', N'Velez 230', 2, N'3516534812', 1, 0)
SET IDENTITY_INSERT [dbo].[empleados] OFF
GO
INSERT [dbo].[estados_cotizaciones] ([id_estado], [descripcion]) VALUES (1, N'Borrador')
INSERT [dbo].[estados_cotizaciones] ([id_estado], [descripcion]) VALUES (2, N'Pendiente de Aprobacion')
INSERT [dbo].[estados_cotizaciones] ([id_estado], [descripcion]) VALUES (3, N'Aprobada')
INSERT [dbo].[estados_cotizaciones] ([id_estado], [descripcion]) VALUES (4, N'Perdida')
GO
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (1, N'Localidad1', 1)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (2, N'Localidad2', 1)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (3, N'Localidad3', 1)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (4, N'Localidad1', 2)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (5, N'Localidad1', 3)
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([id], [nombre], [precio], [cantStock], [id_proveedor], [descripcion]) VALUES (1, N'Linternas', 1200, 500, 1, NULL)
INSERT [dbo].[productos] ([id], [nombre], [precio], [cantStock], [id_proveedor], [descripcion]) VALUES (2, N'Tubos de Luz', 1602.35, 900, 2, NULL)
INSERT [dbo].[productos] ([id], [nombre], [precio], [cantStock], [id_proveedor], [descripcion]) VALUES (3, N'Pilas 1200mhA', 305.2, 200, 3, NULL)
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedores] ON 

INSERT [dbo].[proveedores] ([proveedor_id], [razon_social], [mail], [telefono], [proveedor_activo]) VALUES (1, N'Luminarias S.A.', N'ventas@luminariasac.com', N'3514688795', 0)
INSERT [dbo].[proveedores] ([proveedor_id], [razon_social], [mail], [telefono], [proveedor_activo]) VALUES (2, N'Foco S.A.', N'ventas@focosac.com', N'3598688795', 0)
INSERT [dbo].[proveedores] ([proveedor_id], [razon_social], [mail], [telefono], [proveedor_activo]) VALUES (3, N'La Guardia S.R.L', N'guardia@guardia.com', N'3151110920', 1)
SET IDENTITY_INSERT [dbo].[proveedores] OFF
GO
INSERT [dbo].[provincias] ([provincia_id], [nombre]) VALUES (2, N'Buenos Aires')
INSERT [dbo].[provincias] ([provincia_id], [nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[provincias] ([provincia_id], [nombre]) VALUES (3, N'Salta')
GO
INSERT [dbo].[tipos_doc] ([tipo_doc_id], [siglas], [nombre]) VALUES (1, N'DNI', N'Documento Nacional de Identidad')
INSERT [dbo].[tipos_doc] ([tipo_doc_id], [siglas], [nombre]) VALUES (2, N'PAS', N'Pasaporte')
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([usuario_id], [usuario_nombre], [usuario_pass], [empleado_id], [usuario_activo]) VALUES (1, N'admi', N'admi', 1, 0)
INSERT [dbo].[usuarios] ([usuario_id], [usuario_nombre], [usuario_pass], [empleado_id], [usuario_activo]) VALUES (2, N'user', N'user', 2, 0)
INSERT [dbo].[usuarios] ([usuario_id], [usuario_nombre], [usuario_pass], [empleado_id], [usuario_activo]) VALUES (3, N'martin', N'123', 1, 0)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__clientes__C9FFFA843EB1C22F]    Script Date: 17/10/2022 23:49:50 ******/
ALTER TABLE [dbo].[clientes] ADD UNIQUE NONCLUSTERED 
(
	[cliente_cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [provincia_nombre_id_uk]    Script Date: 17/10/2022 23:49:50 ******/
ALTER TABLE [dbo].[provincias] ADD  CONSTRAINT [provincia_nombre_id_uk] UNIQUE NONCLUSTERED 
(
	[nombre] ASC,
	[provincia_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__tipos_do__835B6947A53A4171]    Script Date: 17/10/2022 23:49:50 ******/
ALTER TABLE [dbo].[tipos_doc] ADD UNIQUE NONCLUSTERED 
(
	[tipo_doc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[barrios]  WITH CHECK ADD  CONSTRAINT [barrios_id_localidades_fk] FOREIGN KEY([localidad_id])
REFERENCES [dbo].[localidades] ([localidad_id])
GO
ALTER TABLE [dbo].[barrios] CHECK CONSTRAINT [barrios_id_localidades_fk]
GO
ALTER TABLE [dbo].[cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_cotizaciones_clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([cliente_id])
GO
ALTER TABLE [dbo].[cotizaciones] CHECK CONSTRAINT [FK_cotizaciones_clientes]
GO
ALTER TABLE [dbo].[cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_cotizaciones_empleados] FOREIGN KEY([id_vendedor])
REFERENCES [dbo].[empleados] ([empleado_id])
GO
ALTER TABLE [dbo].[cotizaciones] CHECK CONSTRAINT [FK_cotizaciones_empleados]
GO
ALTER TABLE [dbo].[cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_cotizaciones_estados_cotizaciones] FOREIGN KEY([estado])
REFERENCES [dbo].[estados_cotizaciones] ([id_estado])
GO
ALTER TABLE [dbo].[cotizaciones] CHECK CONSTRAINT [FK_cotizaciones_estados_cotizaciones]
GO
ALTER TABLE [dbo].[detalle_cotizacion]  WITH CHECK ADD  CONSTRAINT [FK_detalle_cotizacion_productos] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[productos] ([id])
GO
ALTER TABLE [dbo].[detalle_cotizacion] CHECK CONSTRAINT [FK_detalle_cotizacion_productos]
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [empleados_barrio_id_fk] FOREIGN KEY([barrio_id])
REFERENCES [dbo].[barrios] ([barrio_id])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [empleados_barrio_id_fk]
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD  CONSTRAINT [empleados_jefe_fk] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleados] ([empleado_id])
GO
ALTER TABLE [dbo].[empleados] CHECK CONSTRAINT [empleados_jefe_fk]
GO
ALTER TABLE [dbo].[localidades]  WITH CHECK ADD  CONSTRAINT [localidad_id_provincia_fk] FOREIGN KEY([provincia_id])
REFERENCES [dbo].[provincias] ([provincia_id])
GO
ALTER TABLE [dbo].[localidades] CHECK CONSTRAINT [localidad_id_provincia_fk]
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD  CONSTRAINT [FK_productos_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([proveedor_id])
GO
ALTER TABLE [dbo].[productos] CHECK CONSTRAINT [FK_productos_proveedores]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [usuarios_empleados_fk] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleados] ([empleado_id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [usuarios_empleados_fk]
GO
USE [master]
GO
ALTER DATABASE [EmpresaTuLuz2] SET  READ_WRITE 
GO
