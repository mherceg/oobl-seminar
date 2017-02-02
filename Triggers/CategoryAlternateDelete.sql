CREATE TRIGGER dbo.CategoryAlternateDelete ON dbo.Category
INSTEAD OF DELETE
AS 
	IF EXISTS (SELECT * FROM Category WHERE Id IN (SELECT Id FROM deleted))
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Insert statements for trigger here
		DECLARE @Categories TABLE (Id INT);
		INSERT INTO @Categories
			SELECT Id FROM deleted;

		BEGIN
			DELETE FROM Info
			WHERE CategoryId IN (SELECT * FROM @Categories);
		END

	END
GO

