IF EXISTS(select * from sys.procedures where name = 'USP_APARTAMENTO_GET')
BEGIN
	DROP PROC USP_APARTAMENTO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de apartamentos com filtros base de dados
* Data Cria��o: 17/09/2017
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

CREATE PROC USP_APARTAMENTO_GET
(
	 @ApartamentoID INT  = NULL
	,@PredioID INT = NULL
	,@NomePredio VARCHAR(100) = NULL
)
AS
BEGIN
	SELECT
		 ApartamentoID
		,NumeroApartamento
		,TipoEstadiaID
		,TipoEstadiaNome
		,ValorFixo
		,IsCadAutomatico
		,TipoEstadiaExcluido
		,AndarPredio
		,ValorApartamento
		,PredioID
		,Nome
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,Excluido
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,DataFundacao
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		UVW_APARTAMENTO
	WHERE
		 ApartamentoID = COALESCE(@ApartamentoID, ApartamentoID)
	AND
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 Nome = COALESCE(@NomePredio, Nome)
END
GO