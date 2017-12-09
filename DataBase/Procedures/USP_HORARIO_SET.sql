IF EXISTS(select * from sys.procedures where name = 'USP_HORARIO_SET')
BEGIN
	DROP PROC USP_HORARIO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de HORARIO na base de dados
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

CREATE PROC USP_HORARIO_SET
(
	 @HorarioID INT = 0
	,@HoraInicio VARCHAR(50)
	,@HoraFim VARCHAR(50) = NULL
	,@Excluido BIT = 0
	,@AreaID INT
	,@Reservado BIT = 0
)
AS
BEGIN

	IF @HORARIOID = 0
	IF (select count(1) from tb_horario where HoraInicio = @HoraInicio and HoraFim = @HoraFim and AreaID = @AreaID) = 0
	BEGIN
		INSERT INTO TB_HORARIO
		(
			 HoraInicio
			,HoraFim
			,Excluido
			,AreaID
			,Reservado
		)SELECT
			 @HoraInicio
			,@HoraFim
			,@Excluido
			,@AreaID
			,@Reservado

		SET @HorarioID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_HORARIO SET
			 HoraInicio = @HoraInicio
			,HoraFim = @HoraFim
			,Excluido = @Excluido
			,AreaID = @AreaID
			,Reservado = @Reservado
		WHERE
			HorarioID = @HorarioID
	END

	SELECT @HorarioID

END
GO