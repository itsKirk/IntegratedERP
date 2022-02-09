CREATE TABLE [dbo].[DeletedSubjects]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Code] NVARCHAR(10) NOT NULL, 
    [IsExaminable] BIT NOT NULL, 
    [ColorBytes] NVARCHAR(20) NOT NULL,
    [TimeOfDelete] DATETIME NOT NULL

)