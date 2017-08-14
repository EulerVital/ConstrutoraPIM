IF EXISTS(select * from sys.views where name = 'UVW_CIDADE')
BEGIN
	DROP VIEW UVW_CIDADE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de cidades da base de dados
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

CREATE VIEW UVW_CIDADE
AS
	SELECT
		 C.Id
		,C.Name Nome
		,ISNULL(C.EstadoID, 0) EstadoID
		,ISNULL(E.Name, 'ND') EstadoNome
		,ISNULL(E.UF, 'ND') UF
	FROM
		TB_CIDADE C
	left join
		UVW_ESTADO E
	ON
		E.Id = C.EstadoID
GO

