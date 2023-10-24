CREATE PROCEDURE AddHistory
    @WorkItemId VARCHAR(200),
    @Name NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @Hours DECIMAL(10, 2),
    @Resultado INT OUTPUT
AS
BEGIN
    BEGIN TRY
        INSERT INTO History (WorkItemId, Name, Description, Hours)
        VALUES (@WorkItemId, @Name, @Description, @Hours);
        
        SET @Resultado = 1; -- Éxito
    END TRY
    BEGIN CATCH
        SET @Resultado = -1; -- Error
    END CATCH
END;