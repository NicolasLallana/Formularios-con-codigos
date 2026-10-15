CREATE DATABASE dbClientes;
USE dbClientes;

CREATE TABLE Clientes(idCliente INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
idTarjeta INT NOT NULL, nombre_apellido VARCHAR(20), fec_nac DATE, fec_ingreso DATE);

CREATE TABLE Tarjetas(idTarjeta INT NOT NULL PRIMARY KEY, saldo FLOAT, vencimiento DATE);

CREATE TABLE Productos(idProducto INT IDENTITY(1,1) NOT NULL PRIMARY KEY, nombre VARCHAR(20), precio FLOAT)

CREATE TABLE Ventas(idVenta INT NOT NULL, idproducto INT)

DROP TABLE Clientes;