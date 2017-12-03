IF EXISTS(select * from sys.procedures where name = 'USP_USUARIO_SET')
BEGIN
	DROP PROC USP_USUARIO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de usuário na base de dados
* Data Criação: 25/11/2017
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

CREATE PROC USP_USUARIO_SET 
(
	 @UsuarioID INT = 0
	,@NomeUser VARCHAR(20)
	,@Senha VARCHAR(20)
	,@CondominioID INT = NULL 
	,@TipoUsuario CHAR(1)
	,@Email VARCHAR(200)
	,@BlocoID INT = NULL
	,@PredioID INT = NULL
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @UsuarioID = 0
	BEGIN
		IF(SELECT count(1) FROM tb_usuario WHERE NomeUser = @NomeUser) = 0
		BEGIN 
			INSERT INTO TB_USUARIO
			(
				 NomeUser
				,Senha
				,CondominioID
				,TipoUsuario
				,BlocoID
				,PredioID
				,Excluido
				,Email
			)SELECT
				 @NomeUser
				,@Senha
				,@CondominioID
				,@TipoUsuario
				,@BlocoID
				,@PredioID
				,@Excluido
				,@Email

			SET @UsuarioID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_USUARIO SET
			 NomeUser = @NomeUser
			,Senha = @Senha
			,CondominioID = @CondominioID
			,TipoUsuario = @TipoUsuario
			,BlocoID = @BlocoID
			,PredioID = @PredioID
			,Excluido = @Excluido
			,Email = @Email
		WHERE
			UsuarioID = @UsuarioID
	END

	SELECT @UsuarioID

END
GO