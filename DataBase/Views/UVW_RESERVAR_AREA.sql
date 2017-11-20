IF EXISTS(select * from sys.views where name = 'UVW_RESERVAR_AREA')
BEGIN
	DROP VIEW UVW_RESERVAR_AREA
END
GO

CREATE VIEW UVW_RESERVAR_AREA
AS
	SELECT
		 RA.ReservaAreaID
		,RA.DataReserva
		,M.MoradorID
		,M.Nome
		,M.RG
		,M.CPF
		,M.Email
		,M.CaminhoImagem
		,M.UltimoNome
		,M.LoginSite
		,M.DataNascimento
		,M.Excluido
		,M.IsResponsavel
		,M.ApartamentoID
		,M.NumeroApartamento
		,M.ValorApartamento
		,M.AndarPredio
		,M.IsCadAutomatico
		,M.TipoEstadiaID
		,M.TipoEstadiaNome
		,M.ValorFixo
		,M.TipoEstadiaExcluido
		,M.PredioID
		,M.NomePredio
		,M.QtdApartamentos
		,M.BlocoID
		,M.NomeBloco
		,M.ExcluidoBloco
		,M.QtdPredios
		,M.TipoBloco
		,M.StatusAtivo
		,M.CondominioID
		,M.NomeCondominio
		,M.DataFundacao
		,M.QtdBlocos
		,M.Endereco
		,M.CEP
		,M.Bairro
		,M.CidadeID
		,M.CidadeNome
		,M.CondominioExcluido
		,M.VagaEstacionamentoID
		,M.NumeroVaga
		,M.TipoVaga
		,M.ReservadaAluguel
		,M.EstacionamentoID
		,M.NomeEstacionamento
		,M.QtdVagas
		,M.TipoEstacionamento
		,A.AreaID
		,A.NomeArea
		,A.TipoArea
		,A.ModoUso
		,A.IsAreaPaga
		,A.ValorArea
		,A.Status
	FROM
		TB_RESERVAR_AREA RA
	LEFT JOIN
		UVW_MORADOR M
	ON
		M.MoradorID = RA.MoradorID
	LEFT JOIN
		UVW_AREA A
	ON
		A.AreaID = RA.AreaID