IF EXISTS(select * from sys.procedures where name = 'USP_FUNCIONALIDADE_USUARIO_GET')
BEGIN
	DROP PROC USP_FUNCIONALIDADE_USUARIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de funcionalidade usuario com filtros base de dados
* Data Criação: 29/11/2017
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

CREATE PROC USP_FUNCIONALIDADE_USUARIO_GET
(
	 @FuncionalidadeUserID INT = NULL
	,@FuncionalidadeID INT = NULL
	,@UsuarioID INT = NULL
	,@Codigo INT = NULL
)
AS
BEGIN
	SELECT DISTINCT
		 FuncionalidadeUserID
		,Excluido
		,FuncionalidadeID
		,Descricao
		,AreaFuncionalidade
		,Excluido ExcluidoFuncionalidade
		,Codigo
		,UsuarioID
		,NomeUser
		,Senha
		,Email
		,TipoUsuario
		,Excluido ExcluidoUser
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
	FROM
		UVW_FUNCIONALIDADE_USUARIO F
	WHERE
		FuncionalidadeUserID = COALESCE(@FuncionalidadeUserID, FuncionalidadeUserID)
	AND
		FuncionalidadeID = COALESCE(@FuncionalidadeID, FuncionalidadeID)
	AND
		UsuarioID = COALESCE(@UsuarioID, UsuarioID)
END
GO