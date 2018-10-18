USE PMN
GO

CREATE PROCEDURE dbo.TContactos_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT TContactoId, DscTContacto, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TContactos 
	 WHERE TContactoId = @value