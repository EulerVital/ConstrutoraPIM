IF EXISTS(select * from sys.views where name = 'UVW_MORADOR')
BEGIN
	DROP VIEW UVW_MORADOR
END
GO

CREATE VIEW UVW_MORADOR
AS
	SELECT
		 MoradorID
		,ISNULL(M.Nome, 'ND') Nome
		,ISNULL(RG, 'ND') RG
		,ISNULL(CPF, '') CPF
		,ISNULL(Email, 'ND') Emaial
		,ISNULL(CaminhoImagem, '') CaminhoImagem
		,UltimoNome
		,ISNULL(M.Nome + '.' + M.UltimoNome, 'ND') LoginSite
		,DataNascimento
		,A.ApartamentoID
		,A.NumeroApartamento
		,A.ValorApartamento
		,A.AndarPredio
		,A.IsCadAutomatico
		,A.TipoEstadiaID
		,A.TipoEstadiaNome
		,A.ValorFixo
		,A.TipoEstadiaExcluido
		,A.PredioID
		,A.Nome AS NomePredio
		,A.QtdApartamentos
		,A.BlocoID
		,A.NomeBloco
		,A.Excluido
		,A.QtdPredios
		,A.TipoBloco
		,A.StatusAtivo
		,A.CondominioID
		,A.NomeCondominio
		,A.DataFundacao
		,A.QtdBlocos
		,A.Endereco
		,A.CEP
		,A.Bairro
		,A.CidadeID
		,A.CidadeNome
		,A.CondominioExcluido
		,VE.VagaEstacionamentoID
		,VE.NumeroVaga
		,VE.TipoVaga
		,VE.ResevadaAluguel
		,VE.EstacionamentoID
		,VE.Nome NomeEstacionamento
		,VE.QtdVagas 
		,VE.TipoEstacionamento
	FROM
		TB_MORADOR M
	LEFT JOIN
		UVW_VAGA_ESTACIONAMENTO VE
	ON
		M.VagaEstacionamentoID = VE.VagaEstacionamentoID
	LEFT JOIN
		UVW_APARTAMENTO A
	ON
		A.ApartamentoID = M.ApartamentoID
GO