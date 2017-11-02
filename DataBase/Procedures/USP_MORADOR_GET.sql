IF EXISTS(select * from sys.procedures where name = 'USP_MORADOR_GET')
BEGIN
	DROP PROC USP_MORADOR_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Retorna dados de moradores com filtros base de dados
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

CREATE PROC USP_MORADOR_GET
(
	 @MoradorID INT = 0
	,@Nome VARCHAR(100) = NULL
	,@ApartamentoID INT = NULL
	,@VagaEstacionamentoID INT = NULL
)
AS
BEGIN
	SELECT
		 MoradorID
		,Nome
		,RG
		,CPF
		,Emaial
		,CaminhoImagem
		,UltimoNome
		,DataNascimento
		,LoginSite
		,IsResponsavel
		,EstacionamentoID
		,NomeEstacionamento
		,QtdVagas
		,TipoEstacionamento
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
		,Excluido
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
		,ResevadaAluguel
	FROM
		UVW_MORADOR
	WHERE
		 MoradorID = COALESCE(@MoradorID, MoradorID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		ApartamentoID = COALESCE(@ApartamentoID, ApartamentoID)
	AND
		VagaEstacionamentoID = COALESCE(@VagaEstacionamentoID, VagaEstacionamentoID)
END
GO