IF EXISTS(select * from sys.views where name = 'UVW_TIPOESTADIA')
BEGIN
	DROP VIEW UVW_TIPOESTADIA
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo estadia de apartamentos da base de dados
* Data Criação: 17/09/2017
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

