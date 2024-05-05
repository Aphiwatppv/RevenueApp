CREATE PROCEDURE [dbo].[spRegisterUser]
    @FirstName NVARCHAR(30),
    @LastName NVARCHAR(30),
    @Email NVARCHAR(50),
    @IdentityID NVARCHAR(20),
    @HashPassword NVARCHAR(256),
    @Salt NVARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the email or identity ID already exists in the database
    IF EXISTS (SELECT 1 FROM AccountTB WHERE Email = @Email OR IdentityID = @IdentityID)
    BEGIN
        -- If they do, return a status code indicating failure
        SELECT -1 AS StatusCode;  -- Can signify 'Email or Identity ID already exists'
        RETURN;
    END

    -- Insert the new user data into AccountTB
    INSERT INTO AccountTB (FirstName, LastName, Email, IdentityID, HashPassword, Salt)
    VALUES (@FirstName, @LastName, @Email, @IdentityID, @HashPassword, @Salt);

    -- If insertion is successful, return a status code indicating success
    SELECT 1 AS StatusCode;  -- Can signify 'Success'
END;
