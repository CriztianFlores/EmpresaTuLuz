/*
BASE DE DATOS:  
TRABAJO PRACTICO PAV1 - UTN-FRC
GRUPO 6
EMPRESA TU LUZ
*/
--CREATE DATABASE tuluz;
USE tuluz;

CREATE TABLE [dbo].[barrios](
	[barrio_id] [int]  PRIMARY KEY NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[localidad_id] [int] NOT NULL,
)

CREATE TABLE [dbo].[clientes](
	[cliente_id] [int] IDENTITY(1,1) PRIMARY KEY  NOT NULL,
	[cliente_cuit] [varchar](50) NOT NULL,
	[cliente_nombre] [varchar](50) NOT NULL,
	[cliente_apellido] [varchar](50) NOT NULL,
	[cliente_activo] [int] NOT NULL,

) 

CREATE TABLE [dbo].[cotizaciones](
	[numCotizacion] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_vendedor] [int] NOT NULL,
	[estado] [int] NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[apellidoCliente] [varchar](50) NULL,
	[fecha] [datetime] NOT NULL,
	[observaciones] [varchar](200) NULL,
	[precioTotal] [float] NULL,
	[motivo_perdida] [varchar](100) NULL,
 
)

CREATE TABLE [dbo].[detalle_cotizacion](
	[numDetalleCotizacion] [int] IDENTITY(1,1) NOT NULL,
	[numCotizacion] [int] NOT NULL,
	[cod_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_detalle_cotizacion] PRIMARY KEY  ([numDetalleCotizacion] )
)

