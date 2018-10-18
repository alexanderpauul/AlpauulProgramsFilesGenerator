USE PMN
GO

CREATE PROCEDURE dbo.AspNetRoles_Edit
(
       @Id nvarchar, @Name nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.AspNetRoles 
		   SET Id = @Id, Name = @Name
		 WHERE Id = @Id

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH