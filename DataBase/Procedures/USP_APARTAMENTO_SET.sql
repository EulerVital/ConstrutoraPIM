IF EXISTS(select * from sys.procedures where name = 'USP_APARTAMENTO_SET')
BEGIN
	DROP PROC USP_APARTAMENTO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de apartamento na base de dados
* Data Cria��o: 17/09/2017
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

CREATE PROC USP_APARTAMENTO_SET
(
	 @ApartamentoID INT = 0
	,@NumeroApartamento INT
	,@TipoEstadiaID INT
	,@ValorApartamento DECIMAL(10,2)
	,@AndarPredio INT
	,@PredioID INT = NULL
	,@IsCadAutomatico BIT = NULL
)
AS
BEGIN

	IF @ApartamentoID = 0
	BEGIN
		INSERT INTO TB_APARTAMENTO
		(
			 NumeroApartamento
			,TipoEstadiaID
			,ValorApartamento
			,AndarPredio
			,PredioID
			,IsCadAutomatico
		)SELECT
			 @NumeroApartamento
			,@TipoEstadiaID
			,@ValorApartamento
			,@AndarPredio
			,@PredioID
			,@IsCadAutomatico

		SET @ApartamentoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_APARTAMENTO SET
			 NumeroApartamento = @NumeroApartamento
			,TipoEstadiaID = @TipoEstadiaID
			,ValorApartamento = @ValorApartamento
			,AndarPredio = @AndarPredio
			,PredioID = @PredioID
			,IsCadAutomatico = @IsCadAutomatico
		WHERE
			ApartamentoID = @ApartamentoID
	END

	SELECT @ApartamentoID

END
GO