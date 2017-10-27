IF EXISTS(select * from sys.procedures where name = 'USP_TIPOESTADIA_GET')
BEGIN
	DROP PROC USP_TIPOESTADIA_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo estadia de apartamentos com filtros base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC USP_TIPOESTADIA_GET
(
	 @TipoEstadiaID INT  = NULL
	,@Nome VARCHAR(50) = NULL
)
AS
BEGIN
	SELECT
		 TipoEstadiaID
		,Nome
		,ValorFixo
		,Excluido
	FROM
		UVW_TIPOESTADIA
	WHERE
		 TipoEstadiaID = COALESCE(@TipoEstadiaID, TipoEstadiaID)
	AND
		 Nome = COALESCE(@Nome, Nome)
END
GO