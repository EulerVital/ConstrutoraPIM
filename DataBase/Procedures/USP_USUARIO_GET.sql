IF EXISTS(select * from sys.procedures where name = 'USP_USUARIO_GET')
BEGIN
	DROP PROC USP_USUARIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de usuario com filtros base de dados
* Data Cria��o: 25/11/2017
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

CREATE PROC USP_USUARIO_GET
(
	 @UsuarioID INT = NULL
	,@CondominioID INT = NULL
	,@BlocoID INT = NULL
	,@PredioID INT = NULL
)
AS
BEGIN
	SELECT
		 UsuarioID
		,NomeUser
		,Senha
		,Email
		,TipoUsuario
		,Excluido
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,DataFundacao
		,EstadoID
		,EstadoNome
		,UF
		,ExcluidoCondominio
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,PredioID
		,NomePredio
		,QtdApartamentos
	FROM
		UVW_USUARIO
	WHERE
		 UsuarioID = COALESCE(@UsuarioID, UsuarioID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 PredioID = COALESCE(@PredioID, PredioID)
END
GO
