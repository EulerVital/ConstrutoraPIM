IF EXISTS(select * from sys.views where name = 'UVW_TIPO_TELEFONE')
BEGIN
	DROP VIEW UVW_TIPO_TELEFONE
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo_telefones da base de dados
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

CREATE VIEW UVW_TIPO_TELEFONE
AS
	SELECT
		 TipoTelefoneID
		,Descricao
		,Excluido
	FROM
		TB_TIPO_TELEFONE
GO

