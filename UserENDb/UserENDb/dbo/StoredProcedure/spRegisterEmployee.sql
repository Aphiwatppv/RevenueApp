CREATE PROCEDURE [dbo].[spRegisterEmployee]
    @EN NVARCHAR(50),
    @Name NVARCHAR(50),
    @Salt NVARCHAR(100),
    @HashPassword NVARCHAR(100),
    @RoleId INT = 99
AS
BEGIN
    -- Check if the Employee Number (EN) already exists
    IF NOT EXISTS (SELECT 1 FROM [dbo].[AccountTb] WHERE EN = @EN)
    BEGIN
        -- If it does not exist, insert the new user
        INSERT INTO [dbo].[AccountTb] (EN, Name, Salt, HashPassword, RoleId, CreatingDate)
        VALUES (@EN, @Name, @Salt, @HashPassword, @RoleId, GETDATE());

        -- Return a message or status code
        SELECT 'User registered successfully' AS Status;
    END
    ELSE
    BEGIN
        -- Return a message or status code
        SELECT 'EN already exists' AS Status;
    END
END;