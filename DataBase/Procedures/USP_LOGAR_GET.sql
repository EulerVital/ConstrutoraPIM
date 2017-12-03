IF EXISTS(select * from sys.procedures where name = 'USP_LOGAR_GET')
BEGIN
	DROP PROC USP_LOGAR_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: loga no sistema com filtros base de dados
* Data Cria��o: 26/11/2017
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
