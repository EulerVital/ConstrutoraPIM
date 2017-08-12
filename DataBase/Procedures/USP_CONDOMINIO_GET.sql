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
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 Nome
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,Excluido
	FROM
		UVW_CONDOMINIO
	WHERE
		 Nome = COALESCE(@Nome, Nome)
	AND
		 QtdBlocos = COALESCE(@QtdBlocos, QtdBlocos)
	AND
		Endereco = COALESCE(@Endereco, Endereco)
	AND
		 CEP = COALESCE(@CEP, CEP)
	AND
		 Bairro = COALESCE(@Bairro, Bairro)
	AND
		 CidadeID = COALESCE(@CidadeID, CidadeID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 Excluido = COALESCE(@Excluido, Excluido)
END
GO