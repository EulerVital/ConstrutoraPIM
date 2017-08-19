IF EXISTS(select * from sys.procedures where name = 'USP_PROFISSAO_SET')
BEGIN
	DROP PROC USP_PROFISSAO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de profissão na base de dados
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

CREATE PROC USP_PROFISSAO_SET
(
	 @ProfissaoID INT = 0
	,@Nome VARCHAR(150) = NULL
	,@Area VARCHAR(150) = NULL
	,@Descricao VARCHAR(300) = NULL
)
AS
BEGIN

	IF @ProfissaoID = 0
	BEGIN
		IF(select count(1) from TB_PROFISSAO where Nome = @Nome and Area = @Area) = 0
		BEGIN
			INSERT INTO TB_PROFISSAO
			(
				 Nome
				,Area
				,Descricao
			)SELECT
				 @Nome
				,@Area
				,@Descricao

			SET @ProfissaoID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_PROFISSAO SET
			 Nome = @Nome
			,Area = @Area
			,Descricao = @Descricao
		WHERE
			ProfissaoID = @ProfissaoID
	END

	SELECT @ProfissaoID

END
GO