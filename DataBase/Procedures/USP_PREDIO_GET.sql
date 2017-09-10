IF EXISTS(select * from sys.procedures where name = 'USP_PREDIO_GET')
BEGIN
	DROP PROC USP_PREDIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de predios com filtros base de dados
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

CREATE PROC USP_PREDIO_GET
(
	 @PredioID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@BlocoID INT = NULL
	,@NomeBloco VARCHAR(150) = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 PredioID
		,Nome
		,QtdApartamentos
		,Excluido
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,DataFundacao
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		UVW_PREDIO
	WHERE
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 NomeBloco = COALESCE(@NomeBloco, NomeBloco)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 NomeCondominio = COALESCE(@NomeCondominio, NomeCondominio)
	AND
		Excluido = COALESCE(@Excluido, Excluido)
END
GO