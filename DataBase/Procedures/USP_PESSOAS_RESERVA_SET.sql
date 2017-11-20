IF EXISTS(select * from sys.procedures where name = 'USP_PESSOAS_RESERVA_SET')
BEGIN
	DROP PROC USP_PESSOAS_RESERVA_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de pessoa reserva na base de dados
* Data Criação: 15/11/2017
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

CREATE PROC USP_PESSOAS_RESERVA_SET
(
	 @PessoaReservaID INT = 0
	,@Nome VARCHAR(200)
	,@CPF VARCHAR(50) = NULL
	,@RG VARCHAR(50) = NULL
	,@IsMenorIdade BIT = 0
	,@ResponsavelID  INT = NULL
	,@TipoPagamento VARCHAR(200) = NULL
	,@ReservaAreaID INT
)
AS
BEGIN

	IF @PessoaReservaID = 0
	BEGIN
		IF(select count(1) from TB_PESSOAS_RESERVA where CPF = @CPF and ReservaAreaID = @ReservaAreaID) = 0
		BEGIN
			INSERT INTO TB_PESSOAS_RESERVA
			(
				 Nome
				,CPF
				,RG
				,IsMenorIdade
				,ResponsavelID
				,TipoPagamento
				,ReservaAreaID
			)SELECT
			     @Nome
				,@CPF
				,@RG
				,@IsMenorIdade
				,@ResponsavelID
				,@TipoPagamento
				,@ReservaAreaID

			SET @PessoaReservaID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_PESSOAS_RESERVA SET
			 Nome = @Nome
			,CPF = @CPF
			,RG = @RG
			,IsMenorIdade = @IsMenorIdade
			,ResponsavelID = @ResponsavelID
			,TipoPagamento = @TipoPagamento
			,ReservaAreaID = @ReservaAreaID
		WHERE
			PessoaReservaID = @PessoaReservaID
	END

	SELECT @PessoaReservaID

END
GO