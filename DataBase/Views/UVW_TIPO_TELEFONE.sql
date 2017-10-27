IF EXISTS(select * from sys.views where name = 'UVW_TIPO_TELEFONE')
BEGIN
	DROP VIEW UVW_TIPO_TELEFONE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de tipo_telefones da base de dados
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

CREATE VIEW UVW_TIPO_TELEFONE
AS
	SELECT
		 TipoTelefoneID
		,Descricao
		,Excluido
	FROM
		TB_TIPO_TELEFONE
GO

