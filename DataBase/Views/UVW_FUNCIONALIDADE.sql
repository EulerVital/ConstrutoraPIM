IF EXISTS(select * from sys.views where name = 'UVW_FUNCIONALIDADE')
BEGIN
	DROP VIEW UVW_FUNCIONALIDADE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de funcionalidades na base de dados
* Data Criação: 27/11/2017
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
