IF EXISTS(select * from sys.procedures where name = 'USP_RESERVAR_AREA_GET')
BEGIN
	DROP PROC USP_RESERVAR_AREA_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de reservar area com filtros base de dados
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

CREATE PROC USP_RESERVAR_AREA_GET
(
	 @ReservaAreaID INT = NULL
	,@MoradorID INT = NULL
	,@AreaID INT = NULL
	,@CondominioID INT = NULL
)
AS
BEGIN
	SELECT
		 ReservaAreaID
		,DataReserva
		,MoradorID
		,Nome
		,RG
		,CPF
		,Email
		,CaminhoImagem
		,UltimoNome
		,LoginSite
		,DataNascimento
		,Excluido
		,IsResponsavel
		,ApartamentoID
		,NumeroApartamento
		,ValorApartamento
		,AndarPredio
		,IsCadAutomatico
		,TipoEstadiaID
		,TipoEstadiaNome
		,ValorFixo
		,TipoEstadiaExcluido
		,PredioID
		,NomePredio
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,ExcluidoBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,DataFundacao
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
		,VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ReservadaAluguel
		,EstacionamentoID
		,NomeEstacionamento
		,QtdVagas
		,TipoEstacionamento
		,AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		UVW_RESERVAR_AREA
	WHERE
		 ReservaAreaID = COALESCE(@ReservaAreaID, ReservaAreaID)
	AND
		 MoradorID = COALESCE(@MoradorID, MoradorID)
	AND
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
END
GO
