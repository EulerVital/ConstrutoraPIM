IF EXISTS(select * from sys.views where name = 'UVW_TELEFONE')
BEGIN
	DROP VIEW UVW_TELEFONE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de telefones da base de dados
* Data Cria��o: 21/10/2017
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

CREATE VIEW UVW_TELEFONE
AS
	SELECT
		  T.TelefoneID
		 ,Contato
		 ,T.Excluido
		 ,TT.TipoTelefoneID 
		 ,TT.Descricao TipoTelefone
		 ,TT.Excluido TipoTelefoneExcluido
	FROM
		TB_TELEFONE T
	LEFT JOIN
		UVW_TIPO_TELEFONE TT
	ON
		TT.TipoTelefoneID = T.TipoTelefoneID
GO

