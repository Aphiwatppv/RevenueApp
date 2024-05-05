CREATE PROCEDURE [dbo].[spLogin]
    @Email NVARCHAR(50),
    @HashPassword NVARCHAR(256)
AS
BEGIN
    
    SELECT a.Id, a.FirstName, a.LastName, a.Email, r.RoleId, r.RoleName
    FROM AccountTB a
    INNER JOIN UserRoles ur ON a.Id = ur.UserId
    INNER JOIN Roles r ON ur.RoleId = r.RoleId
    WHERE a.Email = @Email AND a.HashPassword = @HashPassword;


    IF @@ROWCOUNT = 0
    BEGIN
  
        SELECT NULL AS Id; 
    END
END;