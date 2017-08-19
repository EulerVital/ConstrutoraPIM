IF EXISTS(select * from sys.procedures where name = 'USP_PROFISSAO_GET')
BEGIN
	DROP PROC USP_PROFISSAO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de profissao com filtros base de dados
* Data Criação: 17/08/2017
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

CREATE PROC USP_PROFISSAO_GET
(
	 @ProfissaoID INT = NULL
	,@Nome VARCHAR(150) = NULL
	,@Area VARCHAR(150) = NULL
	,@Descricao VARCHAR(300) = NULL
)
AS
BEGIN
	SELECT
		 ProfissaoID
		,Nome
		,Area
		,Descricao
	FROM
		UVW_PROFISSAO
	WHERE
		 ProfissaoID = COALESCE(@ProfissaoID, ProfissaoID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 Area = COALESCE(@Area, Area)
	AND
		 Descricao = COALESCE(@Descricao, Descricao)
END
GO
tb_profissao