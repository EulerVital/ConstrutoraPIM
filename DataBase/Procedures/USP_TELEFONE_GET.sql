IF EXISTS(select * from sys.procedures where name = 'USP_TELEFONE_GET')
BEGIN
	DROP PROC USP_TELEFONE_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de telefone com filtros base de dados
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

CREATE PROC USP_TELEFONE_GET
(
	 @TelefoneID INT = NULL
	,@TipoTelefoneID VARCHAR(150) = NULL
	,@Contato VARCHAR(50) = NULL
	,@MoradorID INT = NULL
)
AS
BEGIN
	SELECT DISTINCT
		 T.TelefoneID
		,Contato
		,ISNULL(Excluido, 0) Excluido
		,ISNULL(TipoTelefoneID, 0) TipoTelefoneID
		,ISNULL(TipoTelefone, 'ND') TipoTelefone
		,ISNULL(TipoTelefoneExcluido, 0) TipoTelefoneExcluido
		,TM.MoradorID
		,TM.Nome
		,TM.UltimoNome
	FROM
		UVW_TELEFONE T
	JOIN
		UVW_TELEFONE_MORADOR TM
	ON
		T.TelefoneID = TM.TelefoneID
	WHERE
		T.TelefoneID = COALESCE(@TelefoneID, T.TelefoneID)
	AND
		Contato = COALESCE(@Contato, Contato)
	AND
		TipoTelefoneID = COALESCE(@TipoTelefoneID, TipoTelefoneID)
	AND 
		TM.MoradorID = COALESCE(@MoradorID, TM.MoradorID)
END
GO