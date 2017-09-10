IF EXISTS(select * from sys.procedures where name = 'USP_CONDOMINIO_GET')
BEGIN
	DROP PROC USP_CONDOMINIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de condominos com filtros base de dados
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

CREATE PROC USP_CONDOMINIO_GET
(
	 @CondominioID INT = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdBlocos INT = NULL
	,@Endereco VARCHAR(300) = NULL
	,@CEP VARCHAR(20) = NULL
	,@Bairro VARCHAR(100) = NULL
	,@CidadeID INT = NULL
	,@DataFundacao DATE = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 CondominioID
		,Nome
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,EstadoID
		,EstadoNome
		,UF
		,Excluido
		,DataFundacao
	FROM
		UVW_CONDOMINIO
	WHERE
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 Nome = COALESCE(@Nome, Nome)
END
GO