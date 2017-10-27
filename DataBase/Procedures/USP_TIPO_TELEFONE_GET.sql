IF EXISTS(select * from sys.procedures where name = 'USP_TIPO_TELEFONE_GET')
BEGIN
	DROP PROC USP_TIPO_TELEFONE_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo_telefone com filtros base de dados
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

CREATE PROC USP_TIPO_TELEFONE_GET
(
	 @TipoTelefoneID INT = NULL
)
AS
BEGIN
	SELECT
		 TipoTelefoneID
		,Descricao
		,Excluido
	FROM
		UVW_TIPO_TELEFONE T
	WHERE
		T.TipoTelefoneID = COALESCE(@TipoTelefoneID, T.TipoTelefoneID)
END
GO