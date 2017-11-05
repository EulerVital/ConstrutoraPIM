IF EXISTS(select * from sys.procedures where name = 'USP_VAGA_ESTACIONAMENTO_SET')
BEGIN
	DROP PROC USP_VAGA_ESTACIONAMENTO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de vaga_estacionamento na base de dados
* Data Criação: 05/11/2017
* Autor:Euler Vital
*********************
**Alterações
* Motivo: 
* Data 
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC USP_VAGA_ESTACIONAMENTO_SET
(
	 @VagaEstacionamentoID INT = 0
	,@NumeroVaga VARCHAR(100)
	,@TipoVaga CHAR(1)
	,@ReservadaAluguel BIT
	,@EstacionamentoID INT
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @VagaEstacionamentoID = 0
	BEGIN
		IF NOT EXISTS(SELECT * FROM dbo.TB_VAGA_ESTACIONAMENTO WHERE NumeroVaga = @NumeroVaga AND EstacionamentoID = @EstacionamentoID)
		BEGIN
			INSERT INTO TB_VAGA_ESTACIONAMENTO
			(
				 NumeroVaga
				,TipoVaga
				,ReservadaAluguel
				,EstacionamentoID
				,Excluido
			)SELECT
				 @NumeroVaga
				,@TipoVaga
				,@ReservadaAluguel
				,@EstacionamentoID
				,@Excluido

			SET @VagaEstacionamentoID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_VAGA_ESTACIONAMENTO SET
			 NumeroVaga = @NumeroVaga
			,TipoVaga = @TipoVaga
			,ReservadaAluguel = @ReservadaAluguel
			,EstacionamentoID = @EstacionamentoID
			,Excluido = @Excluido
		WHERE
			VagaEstacionamentoID = @VagaEstacionamentoID
	END

	SELECT @VagaEstacionamentoID

END
GO