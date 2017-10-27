IF EXISTS(select * from sys.procedures where name = 'USP_TELEFONE_SET')
BEGIN
	DROP PROC USP_TELEFONE_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de telefone na base de dados
* Data Cria��o: 21/10/2017
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

CREATE PROC USP_TELEFONE_SET
(
	 @TelefoneID INT = 0
	,@Contato VARCHAR(150) = NULL
	,@TipoTelefoneID INT = NULL
	,@Excluido BIT = NULL
	,@MoradorID INT
)
AS
BEGIN

	DECLARE @contact INT = (select TOP 1 TelefoneID from tb_telefone where Contato = @Contato)

	IF @MoradorID IS NOT NULL
	BEGIN
		IF @TelefoneID = 0
		BEGIN
			IF @contact IS NULL
			BEGIN
				INSERT INTO TB_TELEFONE
				(
					 Contato
					,TipoTelefoneID
					,Excluido
				)SELECT
					 @Contato
					,@TipoTelefoneID
					,@Excluido

				SET @TelefoneID = @@IDENTITY

				INSERT INTO TB_TELEFONE_MORADOR
				SELECT
					 @TelefoneID
					,@MoradorID
			END
			ELSE
			BEGIN
				INSERT INTO TB_TELEFONE_MORADOR
				SELECT
					 @contact
					,@MoradorID
			END
		END
		ELSE
		BEGIN
			UPDATE TB_TELEFONE SET
				 Contato = @Contato
				,TipoTelefoneID = @TipoTelefoneID
				,Excluido = @Excluido
			WHERE
				TelefoneID = @TelefoneID
		END
	END

	SELECT @TelefoneID

END
GO