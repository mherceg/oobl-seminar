CREATE TRIGGER dbo.PlaceAlternateDelete ON dbo.Place
INSTEAD OF DELETE
AS 
	IF EXISTS (SELECT * FROM Place WHERE Id IN (SELECT Id FROM deleted))
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Insert statements for trigger here
		DECLARE @Places TABLE (Id INT);
		INSERT INTO @Places
			SELECT Id FROM deleted;

		BEGIN
			DELETE FROM Info
			WHERE PlaceId IN (SELECT * FROM @Places);

			DELETE FROM Sponsorship
			WHERE PlaceId IN (SELECT * FROM @Places)

			DELETE FROM FavoritePlace
			WHERE PlaceId IN (SELECT * FROM @Places)
		END

	END
GO
