
CREATE PROCEDURE Crear_Cliente
@idt INT,
@nom VARCHAR(20),
@nac DATE
AS
	BEGIN
		INSERT INTO Clientes(idTarjeta, nombre_apellido, fec_nac, fec_ingreso)
		VALUES (@idt, @nom, @nac, GETDATE())
	END
GO

CREATE PROCEDURE Crear_Tarjeta
@idt INT
AS
	BEGIN
		INSERT INTO Tarjetas(idTarjeta, saldo, vencimiento)
		VALUES (@idt, 0.0, DATEADD(YEAR, 1, GETDATE()));
	END
GO

CREATE PROCEDURE Crear_Venta
@idv INT,
@idp INT
AS
	BEGIN
		INSERT INTO Ventas(idVenta, idproducto)
		VALUES (@idv, @idp);
	END
GO

CREATE PROCEDURE Crear_Producto
@nom VARCHAR(20),
@precio FLOAT
AS
	BEGIN
		INSERT INTO Productos(nombre, precio)
		VALUES (@nom, @precio);
	END
GO

CREATE PROCEDURE Cargar_Saldo
@idt INT,
@monto DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Tarjetas
    SET Saldo = Saldo + @monto
    WHERE idTarjeta = @idt;
END;
GO


CREATE PROCEDURE Asociar_Tarjeta
@idt INT,
@idc INT
AS
	BEGIN
		UPDATE Clientes
		SET idTarjeta = @idt
		WHERE idCliente = @idc
	END
GO


INSERT INTO Clientes(idTarjeta, nombre_apellido, fec_nac, fec_ingreso)VALUES (769265422,'Nicolas', '9/5/1996', GETDATE());

SELECT * FROM Clientes;

SELECT * FROM Tarjetas;

EXEC Crear_Cliente 769265424,'Javier Lopez', '1983-10-12';

INSERT INTO Clientes(idTarjeta, saldo, vencimiento) VALUES (1, 0.0, DATEADD(YEAR, 1, GETDATE()));

DROP PROCEDURE Crear_Cliente;
DROP PROCEDURE Cargar_Saldo;

EXEC Cargar_Saldo 60117, 50;