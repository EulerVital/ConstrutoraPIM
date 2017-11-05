IF EXISTS(select * from sys.procedures where name = 'USP_ESTACIONAMENTO_GET')
BEGIN
	DROP PROC USP_ESTACIONAMENTO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de estacionamento com filtros base de dados
* Data Cria��o: 05/09/2017
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

CREATE PROC USP_ESTACIONAMENTO_GET
(
	 @EstacionamentoID INT = NULL
	,@CondominioID INT = NULL
	,@BlocoID INT = NULL
)
AS
BEGIN
	SELECT
		 EstacionamentoID
		,Nome
		,QtdVagas
		,TipoEstacionamento
		,Excluido
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		UVW_ESTACIONAMENTO
	WHERE
		dbo.UVW_ESTACIONAMENTO.EstacionamentoID = COALESCE(@EstacionamentoID, EstacionamentoID)
	AND
		dbo.UVW_ESTACIONAMENTO.CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		dbo.UVW_ESTACIONAMENTO.BlocoID = COALESCE(@BlocoID, BlocoID)
END
GO