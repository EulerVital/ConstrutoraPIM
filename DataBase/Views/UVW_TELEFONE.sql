IF EXISTS(select * from sys.views where name = 'UVW_TELEFONE')
BEGIN
	DROP VIEW UVW_TELEFONE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de telefones da base de dados
* Data Criação: 21/10/2017
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

