IF EXISTS(select * from sys.views where name = 'UVW_CONDOMINIO')
BEGIN
	DROP VIEW UVW_CONDOMINIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de condominos na base de dados
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

CREATE VIEW UVW_CONDOMINIO
AS
	SELECT
		 CondominioID
		,Nome
		,QtdBlocos
		,ISNULL(Endereco, 'ND') Endereco
		,ISNULL(CEP, 'ND') CEP
		,ISNULL(Bairro, 'ND') Bairro
		,ISNULL(CI.Id, 0) CidadeID
		,ISNULL(CI.Name, 'ND') CidadeNome
		,Excluido
	FROM
		TB_CONDOMINIO CO
	left join
		TB_CIDADE CI
	ON
		CI.Id = CO.CidadeID
GO

