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
		,ISNULL(Email, 'ND') Email
		,ISNULL(CaminhoImagem, '') CaminhoImagem
		,UltimoNome
		,ISNULL(M.Nome + '.' + M.UltimoNome, 'ND') LoginSite
		,DataNascimento
		,M.Excluido 
		,IsResponsavel
		,Senha
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
		,A.Excluido ExcluidoBloco
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
		,ISNULL(VE.VagaEstacionamentoID, 0) VagaEstacionamentoID
		,ISNULL(VE.NumeroVaga, 'ND') NumeroVaga
		,ISNULL(VE.TipoVaga, 0) TipoVaga
		,ISNULL(VE.ReservadaAluguel, 0) ReservadaAluguel
		,ISNULL(VE.EstacionamentoID, 0) EstacionamentoID
		,ISNULL(VE.Nome, 'ND') NomeEstacionamento
		,ISNULL(VE.QtdVagas, 0) QtdVagas
		,ISNULL(VE.TipoEstacionamento, 'ND') TipoEstacionamento
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