IF EXISTS(select * from sys.views where name = 'UVW_TIPOESTADIA')
BEGIN
	DROP VIEW UVW_TIPOESTADIA
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de tipo estadia de apartamentos da base de dados
* Data Cria��o: 17/09/2017
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

CREATE VIEW UVW_TIPOESTADIA
AS
	SELECT
		 TipoEstadiaID
		,Nome
		,ISNULL(ValorFixo, 0.00) ValorFixo
		,Excluido
	FROM
		TB_TIPOESTADIA
GO

