IF EXISTS(select * from sys.procedures where name = 'USP_CIDADE_GET')
BEGIN
	DROP PROC USP_CIDADE_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de cidades com filtros base de dados
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

CREATE PROC USP_CIDADE_GET
(
	 @CidadeID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@EstadoID INT = NULL
	,@UF VARCHAR(2) = NULL
)
AS
BEGIN
	SELECT
		  Id
		 ,Nome
		 ,EstadoID
		 ,EstadoNome
		 ,UF
	FROM
		UVW_CIDADE
	WHERE
		 Id = COALESCE(@CidadeID, Id)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 EstadoID = COALESCE(@EstadoID, EstadoID)
	AND
		 UF = COALESCE(@UF, UF)
	ORDER BY
		Nome
END
GO