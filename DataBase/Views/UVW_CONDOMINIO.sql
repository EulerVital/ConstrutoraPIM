IF EXISTS(select * from sys.views where name = 'UVW_CONDOMINIO')
BEGIN
	DROP VIEW UVW_CONDOMINIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de condominos na base de dados
* Data Cria��o: 12/08/2017
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

CREATE VIEW UVW_CONDOMINIO
AS
	SELECT
		 CondominioID
		,CO.Nome
		,QtdBlocos
		,ISNULL(Endereco, 'ND') Endereco
		,ISNULL(CEP, 'ND') CEP
		,ISNULL(Bairro, 'ND') Bairro
		,ISNULL(CI.Id, 0) CidadeID
		,ISNULL(CI.Nome, 'ND') CidadeNome
		,DataFundacao
		,EstadoID
		,EstadoNome
		,UF
		,Excluido
	FROM
		TB_CONDOMINIO CO
	left join
		UVW_CIDADE CI
	ON
		CI.Id = CO.CidadeID
GO

