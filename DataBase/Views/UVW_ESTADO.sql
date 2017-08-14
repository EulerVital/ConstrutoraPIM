IF EXISTS(select * from sys.views where name = 'UVW_ESTADO')
BEGIN
	DROP VIEW UVW_ESTADO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de estados da base de dados
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

CREATE VIEW UVW_ESTADO
AS
	SELECT
		 Id
		,Name
		,UF
	FROM
		TB_ESTADO 
GO

