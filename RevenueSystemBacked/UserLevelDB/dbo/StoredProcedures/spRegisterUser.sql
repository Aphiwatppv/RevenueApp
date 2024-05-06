CREATE PROCEDURE [dbo].[spRegisterUser]
    @FirstName NVARCHAR(30),
    @LastName NVARCHAR(30),
    @Email NVARCHAR(50),
    @IdentityID NVARCHAR(20),
    @HashPassword NVARCHAR(256),
    @Salt NVARCHAR(256),
    @Result VARCHAR(100) OUTPUT
AS
BEGIN
    
    SET NOCOUNT ON;
    IF EXISTS(SELECT 1 FROM [AccountTB]  WHERE FirstName = @FirstName AND LastName = @LastName)
    BEGIN 
        SET @Result = 'First name and last name aleady exist';
        RETURN ;
    END
    ELSE IF EXISTS(SELECT 1 FROM [AccountTB]  WHERE Email = @Email)
    BEGIN
        SET @Result = 'A user with the given email already exists.';
        RETURN;
    END
    ELSE IF EXISTS(SELECT 1 FROM [AccountTB]  WHERE IdentityID = @IdentityID)
    BEGIN 
        SET @Result = 'Identity ID already exists.';
        RETURN;
    END
    ELSE
    BEGIN
        INSERT INTO [AccountTB] (FirstName, LastName, Email, IdentityID, HashPassword, Salt)
        VALUES (@FirstName, @LastName, @Email, @IdentityID, @HashPassword, @Salt);

        SET @Result = 'You have been registered successfully.';
    END
END;