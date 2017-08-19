IF EXISTS(select * from sys.procedures where name = 'USP_PROFISSAO_DEL')
BEGIN
	DROP PROC USP_PROFISSAO_DEL
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: deleta profiss�o da base de dados
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

CREATE PROC USP_PROFISSAO_DEL
(
	 @ProfissaoID INT
)
AS
BEGIN
	DELETE FROM 
		TB_PROFISSAO 
	WHERE 
		ProfissaoID = @ProfissaoID
END
GO