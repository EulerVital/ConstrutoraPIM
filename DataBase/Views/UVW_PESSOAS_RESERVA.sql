IF EXISTS(select * from sys.views where name = 'UVW_PESSOAS_RESERVA')
BEGIN
	DROP VIEW UVW_PESSOAS_RESERVA
END
GO

CREATE VIEW UVW_PESSOAS_RESERVA
AS
	SELECT
		 PA.PessoaReservaID
		,PA.Nome
		,PA.CPF
		,PA.RG
		,PA.IsMenorIdade
		,PA.ResponsavelID
		,PA.TipoPagamento
		,RA.ReservaAreaID
		,RA.DataReserva
		,RA.MoradorID
		,RA.Nome NomeMorador
		,RA.RG RgMorador
		,RA.CPF CpfMorador
		,RA.Email
		,RA.CaminhoImagem
		,RA.UltimoNome
		,RA.LoginSite
		,RA.DataNascimento
		,RA.Excluido
		,RA.IsResponsavel
		,RA.AreaID
		,RA.NomeArea
		,RA.TipoArea
		,RA.ModoUso
		,RA.IsAreaPaga
		,RA.ValorArea
		,RA.Status
	FROM
		TB_PESSOAS_RESERVA PA
	LEFT JOIN
		UVW_RESERVAR_AREA RA
	ON
		RA.ReservaAreaID = PA.ReservaAreaID
	