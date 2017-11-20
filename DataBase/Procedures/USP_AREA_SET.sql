IF EXISTS(select * from sys.procedures where name = 'USP_AREA_SET')
BEGIN
	DROP PROC USP_AREA_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de area na base de dados
* Data Criação: 09/11/2017
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

CREATE PROC USP_AREA_SET
(
	 @AreaID INT = 0
	,@NomeArea VARCHAR(100)
	,@TipoArea VARCHAR(50)
	,@ModoUso CHAR(2)
	,@IsAreaPaga BIT
	,@ValorArea DECIMAL = NULL
	,@Status BIT
	,@CondominioID INT = NULL
)
AS
BEGIN

	IF @AREAID = 0
	BEGIN
		INSERT INTO TB_AREA
		(
			 NomeArea
			,TipoArea
			,ModoUso
			,IsAreaPaga
			,ValorArea
			,Status
			,CondominioID
		)SELECT
			 @NomeArea
			,@TipoArea
			,@ModoUso
			,@IsAreaPaga
			,@ValorArea
			,@Status
			,@CondominioID

		SET @AreaID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_AREA SET
			 NomeArea = @NomeArea
			,TipoArea = @TipoArea
			,ModoUso = @ModoUso
			,IsAreaPaga = @IsAreaPaga
			,ValorArea = @ValorArea
			,Status = @Status
			,CondominioID = @CondominioID
		WHERE
			AREAID = @AREAID
	END

	SELECT @AreaID

END
GO