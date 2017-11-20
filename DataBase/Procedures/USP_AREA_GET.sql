IF EXISTS(select * from sys.procedures where name = 'USP_AREA_GET')
BEGIN
	DROP PROC USP_AREA_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de areas com filtros base de dados
* Data Cria��o: 11/11/2017
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

CREATE PROC USP_AREA_GET
(
	  @AreaID INT = NULL
	 ,@IsAreaPaga BIT = NULL
	 ,@CondominioID INT = NULL
)
AS
BEGIN
	SELECT
		 AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
		,CondominioID
		,Nome
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
		,Excluido
	FROM
		UVW_AREA
	WHERE
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 IsAreaPaga = COALESCE(@IsAreaPaga, IsAreaPaga)
		
END
GO