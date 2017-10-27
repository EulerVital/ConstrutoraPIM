IF EXISTS(select * from sys.procedures where name = 'USP_BLOCO_SET')
BEGIN
	DROP PROC USP_BLOCO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de BLOCO na base de dados
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

CREATE PROC USP_BLOCO_SET
(
	 @BlocoID INT = 0
	,@Nome VARCHAR(150) = NULL
	,@QtdPredios INT = NULL
	,@CondominioID INT = NULL
	,@TipoBloco CHAR(2) = NULL
	,@StatusAtivo BIT = NULL
)
AS
BEGIN
	
	IF @CondominioID = 0
	BEGIN
		SET @CondominioID = NULL
	END

	IF @BlocoID = 0
	BEGIN
		INSERT INTO TB_BLOCO
		(
				Nome
			,QtdPredios
			,CondominioID
			,TipoBloco
			,StatusAtivo
		)SELECT
			 @Nome
			,@QtdPredios
			,@CondominioID
			,@TipoBloco
			,@StatusAtivo

		SET @BlocoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_BLOCO SET
			 Nome = @Nome
			,QtdPredios = @QtdPredios
			,CondominioID = @CondominioID
			,TipoBloco = @TipoBloco
			,StatusAtivo = @StatusAtivo
		WHERE
			BlocoID = @BlocoID
	END

	SELECT @BlocoID

END
GO