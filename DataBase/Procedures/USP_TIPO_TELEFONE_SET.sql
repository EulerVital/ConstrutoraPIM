IF EXISTS(select * from sys.procedures where name = 'USP_TIPO_TELEFONE_SET')
BEGIN
	DROP PROC USP_TIPO_TELEFONE_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de tipo_telefone na base de dados
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

CREATE PROC USP_TIPO_TELEFONE_SET
(
	 @TipoTelefoneID INT = 0
	,@Descricao VARCHAR(50) = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN

	IF @TipoTelefoneID = 0 AND (select count(1) from tb_tipo_telefone where Descricao = @Descricao) = 0
	BEGIN
		INSERT INTO TB_TIPO_TELEFONE
		(
			 Descricao
			,Excluido
		)SELECT
			 @Descricao
			,@Excluido

		SET @TipoTelefoneID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_TIPO_TELEFONE SET
			 Descricao = @Descricao
			,Excluido = @Excluido
		WHERE
			TipoTelefoneID = @TipoTelefoneID
	END

	SELECT @TipoTelefoneID

END
GO