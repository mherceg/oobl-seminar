CREATE TRIGGER dbo.UserAlternateDelete ON dbo.[User]
INSTEAD OF DELETE
AS 
	IF EXISTS (SELECT * FROM [User] WHERE Id IN (SELECT Id FROM deleted))
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Insert statements for trigger here
		DECLARE @Users TABLE (Id INT);
		INSERT INTO @Users
			SELECT Id FROM deleted;

		BEGIN
			DELETE FROM Info
			WHERE UserId IN (SELECT * FROM @Users);

			DELETE FROM Comment
			WHERE UserId IN (SELECT * FROM @Users);

			DELETE FROM ReputationComment
			WHERE UserId IN (SELECT * FROM @Users);

			DELETE FROM ReputationInfo
			WHERE UserId IN (SELECT * FROM @Users);
		END

	END
GO
