IF EXISTS(select * from sys.views where name = 'UVW_VAGA_ESTACIONAMENTO')
BEGIN
	DROP VIEW UVW_VAGA_ESTACIONAMENTO
END
GO

CREATE VIEW UVW_VAGA_ESTACIONAMENTO
AS
	SELECT
		 VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ISNULL(ReservadaAluguel, 0) ReservadaAluguel
		,ISNULL(VE.EstacionamentoID, 0) EstacionamentoID
		,VE.Excluido
		,E.Nome
		,E.QtdVagas
		,E.TipoEstacionamento
		,E.Excluido AS ExcluidoEstacionamento
		,E.BlocoID
		,E.NomeBloco
		,E.QtdPredios
		,E.TipoBloco
		,E.StatusAtivo
		,E.CondominioID
		,E.NomeCondominio
		,E.QtdBlocos
		,E.DataFundacao
		,E.Endereco
		,E.CEP
		,E.Bairro
		,E.CidadeID
		,E.CidadeNome
		,E.CondominioExcluido
	FROM
		TB_VAGA_ESTACIONAMENTO VE
	LEFT JOIN
		UVW_ESTACIONAMENTO E
	ON
		E.EstacionamentoID = VE.EstacionamentoID