/*
MODELO DE DATOS:  
TRABAJO PRACTICO PAV1 - UTN-FRC
GRUPO 6
EMPRESA TU LUZ 
*/
--
--EJECUTAR EL COMANDO DE CREACIÓN DE LA BASE DE DATOS PRIMERO (SOLO).
--PARA EJECUTAR SOLO ESTA LINEA SE LA DEBE PINTAR Y OPRIMIR TECLA F5
CREATE DATABASE EmpresaTuLuz;
-- LUEGO DE EJECUTAR EL COMANDO DE CREACIÓN COMENTAR LA LINEA CON --
-- COMENTADA LA LÍNEA DE CREACIÓN DE LA BASE DE DATOS, VOLVER A OPRIMIR F5 PARA QUE EJECUTE DESDE USE GDA
-- SE CREAN LAS TABLAS Y SE POBLARÁN LAS MISMAS 
USE EmpresaTuLuz;
--Tabla provincias
CREATE TABLE provincias
(
provincia_id		INT			CONSTRAINT provincias_id_nn NOT NULL,
nombre				VARCHAR(50)	CONSTRAINT provincias_nombre_nn NOT NULL,
CONSTRAINT provincia_id_pk PRIMARY KEY(provincia_id),
CONSTRAINT provincia_nombre_id_uk UNIQUE(nombre, provincia_id)
)

INSERT INTO provincias VALUES(1,'Cordoba');
INSERT INTO provincias VALUES(2,'Buenos Aires');
INSERT INTO provincias VALUES(3,'Salta');

--Tabla localidades
CREATE TABLE localidades
(
localidad_id		INT			CONSTRAINT localidades_id_nn NOT NULL,
nombre				VARCHAR(50)	CONSTRAINT localidades_nombre_nn NOT NULL,
provincia_id		INT NOT NULL,
CONSTRAINT localidad_id_pk PRIMARY KEY(localidad_id)
)

ALTER TABLE localidades ADD CONSTRAINT localidad_id_provincia_fk FOREIGN KEY (provincia_id) REFERENCES provincias (provincia_id)

INSERT INTO localidades VALUES(1,'Localidad1',1);
INSERT INTO localidades VALUES(2,'Localidad2',1);
INSERT INTO localidades VALUES(3,'Localidad3',1);
INSERT INTO localidades VALUES(4,'Localidad1',2);
INSERT INTO localidades VALUES(5,'Localidad1',3);

--Tabla barrios
CREATE TABLE barrios
(
barrio_id		INT			CONSTRAINT barrios_id_nn NOT NULL,
nombre			VARCHAR(50)	CONSTRAINT barrios_nombre_nn NOT NULL,
localidad_id	INT NOT NULL,
CONSTRAINT barrio_id_pk PRIMARY KEY(barrio_id)
)

ALTER TABLE barrios
   ADD CONSTRAINT barrios_id_localidades_fk
   FOREIGN KEY (localidad_id) REFERENCES localidades (localidad_id);

INSERT INTO barrios VALUES(1,'Barrio1',1);
INSERT INTO barrios VALUES(2,'Barrio2',1);
INSERT INTO barrios VALUES(3,'Barrio3',1);
INSERT INTO barrios VALUES(4,'Barrio1',2);
INSERT INTO barrios VALUES(5,'Barrio1',3);
INSERT INTO barrios VALUES(6,'Barrio1',4);
INSERT INTO barrios VALUES(7,'Barrio1',5);

--Tabla tipo Documento

CREATE TABLE tipos_doc
(
tipo_doc_id		INT	UNIQUE NOT NULL,
siglas			VARCHAR(10) NOT NULL,
nombre			VARCHAR(50) NOT NULL,
CONSTRAINT tipo_doc_id_pk PRIMARY KEY(tipo_doc_id)
)

INSERT INTO tipos_doc VALUES(1, 'DNI', 'Documento Nacional de Identidad')
INSERT INTO tipos_doc VALUES(2, 'PAS', 'Pasaporte')


--Tabla Empleados
CREATE TABLE empleados
(
empleado_id			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
empleado_num_doc	INT NOT NULL,	
empleado_tipo_doc	INT NOT NULL,
empleado_nombre		VARCHAR(50) NOT NULL,
empleado_apellido	VARCHAR(50) NOT NULL,
direccion			VARCHAR(50),
barrio_id			INT NOT NULL,
telefono			VARCHAR(50),
empleado_id_jefe	INT,
empleado_activo		INT,
)

ALTER TABLE empleados
   ADD CONSTRAINT empleados_barrio_id_fk
   FOREIGN KEY (barrio_id) REFERENCES barrios (barrio_id);
ALTER TABLE empleados
   ADD CONSTRAINT empleados_jefe_fk
   FOREIGN KEY (empleado_id) REFERENCES empleados (empleado_id);

INSERT INTO empleados (empleado_num_doc, empleado_tipo_doc, empleado_nombre, empleado_apellido,direccion,barrio_id,telefono,empleado_id_jefe,empleado_activo)
VALUES(12123465,1,'Cristian','Flores','Tandil 1000',1,'351264879',NULL,0);

INSERT INTO empleados (empleado_num_doc, empleado_tipo_doc, empleado_nombre, empleado_apellido,direccion,barrio_id,telefono,empleado_id_jefe,empleado_activo)
VALUES(15646523,2,'Tom','Lopez','Ituzaingo 2000',1,'351123812',1,0);

INSERT INTO empleados (empleado_num_doc, empleado_tipo_doc, empleado_nombre, empleado_apellido,direccion,barrio_id,telefono,empleado_id_jefe,empleado_activo)
VALUES(16764543,1,'Raul','Jimenez','Velez 230',2,'3516534812',1,0);

