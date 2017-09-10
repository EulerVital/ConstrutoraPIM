IF EXISTS(select * from sys.views where name = 'UVW_BLOCO')
BEGIN
	DROP VIEW UVW_BLOCO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de blocos na base de dados
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

CREATE VIEW UVW_BLOCO
AS
	SELECT
		 B.BlocoID
		,B.Nome
		,B.QtdPredios
		,B.TipoBloco
		,B.StatusAtivo
		,ISNULL(C.CondominioID, 0) CondominioID
		,ISNULL(C.Nome, 'ND') NomeCondominio
		,ISNULL(C.QtdBlocos, 0) QtdBlocos
		,C.DataFundacao
		,ISNULL(C.Endereco, 'ND') Endereco
		,ISNULL(C.CEP, 'ND') CEP
		,ISNULL(C.Bairro, 'ND') Bairro
		,ISNULL(C.CidadeID, 0) CidadeID
		,ISNULL(C.CidadeNome, 'ND') CidadeNome
		,ISNULL(C.Excluido, 0) Excluido 
	FROM
		TB_BLOCO B
	left join
		UVW_CONDOMINIO C
	ON
		B.CondominioID = C.CondominioID
GO

