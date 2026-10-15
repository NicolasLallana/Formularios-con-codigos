CREATE FUNCTION Consulta_Saldo
(@idt INT)
RETURNS FLOAT(10,2)
AS
BEGIN
    DECLARE @Saldo FLOAT(10,2);

    IF EXISTS (SELECT 1
               FROM Tarjetas
               WHERE idTarjeta = @idt)
    BEGIN
        SELECT @Saldo = Saldo
        FROM Tarjetas
        WHERE idTarjeta = @idt;
    END
    ELSE
    BEGIN
        SET @Saldo = 0;
    END

    RETURN @Saldo;
END;
GO

CREATE FUNCTION Validar_Codigo
(@idt INT)
RETURNS BIT
AS
    BEGIN
        DECLARE @res BIT
        IF EXISTS (SELECT 1 FROM Tarjetas WHERE idTarjeta = @idt)
        BEGIN
            SET @res = 1;
        END
        ELSE
        BEGIN
            SET @res = 0;
        END
        RETURN @res;
	END;
GO

SELECT dbo.Validar_Codigo('2413') AS ExisteTarjeta;
SELECT dbo.Consulta_Saldo(60117) AS Saldo;
