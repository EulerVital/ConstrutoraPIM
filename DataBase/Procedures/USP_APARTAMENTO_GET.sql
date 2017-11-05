IF EXISTS(select * from sys.procedures where name = 'USP_APARTAMENTO_GET')
BEGIN
	DROP PROC USP_APARTAMENTO_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de apartamentos com filtros base de dados
* Data Criação: 17/09/2017
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

CREATE PROC USP_APARTAMENTO_GET
(
	 @ApartamentoID INT  = NULL
	,@PredioID INT = NULL
	,@NomePredio VARCHAR(100) = NULL
	,@IsApartamentoSemMorador BIT = NULL
)
AS
BEGIN
	
	IF @IsApartamentoSemMorador IS NULL
	BEGIN
		SELECT
			 A.ApartamentoID
			,A.NumeroApartamento
			,A.TipoEstadiaID
			,A.TipoEstadiaNome
			,A.ValorFixo
			,A.IsCadAutomatico
			,A.TipoEstadiaExcluido
			,A.AndarPredio
			,A.ValorApartamento
			,A.PredioID
			,A.Nome
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
		FROM
			UVW_APARTAMENTO A
		WHERE
			 A.ApartamentoID = COALESCE(@ApartamentoID, A.ApartamentoID)
		AND
			 A.PredioID = COALESCE(@PredioID, A.PredioID)
		AND
			 A.Nome = COALESCE(@NomePredio, A.Nome)
	END
	ELSE IF @IsApartamentoSemMorador = 1
	BEGIN
			SELECT
			 A.ApartamentoID
			,A.NumeroApartamento
			,A.TipoEstadiaID
			,A.TipoEstadiaNome
			,A.ValorFixo
			,A.IsCadAutomatico
			,A.TipoEstadiaExcluido
			,A.AndarPredio
			,A.ValorApartamento
			,A.PredioID
			,A.Nome
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
			,M.MoradorID
		FROM
			UVW_APARTAMENTO A
		LEFT JOIN
			dbo.UVW_MORADOR M
		ON
			A.ApartamentoID = M.ApartamentoID
		WHERE
			 A.ApartamentoID = COALESCE(@ApartamentoID, A.ApartamentoID)
		AND
			 A.PredioID = COALESCE(@PredioID, A.PredioID)
		AND
			 A.Nome = COALESCE(@NomePredio, A.Nome)
		AND
			M.MoradorID IS NULL
	END
	ELSE
	BEGIN
			SELECT
			 A.ApartamentoID
			,A.NumeroApartamento
			,A.TipoEstadiaID
			,A.TipoEstadiaNome
			,A.ValorFixo
			,A.IsCadAutomatico
			,A.TipoEstadiaExcluido
			,A.AndarPredio
			,A.ValorApartamento
			,A.PredioID
			,A.Nome
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
			,M.MoradorID
		FROM
			UVW_APARTAMENTO A
		RIGHT JOIN
			dbo.UVW_MORADOR M
		ON
			A.ApartamentoID = M.ApartamentoID
		WHERE
			 A.ApartamentoID = COALESCE(@ApartamentoID, A.ApartamentoID)
		AND
			 A.PredioID = COALESCE(@PredioID, A.PredioID)
		AND
			 A.Nome = COALESCE(@NomePredio, A.Nome)
	END
END
GO