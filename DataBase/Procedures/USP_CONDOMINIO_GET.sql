IF EXISTS(select * from sys.procedures where name = 'USP_CONDOMINIO_GET')
BEGIN
	DROP PROC USP_CONDOMINIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de condominos com filtros base de dados
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