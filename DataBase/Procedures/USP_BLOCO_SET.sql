IF EXISTS(select * from sys.procedures where name = 'USP_BLOCO_SET')
BEGIN
	DROP PROC USP_BLOCO_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de BLOCO na base de dados
* Data Criação: 12/08/2017
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
			 Nome = ISNULL(@Nome, Nome)
			,QtdPredios = ISNULL(@QtdPredios, QtdPredios)
			,CondominioID = ISNULL(@CondominioID, CondominioID)
			,TipoBloco = ISNULL(@TipoBloco, TipoBloco)
			,StatusAtivo = ISNULL(@StatusAtivo, StatusAtivo)
		WHERE
			BlocoID = @BlocoID
	END

	SELECT @BlocoID

END
GO