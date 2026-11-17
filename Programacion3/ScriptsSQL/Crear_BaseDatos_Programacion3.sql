CREATE DATABASE Programacion3;
GO

USE Programacion3;
GO

CREATE TABLE dbo.Productos
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(200) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL
);
GO