CREATE TABLE [dbo].[empleados](
	[empleado_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[empleado_num_doc] [int] NOT NULL,
	[empleado_tipo_doc] [int] NOT NULL,
	[empleado_nombre] [varchar](50) NOT NULL,
	[empleado_apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NULL,
	[barrio_id] [int] NOT NULL,
	[telefono] [varchar](50) NULL,
	[empleado_id_jefe] [int] NULL,
	[empleado_activo] [int] NULL,
) 

CREATE TABLE [dbo].[estados_cotizaciones](
	[id_estado] [int]  PRIMARY KEY NOT NULL,
	[descripcion] [varchar](50) NULL,
) 

CREATE TABLE [dbo].[localidades](
	[localidad_id] [int] PRIMARY KEY NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[provincia_id] [int] NOT NULL,
 
)

CREATE TABLE [dbo].[productos](
	[id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[cantStock] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[descripcion] [varchar](200) NULL,
 
) 

CREATE TABLE [dbo].[proveedores](
	[proveedor_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[razon_social] [varchar](50) NOT NULL,
	[mail] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[proveedor_activo] [int] NOT NULL,
)

CREATE TABLE [dbo].[provincias](
	[provincia_id] [int] PRIMARY KEY NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 
) 

CREATE TABLE [dbo].[tipos_doc](
	[tipo_doc_id] [int]  PRIMARY KEY NOT NULL,
	[siglas] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 )

CREATE TABLE [dbo].[usuarios](
	[usuario_id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[usuario_nombre] [varchar](50) NOT NULL,
	[usuario_pass] [varchar](50) NOT NULL,
	[empleado_id] [int] NULL,
	[usuario_activo] [int] NULL,
 )

 CREATE TABLE FORMAS_DE_PAGO
(
FORMA_DE_PAGO_ID INT IDENTITY(1,1) PRIMARY KEY,
FORMA_DE_PAGO_NOMBRE VARCHAR(50) NOT NULL
);


CREATE TABLE VENTAS
(
VENTA_ID INT IDENTITY(1,1) PRIMARY KEY,
VENTA_FECHA DATETIME,
EMPLEADO_ID INT NOT NULL,
FORMA_DE_PAGO_ID INT NOT NULL,
COTIZACION INT NOT NULL,
--NUMERO_DE_FACTURA VARCHAR(50) NOT NULL,
CONSTRAINT VENTA_EMPL_FK FOREIGN KEY (EMPLEADO_ID) REFERENCES EMPLEADOS (EMPLEADO_ID),
CONSTRAINT VENTA_COT_FK FOREIGN KEY (COTIZACION) REFERENCES cotizaciones (numCotizacion),

CONSTRAINT VENTA_FORM_DE_PAGO_FK FOREIGN KEY (FORMA_DE_PAGO_ID) REFERENCES FORMAS_DE_PAGO (FORMA_DE_PAGO_ID)
);

GO
ALTER TABLE [dbo].[clientes] ADD UNIQUE NONCLUSTERED 
(
	[cliente_cuit] ASC
)
ALTER TABLE [dbo].[provincias] ADD  CONSTRAINT [provincia_nombre_id_uk] UNIQUE NONCLUSTERED 
(
	[nombre] ASC,
	[provincia_id] ASC
)

ALTER TABLE [dbo].[tipos_doc] ADD UNIQUE NONCLUSTERED 
(
	[tipo_doc_id] ASC
)
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
GO



INSERT [dbo].[provincias] ([provincia_id], [nombre]) VALUES (2, N'Buenos Aires')
INSERT [dbo].[provincias] ([provincia_id], [nombre]) VALUES (1, N'Cordoba')
INSERT [dbo].[provincias] ([provincia_id], [nombre]) VALUES (3, N'Salta')
GO

INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (1, N'Localidad1', 1)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (2, N'Localidad2', 1)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (3, N'Localidad3', 1)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (4, N'Localidad1', 2)
INSERT [dbo].[localidades] ([localidad_id], [nombre], [provincia_id]) VALUES (5, N'Localidad1', 3)

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
SET IDENTITY_INSERT [dbo].[cotizaciones] ON 

INSERT [dbo].[cotizaciones] ([numCotizacion], [id_cliente], [id_vendedor], [estado], [nombreCliente], [apellidoCliente], [fecha], [observaciones], [precioTotal], [motivo_perdida]) VALUES (1, 1, 1, 1, NULL, NULL, CAST(N'2022-10-17T00:00:00.000' AS DateTime), NULL, 2000, NULL)
INSERT [dbo].[cotizaciones] ([numCotizacion], [id_cliente], [id_vendedor], [estado], [nombreCliente], [apellidoCliente], [fecha], [observaciones], [precioTotal], [motivo_perdida]) VALUES (2, 2, 2, 3, NULL, NULL, CAST(N'2022-10-16T00:00:00.000' AS DateTime), NULL, 3500, NULL)
SET IDENTITY_INSERT [dbo].[cotizaciones] OFF
GO



SET IDENTITY_INSERT [dbo].[proveedores] ON 

INSERT [dbo].[proveedores] ([proveedor_id], [razon_social], [mail], [telefono], [proveedor_activo]) VALUES (1, N'Luminarias S.A.', N'ventas@luminariasac.com', N'3514688795', 0)
INSERT [dbo].[proveedores] ([proveedor_id], [razon_social], [mail], [telefono], [proveedor_activo]) VALUES (2, N'Foco S.A.', N'ventas@focosac.com', N'3598688795', 0)
INSERT [dbo].[proveedores] ([proveedor_id], [razon_social], [mail], [telefono], [proveedor_activo]) VALUES (3, N'La Guardia S.R.L', N'guardia@guardia.com', N'3151110920', 1)
SET IDENTITY_INSERT [dbo].[proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([id], [nombre], [precio], [cantStock], [id_proveedor], [descripcion]) VALUES (1, N'Linternas', 1200, 500, 1, NULL)
INSERT [dbo].[productos] ([id], [nombre], [precio], [cantStock], [id_proveedor], [descripcion]) VALUES (2, N'Tubos de Luz', 1602.35, 900, 2, NULL)
INSERT [dbo].[productos] ([id], [nombre], [precio], [cantStock], [id_proveedor], [descripcion]) VALUES (3, N'Pilas 1200mhA', 305.2, 200, 3, NULL)
SET IDENTITY_INSERT [dbo].[productos] OFF
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

INSERT INTO FORMAS_DE_PAGO (FORMA_DE_PAGO_NOMBRE) VALUES ('Efectivo');
INSERT INTO FORMAS_DE_PAGO (FORMA_DE_PAGO_NOMBRE) VALUES ('Tarjeta Debito');
INSERT INTO FORMAS_DE_PAGO (FORMA_DE_PAGO_NOMBRE) VALUES ('Tarjeta Credito');