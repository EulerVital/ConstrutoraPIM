IF EXISTS(select * from sys.views where name = 'UVW_TELEFONE_MORADOR')
BEGIN
	DROP VIEW UVW_TELEFONE_MORADOR
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de telefone morador da base de dados
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

CREATE VIEW UVW_TELEFONE_MORADOR
AS
	SELECT
		  ISNULL(TelefoneID, 0) TelefoneID
		 ,ISNULL(TM.MoradorID, 0) MoradorID
		 ,M.Nome 
		 ,M.UltimoNome
	FROM
		TB_TELEFONE_MORADOR TM
	JOIN
		UVW_MORADOR M
	ON
		M.MoradorID = TM.MoradorID
GO

