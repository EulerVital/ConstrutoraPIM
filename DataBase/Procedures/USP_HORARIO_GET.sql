IF EXISTS(select * from sys.procedures where name = 'USP_HORARIO_GET')
BEGIN
	DROP PROC USP_HORARIO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de Horario com filtros base de dados
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

CREATE PROC USP_HORARIO_GET
(
	  @HorarioID INT = NULL
	 ,@AreaID INT = NULL
	 ,@Reservado BIT = NULL
)
AS
BEGIN
	SELECT
		 HorarioID
		,HoraInicio
		,HoraFim
		,Excluido
		,Reservado
		,AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		UVW_HORARIO
	WHERE
		 HorarioID = COALESCE(@HorarioID, HorarioID)
	AND
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		 Reservado = COALESCE(@Reservado, Reservado)
END
GO