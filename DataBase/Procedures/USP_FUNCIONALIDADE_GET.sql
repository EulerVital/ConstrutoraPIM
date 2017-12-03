IF EXISTS(select * from sys.procedures where name = 'USP_FUNCIONALIDADE_GET')
BEGIN
	DROP PROC USP_FUNCIONALIDADE_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de funcionalidade com filtros base de dados
* Data Cria��o: 29/11/2017
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

CREATE PROC USP_FUNCIONALIDADE_GET
(
	 @FuncionalidadeID INT = NULL
	,@AreaFuncionalidade VARCHAR(150) = NULL
	,@Codigo INT = NULL
)
AS
BEGIN
	SELECT DISTINCT
		 FuncionalidadeID
		,Descricao
		,AreaFuncionalidade
		,Codigo
		,Excluido
	FROM
		UVW_FUNCIONALIDADE F
	WHERE
		F.FuncionalidadeID = COALESCE(@FuncionalidadeID, F.FuncionalidadeID)
	AND
		F.AreaFuncionalidade = COALESCE(@AreaFuncionalidade, F.AreaFuncionalidade)
	AND
		Codigo = COALESCE(@Codigo, Codigo)
END
GO