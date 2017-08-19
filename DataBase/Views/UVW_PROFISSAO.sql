IF EXISTS(select * from sys.views where name = 'UVW_PROFISSAO')
BEGIN
	DROP VIEW UVW_PROFISSAO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de profissão na base de dados
* Data Criação: 16/08/2017
* Autor: Rafael Marques
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

CREATE VIEW UVW_PROFISSAO
AS
	SELECT
		 ProfissaoID
		,Nome
		,Area
		,ISNULL(Descricao, 'ND') Descricao
	FROM
		TB_PROFISSAO
GO