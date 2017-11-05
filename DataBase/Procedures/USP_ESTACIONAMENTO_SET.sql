IF EXISTS(select * from sys.procedures where name = 'USP_ESTACIONAMENTO_SET')
BEGIN
	DROP PROC USP_ESTACIONAMENTO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de ESTACIONAMENTO na base de dados
* Data Criação: 05/09/2017
* Autor:Rafael Marques
*********************
**Alterações
* Motivo: Add o campo excluido
* Data Alteração: 05/11/2017 
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC USP_ESTACIONAMENTO_SET
(
	 @EstacionamentoID INT = 0
	,@Nome VARCHAR(150)
	,@QtdVagas INT
	,@TipoEstacionamento CHAR(1) = NULL
	,@CondominioID INT = NULL
	,@BlocoID INT = NULL
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @CondominioID = 0
	BEGIN
		SET @CondominioID = NULL
	END 

	IF @BlocoID = 0
	BEGIN
		SET @BlocoID = NULL
	END 

	IF @EstacionamentoID = 0
	BEGIN
		INSERT INTO TB_ESTACIONAMENTO
		(
			  Nome	
			 ,QtdVagas
			 ,TipoEstacionamento
			 ,CondominioID
			 ,BlocoID
			 ,Excluido
		)SELECT
			 @Nome
			,@QtdVagas
			,@TipoEstacionamento
			,@CondominioID
			,@BlocoID
			,@Excluido

		SET @EstacionamentoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_ESTACIONAMENTO SET
			 Nome = @Nome
			,QtdVagas = @QtdVagas
			,TipoEstacionamento = @TipoEstacionamento
			,CondominioID = @CondominioID
			,BlocoID = @BlocoID
			,Excluido = @Excluido 
		WHERE
			EstacionamentoID = @EstacionamentoID
	END

	SELECT @EstacionamentoID

END
GO