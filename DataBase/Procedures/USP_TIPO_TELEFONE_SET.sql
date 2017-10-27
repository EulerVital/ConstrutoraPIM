IF EXISTS(select * from sys.procedures where name = 'USP_TIPO_TELEFONE_SET')
BEGIN
	DROP PROC USP_TIPO_TELEFONE_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de tipo_telefone na base de dados
* Data Criação: 21/10/2017
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