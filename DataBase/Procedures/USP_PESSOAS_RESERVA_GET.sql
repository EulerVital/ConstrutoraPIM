IF EXISTS(select * from sys.procedures where name = 'USP_PESSOAS_RESERVA_GET')
BEGIN
	DROP PROC USP_PESSOAS_RESERVA_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de pessoas reserva com filtros base de dados
* Data Criação: 15/11/2017
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

CREATE PROC USP_PESSOAS_RESERVA_GET
(
	 @PessoaReservaID INT = NULL
	,@ReservaAreaID INT = NULL
	,@MoradorID INT = NULL
	,@AreaID INT = NULL
)
AS
BEGIN
	SELECT
		 PessoaReservaID
		,Nome
		,CPF
		,RG
		,IsMenorIdade
		,ResponsavelID
		,NomeResponsavel
		,TipoPagamento
		,ReservaAreaID
		,DataReserva
		,MoradorID
		,NomeMorador
		,RgMorador
		,CpfMorador
		,Email
		,CaminhoImagem
		,UltimoNome
		,LoginSite
		,DataNascimento
		,Excluido
		,IsResponsavel
		,AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		UVW_PESSOAS_RESERVA
	WHERE
		 PessoaReservaID = COALESCE(@PessoaReservaID, PessoaReservaID)
	AND
		 MoradorID = COALESCE(@MoradorID, MoradorID)
	AND
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		ReservaAreaID = COALESCE(@ReservaAreaID, ReservaAreaID)
END
GO