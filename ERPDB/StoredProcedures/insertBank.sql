CREATE PROCEDURE [dbo].[insertBank]
	@Name NVARCHAR(255)

AS
	INSERT INTO Banks([Name])
					VALUES(@Name)
