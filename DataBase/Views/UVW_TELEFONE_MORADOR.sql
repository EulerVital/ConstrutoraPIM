IF EXISTS(select * from sys.views where name = 'UVW_TELEFONE_MORADOR')
BEGIN
	DROP VIEW UVW_TELEFONE_MORADOR
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de telefone morador da base de dados
* Data Cria��o: 17/09/2017
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

