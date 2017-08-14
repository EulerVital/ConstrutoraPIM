IF EXISTS(select * from sys.views where name = 'UVW_ESTADO')
BEGIN
	DROP VIEW UVW_ESTADO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de estados da base de dados
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

CREATE VIEW UVW_ESTADO
AS
	SELECT
		 Id
		,Name
		,UF
	FROM
		TB_ESTADO 
GO

