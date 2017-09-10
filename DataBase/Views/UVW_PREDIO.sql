IF EXISTS(select * from sys.views where name = 'UVW_PREDIO')
BEGIN
	DROP VIEW UVW_PREDIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de predios da base de dados
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

CREATE VIEW UVW_PREDIO
AS
	SELECT
		 P.PredioID
		,P.Nome
		,ISNULL(P.QtdApartamentos, 0) QtdApartamentos
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,P.Excluido 
		,ISNULL(B.QtdPredios, 0) QtdPredios
		,ISNULL(B.TipoBloco, 'ND') TipoBloco
		,ISNULL(B.StatusAtivo, 0) StatusAtivo
		,ISNULL(B.CondominioID, 0) CondominioID
		,ISNULL(B.NomeCondominio, 'ND') NomeCondominio
		,B.DataFundacao
		,ISNULL(B.QtdBlocos, 0) QtdBlocos
		,ISNULL(B.Endereco, 'ND') Endereco
		,ISNULL(B.CEP, 'ND') CEP
		,ISNULL(B.Bairro, 'ND') Bairro
		,ISNULL(B.CidadeID, 0) CidadeID
		,ISNULL(B.CidadeNome, 'ND') CidadeNome
		,ISNULL(B.Excluido, 0) CondominioExcluido
	FROM
		TB_PREDIO P
	left join
		UVW_BLOCO B
	ON
		B.BlocoID = P.BlocoID
GO

