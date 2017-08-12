IF EXISTS(select * from sys.views where name = 'UVW_PREDIO')
BEGIN
	DROP VIEW UVW_PREDIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de predios da base de dados
* Data Cria��o: 12/08/2017
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

CREATE VIEW UVW_PREDIO
AS
	SELECT
		 P.PredioID
		,P.Nome
		,P.QtdApartamentos
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,B.QtdPredios
		,B.TipoBloco
		,B.StatusAtivo
		,B.CondominioID
		,B.NomeCondominio
		,B.QtdBlocos
		,B.Endereco
		,B.CEP
		,B.Bairro
		,B.CidadeID
		,B.CidadeNome
		,B.Excluido
	FROM
		TB_PREDIO P
	left join
		UVW_BLOCO B
	ON
		B.BlocoID = P.BlocoID
GO

