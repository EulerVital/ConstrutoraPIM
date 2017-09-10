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
* Motivo:
* Data Criação:
* Autor:
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
)
AS
BEGIN

	IF @EstacionamentoID = 0
	BEGIN
		INSERT INTO TB_ESTACIONAMENTO
		(
			  Nome	
			 ,QtdVagas
			 ,TipoEstacionamento
			 ,CondominioID
			 ,BlocoID
		)SELECT
			 @Nome
			,@QtdVagas
			,@TipoEstacionamento
			,@CondominioID
			,@BlocoID

		SET @EstacionamentoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_ESTACIONAMENTO SET
			 Nome = ISNULL(@Nome, Nome)
			,QtdVagas = ISNULL(@QtdVagas, QtdVagas)
			,TipoEstacionamento = ISNULL(@TipoEstacionamento, TipoEstacionamento)
			,CondominioID = ISNULL(@CondominioID, CondominioID)
			,BlocoID = ISNUll(@BlocoID,BlocoID)
		WHERE
			EstacionamentoID = @EstacionamentoID
	END

	SELECT @EstacionamentoID

END
GO