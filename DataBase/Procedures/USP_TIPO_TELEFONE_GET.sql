IF EXISTS(select * from sys.procedures where name = 'USP_TIPO_TELEFONE_GET')
BEGIN
	DROP PROC USP_TIPO_TELEFONE_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de tipo_telefone com filtros base de dados
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