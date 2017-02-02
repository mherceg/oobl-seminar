CREATE TRIGGER dbo.CommentAlternateDelete ON dbo.Comment
INSTEAD OF DELETE
AS 
	IF EXISTS (SELECT * FROM Comment WHERE Id IN (SELECT Id FROM deleted))
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Insert statements for trigger here
		DECLARE @Comments TABLE (Id INT);
		INSERT INTO @Comments
			SELECT Id FROM deleted;

		BEGIN
			DELETE FROM ReputationComment
			WHERE CommentId IN (SELECT * FROM @Comments);

		END

	END
GO
