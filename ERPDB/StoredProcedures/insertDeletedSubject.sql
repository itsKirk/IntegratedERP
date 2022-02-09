CREATE PROCEDURE [dbo].[insertDeletedSubject]
	@Id INT,
	@Name NVARCHAR(50),
	@Code NVARCHAR(10),
	@IsExaminable BIT,
	@ColorBytes NVARCHAR(15),
  @TimeOfDelete DATETIME

AS
	INSERT INTO DeletedSubjects([Id],[Name], [Code], [IsExaminable], [ColorBytes], [TimeOfDelete])
							VALUES(@Id,@Name, @Code, @IsExaminable, @ColorBytes, @TimeOfDelete)
