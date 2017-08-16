IF EXISTS(select * from sys.views where name = 'UVW_BLOCO')
BEGIN
	DROP VIEW UVW_BLOCO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de blocos na base de dados
* Data Criação: 12/08/2017
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

CREATE VIEW UVW_BLOCO
AS
	SELECT
		 B.BlocoID
		,B.Nome
		,B.QtdPredios
		,B.TipoBloco
		,B.StatusAtivo
		,ISNULL(C.BlocoID, 0) BlocoID
		,C.Nome NomeBLOCO
		,C.QtdBlocos
		,C.Endereco
		,C.CEP
		,C.Bairro
		,C.CidadeID
		,C.CidadeNome
		,C.Excluido
	FROM
		TB_BLOCO B
	left join
		UVW_BLOCO C
	ON
		B.BlocoID = C.BlocoID
GO

