IF EXISTS(select * from sys.procedures where name = 'USP_LOGAR_GET')
BEGIN
	DROP PROC USP_LOGAR_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: loga no sistema com filtros base de dados
* Data Criação: 26/11/2017
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

CREATE PROC USP_LOGAR_GET
(
	  @NomeUser VARCHAR(20) = NULL
	 ,@Senha VARCHAR(20) = NULL 
)
AS
BEGIN
	SELECT
		 UsuarioID
		,NomeUser
		,Senha
		,Email
	FROM
		UVW_USUARIO
	WHERE
		 NomeUser = @NomeUser
	AND
		 Senha = @Senha
END
GO
