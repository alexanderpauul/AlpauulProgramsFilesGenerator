USE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_Add
(
       @OrganismoId int, @DscOrganismo nvarchar, @Sigla nvarchar, @URL nvarchar, @TOrganismoId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Organismos
	            (
				 OrganismoId, DscOrganismo, Sigla, URL, TOrganismoId, UserId, Registro, Modificacion, Identificador, EstadoId
				)
		 VALUES (
		         @OrganismoId, @DscOrganismo, @Sigla, @URL, @TOrganismoId, @UserId, @Registro, @Modificacion, @Identificador, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCHUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_Add
(
       @OrganismoId int, @DscOrganismo nvarchar, @Sigla nvarchar, @URL nvarchar, @TOrganismoId int, @UserId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @EstadoId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Organismos
	            (
				 OrganismoId, DscOrganismo, Sigla, URL, TOrganismoId, UserId, Registro, Modificacion, Identificador, EstadoId
				)
		 VALUES (
		         @OrganismoId, @DscOrganismo, @Sigla, @URL, @TOrganismoId, @UserId, @Registro, @Modificacion, @Identificador, @EstadoId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH