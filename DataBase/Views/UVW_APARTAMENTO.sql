IF EXISTS(select * from sys.views where name = 'UVW_APARTAMENTO')
BEGIN
	DROP VIEW UVW_APARTAMENTO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de apartamentos da base de dados
* Data Criação: 17/09/2017
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

CREATE VIEW UVW_APARTAMENTO
AS
	SELECT
		 ApartamentoID
		,NumeroApartamento
		,ValorApartamento
		,AndarPredio
		,A.IsCadAutomatico
		,TE.TipoEstadiaID
		,TE.Nome TipoEstadiaNome
		,TE.ValorFixo
		,TE.Excluido TipoEstadiaExcluido
		,ISNULL(P.PredioID, 0) PredioID
		,ISNULL(P.Nome, 'ND') Nome
		,ISNULL(P.QtdApartamentos, 0) QtdApartamentos
		,ISNULL(P.BlocoID, 0) BlocoID
		,ISNULL(P.Nome, 'ND') NomeBloco
		,P.Excluido 
		,ISNULL(P.QtdPredios, 0) QtdPredios
		,ISNULL(P.TipoBloco, 'ND') TipoBloco
		,ISNULL(P.StatusAtivo, 0) StatusAtivo
		,ISNULL(P.CondominioID, 0) CondominioID
		,ISNULL(P.NomeCondominio, 'ND') NomeCondominio
		,P.DataFundacao
		,ISNULL(P.QtdBlocos, 0) QtdBlocos
		,ISNULL(P.Endereco, 'ND') Endereco
		,ISNULL(P.CEP, 'ND') CEP
		,ISNULL(P.Bairro, 'ND') Bairro
		,ISNULL(P.CidadeID, 0) CidadeID
		,ISNULL(P.CidadeNome, 'ND') CidadeNome
		,ISNULL(P.Excluido, 0) CondominioExcluido
	FROM
		TB_APARTAMENTO A
	left join
		UVW_PREDIO P
	ON
		A.PredioID = P.PredioID
	left join
		UVW_TIPOESTADIA TE
	ON
		A.TipoEstadiaID = TE.TipoEstadiaID
GO

