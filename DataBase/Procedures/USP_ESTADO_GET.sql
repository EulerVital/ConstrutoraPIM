IF EXISTS(select * from sys.procedures where name = 'USP_ESTADO_GET')
BEGIN
	DROP PROC USP_ESTADO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de ESTADOs com filtros base de dados
* Data Criação: 12/08/2017
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

CREATE PROC USP_ESTADO_GET
(
	 @EstadoID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@UF VARCHAR(2) = NULL
)
AS
BEGIN
	SELECT
		  Id
		 ,Name Nome
		 ,UF
	FROM
		UVW_ESTADO
	WHERE
		 Id = COALESCE(@EstadoID, Id)
	AND
		 Name = COALESCE(@Nome, Name)
	AND
		 UF = COALESCE(@UF, UF)
	ORDER BY
		UF
END
GO