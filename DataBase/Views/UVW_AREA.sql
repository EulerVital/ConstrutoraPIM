IF EXISTS(select * from sys.views where name = 'UVW_AREA')
BEGIN
	DROP VIEW UVW_AREA
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de area na base de dados
* Data Cria��o: 09/11/2017
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

CREATE VIEW UVW_AREA
AS
	SELECT
		 AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ISNULL(ValorArea, 0.0) ValorArea
		,Status
		,ISNULL(A.CondominioID, 0) CondominioID
		,ISNULL(Nome, 'ND') Nome
		,ISNULL(QtdBlocos , 0) QtdBlocos
		,ISNULL(Endereco, 'ND') Endereco
		,ISNULL(CEP, 'ND') CEP
		,ISNULL(Bairro, 'ND') Bairro
		,ISNULL(CidadeID, 0) CidadeID
		,ISNULL(CidadeNome, 'ND') CidadeNome
		,DataFundacao
		,ISNULL(EstadoID, 0) EstadoID
		,ISNULL(EstadoNome, 'ND') EstadoNome
		,ISNULL(UF, 'ND') UF
		,ISNULL(Excluido, 0) Excluido
	FROM
		TB_AREA A
	LEFT JOIN
		dbo.UVW_CONDOMINIO UVC
	ON
		UVC.CondominioID = A.CondominioID


GO