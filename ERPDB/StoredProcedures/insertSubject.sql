CREATE PROCEDURE [dbo].[insertSubject]
	@Name NVARCHAR(50),
	@Code NVARCHAR(10),
	@IsExaminable BIT,
	@ColorBytes NVARCHAR(15),
	@Id INT = 0 OUTPUT
AS
	INSERT INTO Subjects([Name], [Code], [IsExaminable], [ColorBytes])
							VALUES(@Name, @Code, @IsExaminable, @ColorBytes)
SELECT @Id = SCOPE_IDENTITY();
