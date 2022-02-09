CREATE PROCEDURE [dbo].[insertEditedSubject]
	@Id INT,
	@Name NVARCHAR(50),
	@Code NVARCHAR(10),
	@IsExaminable BIT,
	@ColorBytes NVARCHAR(15),
  @TimeOfEdit DATETIME,
	@Remarks NVARCHAR(255)
	
AS
	INSERT INTO EditedSubjects([Id],[Name], [Code], [IsExaminable], [ColorBytes], [TimeOfEdit], [Remarks])
							VALUES(@Id,@Name, @Code, @IsExaminable, @ColorBytes, @TimeOfEdit, @Remarks)
