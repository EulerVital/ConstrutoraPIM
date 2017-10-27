IF EXISTS(select * from sys.procedures where name = 'USP_TIPOESTADIA_GET')
BEGIN
	DROP PROC USP_TIPOESTADIA_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de tipo estadia de apartamentos com filtros base de dados
* Data Cria��o: 17/09/2017
* Autor: Euler Vital
*********************
**Altera��es
* Motivo:
* Data Cria��o:
* Autor:
*********************
**Altera��es
* Motivo:
* Data Cria��o:
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