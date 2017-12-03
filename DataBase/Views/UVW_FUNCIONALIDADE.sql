IF EXISTS(select * from sys.views where name = 'UVW_FUNCIONALIDADE')
BEGIN
	DROP VIEW UVW_FUNCIONALIDADE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de funcionalidades na base de dados
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

CREATE VIEW UVW_FUNCIONALIDADE
AS
	SELECT
		 FuncionalidadeID
		,Descricao
		,AreaFuncionalidade
		,Codigo
		,Excluido
	FROM
		TB_FUNCIONALIDADE U
GO
