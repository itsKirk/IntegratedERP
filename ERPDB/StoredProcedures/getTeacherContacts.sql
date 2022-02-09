CREATE PROCEDURE [dbo].[getTeacherContacts]
	@TeacherId INT

AS
	SELECT EmailAddress, PhoneNumber1, PhoneNumber2, PhysicalAddress, Town FROM Teachers WHERE Id = @TeacherId
