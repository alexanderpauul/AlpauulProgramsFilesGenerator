USE PMN
GO

CREATE PROCEDURE dbo.AspNetUsers_Edit
(
       @Id nvarchar, @Email nvarchar, @EmailConfirmed bit, @PasswordHash nvarchar, @SecurityStamp nvarchar, @PhoneNumber nvarchar, @PhoneNumberConfirmed bit, @TwoFactorEnabled bit, @LockoutEndDateUtc datetime, @LockoutEnabled bit, @AccessFailedCount int, @UserName nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.AspNetUsers 
		   SET Id = @Id, Email = @Email, EmailConfirmed = @EmailConfirmed, PasswordHash = @PasswordHash, SecurityStamp = @SecurityStamp, PhoneNumber = @PhoneNumber, PhoneNumberConfirmed = @PhoneNumberConfirmed, TwoFactorEnabled = @TwoFactorEnabled, LockoutEndDateUtc = @LockoutEndDateUtc, LockoutEnabled = @LockoutEnabled, AccessFailedCount = @AccessFailedCount, UserName = @UserName
		 WHERE Id = @Id

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH