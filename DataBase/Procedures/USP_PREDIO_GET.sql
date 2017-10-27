IF EXISTS(select * from sys.procedures where name = 'USP_PREDIO_GET')
BEGIN
	DROP PROC USP_PREDIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de predios com filtros base de dados
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

CREATE PROC USP_PREDIO_GET
(
	 @PredioID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@BlocoID INT = NULL
	,@NomeBloco VARCHAR(150) = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 PredioID
		,Nome
		,QtdApartamentos
		,Excluido
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,DataFundacao
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		UVW_PREDIO
	WHERE
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
END
GO