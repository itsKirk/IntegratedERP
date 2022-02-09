CREATE PROCEDURE [dbo].[deleteBank]
	@Name NVARCHAR(255)
AS
	DELETE FROM Banks WHERE [Name] = @Name
