IF EXISTS(select * from sys.procedures where name = 'USP_RESERVAR_AREA_DEL')
BEGIN
	DROP PROC USP_RESERVAR_AREA_DEL
END
GO

CREATE PROC USP_RESERVAR_AREA_DEL
(
	@ReservaAreaID INT  = NULL
)
AS
BEGIN

	--PEGANDO DATA ATUAL
	DECLARE @DataAtual DATE = GETDATE()
	DECLARE @Deletou BIT = 0

	--PEGANDO RESERVAS FEITAS ANTES DA DATA ATUAL E JOGANDO NA TABELA TEMPORARIA
	CREATE TABLE #RESERVAS
	(
		 ReservaAreaID INT
		,AreaID INT
		,HorarioID INT
	)

	IF @ReservaAreaID IS NULL
	BEGIN
		INSERT INTO #RESERVAS
		SELECT
			 RA.ReservaAreaID
			,RA.AreaID
			,HO.HorarioID
		FROM
			UVW_RESERVAR_AREA RA
		JOIN
			UVW_HORARIO HO
		ON
			RA.AreaID = HO.AreaID
		WHERE 
			DataReserva < @DataAtual

		IF (select count(1) from #reservas) > 0
		BEGIN
			SET @Deletou = 1
		END

		--APAGANDO PESSOAS RESPONSAVEIS RELACIONADAS A �REAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID in (select reservaareaid from #reservas) and ResponsavelID IS NULL
		--APAGANDO PESSOAS N�O RESPONSAVEIS RELACIONADAS A �REAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID in (select reservaareaid from #reservas) and ResponsavelID IS NOT NULL
		--APAGANDO PESSOAS N�O RESPONSAVEIS RELACIONADAS A �REAS RESERVADAS
		DELETE FROM TB_RESERVAR_AREA WHERE ReservaAreaID in (select reservaareaid from #reservas)
	END
	ELSE
	BEGIN
		--APAGANDO PESSOAS RESPONSAVEIS RELACIONADAS A �REAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID = @ReservaAreaID and ResponsavelID IS NULL
		--APAGANDO PESSOAS N�O RESPONSAVEIS RELACIONADAS A �REAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID = @ReservaAreaID and ResponsavelID IS NOT NULL
		--APAGANDO PESSOAS N�O RESPONSAVEIS RELACIONADAS A �REAS RESERVADAS
		DELETE FROM TB_RESERVAR_AREA WHERE ReservaAreaID = @ReservaAreaID	
		
		IF (select count(1) from tb_reservar_area where ReservaAreaID = @ReservaAreaID) = 0
		BEGIN
			SET @Deletou = 1	
		END
	END

	SELECT @Deletou Deletou

END
GO