--Tabla usuarios
CREATE TABLE usuarios
(
usuario_id			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
usuario_nombre		VARCHAR(50) NOT NULL,
usuario_pass		VARCHAR(50) NOT NULL,
empleado_id			INT,
usuario_activo		INT
)

ALTER TABLE usuarios
   ADD CONSTRAINT usuarios_empleados_fk
   FOREIGN KEY (empleado_id) REFERENCES empleados (empleado_id);

INSERT INTO usuarios (usuario_nombre, usuario_pass, empleado_id, usuario_activo)
VALUES('admi','admi',1,0);
INSERT INTO usuarios (usuario_nombre, usuario_pass, empleado_id, usuario_activo)
VALUES('user','user',2,0);

--Tabla clientes
CREATE TABLE clientes 
(
cliente_id				INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
cliente_cuit			VARCHAR(50) CONSTRAINT clientes_cuit_nn NOT NULL UNIQUE,
cliente_nombre			VARCHAR(50) CONSTRAINT clientes_nombre_nn NOT NULL,
cliente_apellido		VARCHAR(50)	CONSTRAINT clientes_apellido_nn NOT NULL,
cliente_activo			INT CONSTRAINT clientes_activo_nn NOT NULL)

--Agregar datos
INSERT INTO clientes VALUES('A2345678910', 'Rodrigo', 'Calmalha',0);
INSERT INTO clientes VALUES('B2345S78910', 'Pedro', 'Salinas',0);
INSERT INTO clientes VALUES('C2345W78910', 'Myrella', 'Moncada',0);
INSERT INTO clientes VALUES('DD23W5678910', 'Cindy', 'Jimenez',0);
INSERT INTO clientes VALUES('E2345678910', 'Rodrigo', 'Grados',0);
INSERT INTO clientes VALUES('F2345678910', 'Raul', 'Rodriguez',0);
INSERT INTO clientes VALUES('G2345678910', 'Jose', 'Lopez',0);
INSERT INTO clientes VALUES('H2345678910', 'Miguel', 'Martinez',0);
INSERT INTO clientes VALUES('I2345678910', 'Xiomara', 'Rodriguez',0);
INSERT INTO clientes VALUES('J2345678910', 'Agustina', 'Lopez',0);
INSERT INTO clientes VALUES('K2345678910', 'Lizet', 'Fernandez',0);
INSERT INTO clientes VALUES('L2345678910', 'Maria', 'Fernandez',0);
INSERT INTO clientes VALUES('M2345678910', 'Brigitte', 'Castillo',0);

--Tabla Proveedores
CREATE TABLE proveedores
(
proveedor_id		INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
razon_social		VARCHAR(50) NOT NULL,
mail				VARCHAR(50),
telefono			VARCHAR(50),
proveedor_activo	INT NOT NULL,
)

INSERT INTO proveedores VALUES('Luminarias S.A.','ventas@luminariasac.com','3514688795',0);
INSERT INTO proveedores VALUES('Foco S.A.','ventas@focosac.com','3598688795',0);
/*
--Tabla Producto
CREATE TABLE productos
(
producto_id					INT,
producto_nombre				VARCHAR(50),
descripcion					VARCHAR(50),
producto_precio				FLOAT,
cantidad_stock				INT,
proveedor_id				INT,
producto_id_equivalente		INT,
producto_activo				bit,
CONSTRAINT productos_pk PRIMARY KEY(producto_id)
)
ALTER TABLE productos
   ADD CONSTRAINT productos_proveedores_fk
   FOREIGN KEY (proveedor_id) REFERENCES proveedores (proveedor_id);
ALTER TABLE productos
   ADD CONSTRAINT productos_equivalentes_fk
   FOREIGN KEY (producto_id_equivalente) REFERENCES productos (producto_id);

INSERT INTO productos VALUES(1,'Luminaria Tubular Doble Blanca','Una luminaria',1200,3,1,1,0);
INSERT INTO productos VALUES(2,'Luminaria Tubular Doble Negra','Una luminaria',1400,5,2,1,0);
INSERT INTO productos VALUES(3,'Transformador','Componente electronico',100,3,1,3,0);
INSERT INTO productos VALUES(4,'Reactancias','Componente 1',100,4,1,3,0);
INSERT INTO productos VALUES(5,'Tubos de luz blanca x 1 m','Componente 2',100,5,2,3,0);
INSERT INTO productos VALUES(6,'Base cromo x 1m','Componente 3',100,6,1,3,0);

--Tabla detalles_producto

CREATE TABLE detalles_producto
(
producto_id_generico		INT,
producto_id_componente		INT,
cantidad					INT,
precio						FLOAT,
CONSTRAINT detalles_producto_pk PRIMARY KEY(producto_id_generico, producto_id_componente)
)
ALTER TABLE detalles_producto
   ADD CONSTRAINT detalle_producto_generico_fk
   FOREIGN KEY (producto_id_generico) REFERENCES productos (producto_id);
ALTER TABLE detalles_producto
   ADD CONSTRAINT detalle_producto_componente_fk
   FOREIGN KEY (producto_id_componente) REFERENCES productos (producto_id);

INSERT INTO detalles_producto VALUES(1,3,1,100);
INSERT INTO detalles_producto VALUES(1,4,2,100);
INSERT INTO detalles_producto VALUES(1,5,2,100);
INSERT INTO detalles_producto VALUES(1,6,1,100);
INSERT INTO detalles_producto VALUES(2,3,1,100);
INSERT INTO detalles_producto VALUES(2,4,2,100);
INSERT INTO detalles_producto VALUES(2,5,2,100);



*/



