IF EXISTS(select * from sys.procedures where name = 'USP_CONDOMINIO_SET')
BEGIN
	DROP PROC USP_CONDOMINIO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de condominos na base de dados
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

CREATE PROC USP_CONDOMINIO_SET
(
	 @CondominioID INT = 0
	,@Nome VARCHAR(150)
	,@QtdBlocos INT 
	,@Endereco VARCHAR(300) = NULL
	,@CEP VARCHAR(20) = NULL
	,@Bairro VARCHAR(100) = NULL
	,@CidadeID INT = NULL
	,@DataFundacao DATE = NULL
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @CondominioID = 0
	BEGIN
		IF(select count(1) from TB_CONDOMINIO where Nome = @Nome and CEP = @CEP) = 0
		BEGIN
			INSERT INTO TB_CONDOMINIO
			(
				 Nome
				,QtdBlocos
				,Endereco
				,CEP
				,Bairro
				,CidadeID
				,Excluido
				,DataFundacao
			)SELECT
				 @Nome
				,@QtdBlocos
				,@Endereco
				,@CEP
				,@Bairro
				,@CidadeID
				,@Excluido
				,@DataFundacao

			SET @CondominioID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_CONDOMINIO SET
			 Nome = ISNULL(@Nome, Nome)
			,QtdBlocos = ISNULL(@QtdBlocos, QtdBlocos)
			,Endereco = ISNULL(@Endereco, Endereco)
			,CEP = ISNULL(@CEP, CEP)
			,Bairro = ISNULL(@Bairro, Bairro)
			,CidadeID = ISNULL(@CidadeID, CidadeID)
			,Excluido = ISNULL(@Excluido, Excluido)
		WHERE
			CondominioID = @CondominioID
	END

	SELECT @CondominioID

END
GO