USE PMN
GO

CREATE PROCEDURE dbo.AspNetRoles_Add
(
       @Id nvarchar, @Name nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.AspNetRoles
	            (
				 Id, Name
				)
		 VALUES (
		         @Id, @Name
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH