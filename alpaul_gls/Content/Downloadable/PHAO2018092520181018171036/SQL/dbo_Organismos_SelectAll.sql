USE PHAO20180925
GO

CREATE PROCEDURE dbo.Organismos_GetAll
AS
	SELECT OrganismoId, DscOrganismo, Sigla, URL, TOrganismoId, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.Organismos