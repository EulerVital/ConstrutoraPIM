IF EXISTS(select * from sys.views where name = 'UVW_ESTACIONAMENTO')
BEGIN
	DROP VIEW UVW_ESTACIONAMENTO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de Estacionamento da base de dados
* Data Criação: 05/09/2017
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

CREATE VIEW UVW_ESTACIONAMENTO
AS
	SELECT
		 E.EstacionamentoID
		,E.Nome
		,E.QtdVagas
		,ISNULL(TipoEstacionamento, 'ND') TipoEstacionamento
		,E.Excluido
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,ISNULL(B.QtdPredios, 0) QtdPredios
		,ISNULL(B.TipoBloco, 'ND') TipoBloco
		,ISNULL(B.StatusAtivo, 0) StatusAtivo
		,ISNULL(C.CondominioID, 0) CondominioID
		,ISNULL(C.Nome, 'ND') NomeCondominio
		,ISNULL(C.QtdBlocos, 0) QtdBlocos
		,C.DataFundacao
		,ISNULL(C.Endereco, 'ND') Endereco
		,ISNULL(C.CEP, 'ND') CEP
		,ISNULL(C.Bairro, 'ND') Bairro
		,ISNULL(C.CidadeID, 0) CidadeID
		,ISNULL(C.CidadeNome, 'ND') CidadeNome
		,ISNULL(C.Excluido, 0) CondominioExcluido
	FROM
		TB_ESTACIONAMENTO E
	left join
		UVW_BLOCO B
	ON
		B.BlocoID = E.BlocoID
	left join 
		UVW_CONDOMINIO C
     ON
		C.CondominioID = E.CondominioID
GO

