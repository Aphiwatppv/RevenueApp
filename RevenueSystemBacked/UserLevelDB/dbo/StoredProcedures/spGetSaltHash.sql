CREATE PROCEDURE [dbo].[spGetSaltHash]
@email nvarchar(50)
as
begin
	select Salt,HashPassword from dbo.AccountTB
	where Email = @email

end
