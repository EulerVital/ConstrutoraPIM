IF EXISTS(select * from sys.procedures where name = 'USP_FUNCIONALIDADE_USUARIO_SET')
BEGIN
	DROP PROC USP_FUNCIONALIDADE_USUARIO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de funcionalidade usuario na base de dados
* Data Cria��o: 09/12/2017
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

CREATE PROC USP_FUNCIONALIDADE_USUARIO_SET
(
	 @FuncionalidadeUserID INT = 0
	,@FuncionalidadeID INT
	,@UsuarioID INT
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @FuncionalidadeUserID = 0
	IF (select count(1) from TB_FUNCIONALIDADE_USUARIO where FuncionalidadeID = @FuncionalidadeID and UsuarioID = @UsuarioID and Excluido = 0) = 0
	BEGIN
		INSERT INTO TB_FUNCIONALIDADE_USUARIO
		(
			 FuncionalidadeID
			,UsuarioID
			,Excluido
		)SELECT
			 @FuncionalidadeID
			,@UsuarioID
			,@Excluido

		SET @FuncionalidadeUserID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_FUNCIONALIDADE_USUARIO SET
			 FuncionalidadeID = @FuncionalidadeID
			,UsuarioID = @UsuarioID
			,Excluido = @Excluido
		WHERE
			FuncionalidadeUserID = @FuncionalidadeUserID
	END

	SELECT @FuncionalidadeUserID

END
GO