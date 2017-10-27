IF EXISTS(select * from sys.tables where name = 'UVW_VAGA_ESTACIONAMENTO')
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
		,ISNULL(ResevadaAluguel, 0) ResevadaAluguel
		,ISNULL(VE.EstacionamentoID, 0) EstacionamentoID
		,Nome
		,QtdVagas
		,TipoEstacionamento
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,DataFundacao
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		TB_VAGA_ESTACIONAMENTO VE
	LEFT JOIN
		UVW_ESTACIONAMENTO E
	ON
		E.EstacionamentoID = VE.EstacionamentoID
GO