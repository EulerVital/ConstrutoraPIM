IF EXISTS(select * from sys.procedures where name = 'USP_ESTACIONAMENTO_SET')
BEGIN
	DROP PROC USP_ESTACIONAMENTO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de ESTACIONAMENTO na base de dados
* Data Cria��o: 05/09/2017
* Autor:Rafael Marques
*********************
**Altera��es
* Motivo: Add o campo excluido
* Data Altera��o: 05/11/2017 
* Autor: Euler Vital
*********************
**Altera��es
* Motivo:
* Data Cria��o:
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