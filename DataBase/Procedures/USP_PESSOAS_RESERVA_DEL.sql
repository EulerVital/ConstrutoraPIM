IF EXISTS(select * from sys.procedures where name = 'USP_PESSOAS_RESERVA_DEL')
BEGIN
	DROP PROC USP_PESSOAS_RESERVA_DEL
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: deletar dados de pessoas reserva
* Data Cria��o: 20/11/2017
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

CREATE PROC USP_PESSOAS_RESERVA_DEL
(
	 @PessoaReservaID INT
)
AS
BEGIN
	DELETE 
	FROM 
		TB_PESSOAS_RESERVA 
	WHERE 
		PessoaReservaID = @PessoaReservaID

	DECLARE @Deletou BIT = 0

	IF(select count(1) from tb_pessoas_reserva where pessoaReservaID = @PessoaReservaID) = 0 
	BEGIN
		SET @Deletou = 1
	END

	SELECT @Deletou Deletou
END
GO