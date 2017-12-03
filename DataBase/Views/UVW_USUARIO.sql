IF EXISTS(select * from sys.views where name = 'UVW_USUARIO')
BEGIN
	DROP VIEW UVW_USUARIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de usuarios na base de dados
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

CREATE VIEW UVW_USUARIO
AS
	SELECT
		 U.UsuarioID
		,U.NomeUser
		,U.Senha
		,U.Email
		,U.TipoUsuario
		,U.Excluido
		,ISNULL(CO.CondominioID, 0) CondominioID
		,ISNULL(CO.Nome, 'ND') NomeCondominio
		,CO.QtdBlocos
		,CO.Endereco
		,CO.CEP
		,CO.Bairro
		,CO.CidadeID
		,CO.CidadeNome
		,CO.DataFundacao
		,CO.EstadoID
		,CO.EstadoNome
		,CO.UF
		,CO.Excluido ExcluidoCondominio
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,B.QtdPredios
		,B.TipoBloco
		,B.StatusAtivo
		,ISNULL(P.PredioID, 0) PredioID
		,ISNULL(P.Nome, 'ND') NomePredio
		,P.QtdApartamentos
	FROM
		TB_USUARIO U
	LEFT JOIN
		UVW_CONDOMINIO CO
	ON
		CO.CondominioID = U.CondominioID
	LEFT JOIN
		UVW_BLOCO B
	ON
		B.BlocoID = U.BlocoID
	LEFT JOIN
		UVW_PREDIO P
	ON
		P.PredioID = U.PredioID