-- ==============================================
-- Create dml trigger template Azure SQL Database 
-- ==============================================
-- Drop the dml trigger if it already exists
/*
IF EXISTS(
  SELECT *
    FROM sys.triggers
   WHERE name = N'<Trigger_Name, sysname, Trigger_Name>'
     AND parent_class_desc = N'OBJECT_OR_COLUMN'
)
	DROP TRIGGER <Schema_Name, sysname, Schema_Name>.<Trigger_Name, sysname, Trigger_Name>
GO*/

/*
CREATE TRIGGER [dbo].[tr_Fakultet_Delete] ON [dbo].[Fakultet]
INSTEAD OF DELETE
AS
    IF EXISTS (SELECT * FROM Fakultet WHERE FakultetId IN (SELECT FakultetId FROM Deleted))
    BEGIN
        DECLARE @Fakulteti TABLE (FakultetId INT);
        INSERT INTO @Fakulteti
            SELECT FakultetId FROM deleted;
           
        BEGIN
            DELETE FROM StudijskiProgram
            WHERE StudijskiProgramFakultetId IN (SELECT * FROM @Fakulteti);
           
            DELETE FROM Odbor
            WHERE OdborFakultetId IN (SELECT * FROM @Fakulteti);
 
            DELETE FROM Fakultet
            WHERE FakultetId IN (SELECT * FROM @Fakulteti);
        END
    END
GO
*/

CREATE TRIGGER dbo.InfoAlternateDelete ON dbo.Info
INSTEAD OF DELETE
AS 
	IF EXISTS (SELECT * FROM Info WHERE Id IN (SELECT Id FROM deleted))
	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from
		-- interfering with SELECT statements.
		SET NOCOUNT ON;

		-- Insert statements for trigger here
		DECLARE @Informacije TABLE (Id INT);
		INSERT INTO @Informacije
			SELECT Id FROM deleted;

		BEGIN
			DELETE FROM Comment
			WHERE InfoId IN (SELECT * FROM @Informacije);

			DELETE FROM ReputationInfo
			WHERE InfoID IN (SELECT * FROM @Informacije);
		END

	END
GO
