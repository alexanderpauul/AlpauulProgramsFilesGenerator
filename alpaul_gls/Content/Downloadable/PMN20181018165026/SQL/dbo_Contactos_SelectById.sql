USE PMN
GO

CREATE PROCEDURE dbo.Contactos_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT ContactoId, DscContacto, TContactoId, PersonaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Contactos 
	 WHERE ContactoId = @value