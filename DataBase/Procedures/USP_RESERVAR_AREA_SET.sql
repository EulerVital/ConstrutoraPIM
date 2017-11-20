IF EXISTS(select * from sys.procedures where name = 'USP_RESERVAR_AREA_SET')
BEGIN
	DROP PROC USP_RESERVAR_AREA_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de reserva area na base de dados
* Data Cria��o: 15/11/2017
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

CREATE PROC USP_RESERVAR_AREA_SET 
(
	 @ReservaAreaID INT = 0
	,@DataReserva DATE = NULL
	,@MoradorID INT
	,@AreaID INT 
)
AS
BEGIN

	IF @ReservaAreaID = 0
	BEGIN
		IF(select count(1) from TB_RESERVAR_AREA ra join tb_horario h on h.areaid = ra.areaid where MoradorID = @MoradorID and ra.AreaID = @AreaID and dataReserva = @DataReserva and h.reservado = 0) = 0
		BEGIN 
			INSERT INTO TB_RESERVAR_AREA
			(
				 DataReserva
				,MoradorID
				,AreaID
			)SELECT
				@DataReserva
			   ,@MoradorID
			   ,@AreaID

			SET @ReservaAreaID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_RESERVAR_AREA SET
			 DataReserva = @DataReserva
			,MoradorID = @MoradorID
			,AreaID = @AreaID
		WHERE
			ReservaAreaID = @ReservaAreaID
	END

	SELECT @ReservaAreaID

END
GO