IF EXISTS(select * from sys.procedures where name = 'USP_PROFISSAO_DEL')
BEGIN
	DROP PROC USP_PROFISSAO_DEL
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: deleta profissão da base de dados
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