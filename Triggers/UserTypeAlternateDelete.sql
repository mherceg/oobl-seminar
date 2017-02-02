CREATE TRIGGER dbo.UserTypeAlternateDelete ON dbo.UserType
INSTEAD OF DELETE
AS 
	IF EXISTS (SELECT * FROM UserType WHERE Id IN (SELECT Id FROM deleted))
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Insert statements for trigger here
		DECLARE @Types TABLE (Id INT);
		INSERT INTO @Types
			SELECT Id FROM deleted;

		BEGIN
			DELETE FROM [User]
			WHERE UserTypeId IN (SELECT * FROM @Types);

		END

	END
GO
