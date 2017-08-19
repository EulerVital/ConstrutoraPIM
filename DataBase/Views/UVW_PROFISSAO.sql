IF EXISTS(select * from sys.views where name = 'UVW_PROFISSAO')
BEGIN
	DROP VIEW UVW_PROFISSAO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de profiss�o na base de dados
* Data Cria��o: 16/08/2017
* Autor: Rafael Marques
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