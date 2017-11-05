IF EXISTS(select * from sys.procedures where name = 'USP_IS_ESTACIONAMENTO_COND_BLOC')
BEGIN
	DROP PROC USP_IS_ESTACIONAMENTO_COND_BLOC
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Verifica se o condominio ou o bloco especificado possui estacionamento
* Data Criação: 05/11/2017
* Autor:Euler Vital
*********************
**Alterações
* Motivo: 
* Data 
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC USP_IS_ESTACIONAMENTO_COND_BLOC
(
	 @CondominioID INT = NULL
	,@BlocoID INT = NULL
)
AS
BEGIN

	SELECT	
		 NomeCondominio
		,CondominioID
		,NomeBloco
		,BlocoID
	FROM	
		UVW_VAGA_ESTACIONAMENTO
	WHERE
		CondominioID = @CondominioID
	AND
		BlocoID = @BlocoID
END
GO