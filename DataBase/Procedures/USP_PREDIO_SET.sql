IF EXISTS(select * from sys.procedures where name = 'USP_PREDIO_SET')
BEGIN
	DROP PROC USP_PREDIO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de predios na base de dados
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

CREATE PROC USP_PREDIO_SET
(
	 @PredioID INT = 0
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@Excluido BIT = 0
	,@BlocoID INT = NULL
)
AS
BEGIN

	IF @PredioID = 0
	BEGIN
		INSERT INTO TB_PREDIO
		(
			 Nome
			,QtdApartamentos
			,BlocoID
			,Excluido
		)SELECT
				@Nome
			,@QtdApartamentos
			,@BlocoID
			,@Excluido

		SET @PredioID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_PREDIO SET
			 Nome = ISNULL(@Nome, Nome)
			,QtdApartamentos = ISNULL(@QtdApartamentos, QtdApartamentos)
			,BlocoID = ISNULL(@BlocoID, BlocoID)
			,Excluido = ISNULL(@Excluido, Excluido)
		WHERE
			PredioID = @PredioID
	END

	SELECT @PredioID

END
GO