IF EXISTS(select * from sys.views where name = 'UVW_FUNCIONALIDADE_USUARIO')
BEGIN
	DROP VIEW UVW_FUNCIONALIDADE_USUARIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de funcionalidade usuarios na base de dados
* Data Cria��o: 27/11/2017
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

CREATE VIEW UVW_FUNCIONALIDADE_USUARIO
AS
	SELECT
		 FU.FuncionarioUser
		,FU.Excluido
		,F.FuncionalidadeID
		,F.Descricao
		,F.AreaFuncionalidade
		,F.Excluido ExcluidoFuncionario
		,U.UsuarioID
		,U.NomeUser
		,U.Senha
		,U.Email
		,U.TipoUsuario
		,U.Excluido ExcluidoUser
		,U.CondominioID
		,U.NomeCondominio
		,U.QtdBlocos
		,U.Endereco
		,U.CEP
		,U.Bairro
		,U.CidadeID
		,U.CidadeNome
		,U.DataFundacao
		,U.EstadoID
		,U.EstadoNome
		,U.UF
		,U.ExcluidoCondominio
	FROM
		TB_FUNCIONALIDADE_USUARIO FU
	JOIN
		UVW_FUNCIONALIDADE F
	ON
		FU.FuncionalidadeID = F.FuncionalidadeID
	JOIN	
		UVW_USUARIO U
	ON
		U.UsuarioID = FU.UsuarioID
GO
