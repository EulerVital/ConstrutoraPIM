IF EXISTS(select * from sys.procedures where name = 'USP_BLOCO_GET')
BEGIN
	DROP PROC USP_BLOCO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de condominos com filtros base de dados
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

CREATE PROC USP_BLOCO_GET
(
	 @BlocoID INT = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdPredios INT = NULL
	,@TipoBloco CHAR(2) = NULL
	,@StatusAtivo BIT = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
)
AS
BEGIN
	SELECT
		 BlocoID
		,Nome
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,Excluido
	FROM
		UVW_BLOCO
	WHERE
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 QtdPredios = COALESCE(@QtdPredios, QtdPredios)
	AND
		 TipoBloco = COALESCE(@TipoBloco, TipoBloco)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 NomeCondominio = COALESCE(@NomeCondominio, NomeCondominio)
END
GO