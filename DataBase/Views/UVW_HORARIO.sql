IF EXISTS(select * from sys.views where name = 'UVW_HORARIO')
BEGIN
	DROP VIEW UVW_HORARIO
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de Horario na base de dados
* Data Criação: 11/11/2017
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

CREATE VIEW UVW_HORARIO
AS
	SELECT
		 HorarioID
		,HoraInicio
		,HoraFim
		,H.Excluido
		,H.Reservado
		,UVA.AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		TB_HORARIO H
	LEFT JOIN
		dbo.UVW_AREA UVA
	ON
		UVA.AreaID = H.AreaID
GO