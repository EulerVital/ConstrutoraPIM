IF EXISTS(select * from sys.procedures where name = 'USP_PREDIO_GET')
BEGIN
	DROP PROC USP_PREDIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de predios com filtros base de dados
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

CREATE PROC USP_PREDIO_GET
(
	 @PredioID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@BlocoID INT = NULL
	,@NomeBloco VARCHAR(150) = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
)
AS
BEGIN
	SELECT
		 PredioID
		,Nome
		,QtdApartamentos
		,BlocoID
		,NomeBloco
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
		UVW_PREDIO
	WHERE
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 QtdApartamentos = COALESCE(@QtdApartamentos, QtdApartamentos)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 NomeBloco = COALESCE(@NomeBloco, NomeBloco)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 NomeCondominio = COALESCE(@NomeCondominio, NomeCondominio)
END
GO