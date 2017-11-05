IF EXISTS(select * from sys.procedures where name = 'USP_VAGA_ESTACIONAMENTO_GET')
BEGIN
	DROP PROC USP_VAGA_ESTACIONAMENTO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de vaga estacionamento com filtros base de dados
* Data Criação: 05/11/2017
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

CREATE PROC USP_VAGA_ESTACIONAMENTO_GET
(
	  @VagaEstacionamentoID INT = NULL
	 ,@EstacionamentoID INT = NULL
)
AS
BEGIN
	SELECT
		 VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ReservadaAluguel
		,EstacionamentoID
		,Excluido
		,Nome
		,QtdVagas
		,TipoEstacionamento
		,ExcluidoEstacionamento
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
		dbo.UVW_VAGA_ESTACIONAMENTO
	WHERE
		VagaEstacionamentoID = COALESCE(@VagaEstacionamentoID, VagaEstacionamentoID)
	AND
		EstacionamentoID = COALESCE(@EstacionamentoID, EstacionamentoID)
END
GO