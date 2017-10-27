IF EXISTS(select * from sys.procedures where name = 'USP_TIPOESTADIA_SET')
BEGIN
	DROP PROC USP_TIPOESTADIA_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de tipo estadia de apartamento na base de dados
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

CREATE PROC USP_TIPOESTADIA_SET
(
	 @TipoEstadiaID INT = 0
	,@Nome VARCHAR(50)
	,@ValorFixo DECIMAL(10,2)
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @TipoEstadiaID = 0
	BEGIN

		IF NOT EXISTS(select * from TB_TIPOESTADIA where Nome = @Nome)
		BEGIN		
			INSERT INTO TB_TIPOESTADIA
			(
				 Nome
				,ValorFixo
				,Excluido
			)SELECT
				 @Nome
				,@ValorFixo
				,@Excluido

			SET @TipoEstadiaID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_TIPOESTADIA SET
			 Nome = @Nome
			,ValorFixo = @ValorFixo
			,Excluido = @Excluido
		WHERE
			TipoEstadiaID = @TipoEstadiaID
	END

	SELECT @TipoEstadiaID

END
GO