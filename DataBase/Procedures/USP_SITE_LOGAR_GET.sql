IF EXISTS(select * from sys.procedures where name = 'USP_SITE_LOGAR_GET')
BEGIN
	DROP PROC USP_SITE_LOGAR_GET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Logora no site
* Data Cria��o: 02/12/2017
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

CREATE PROC USP_SITE_LOGAR_GET
(
	 @Login VARCHAR(200)
	,@Senha VARCHAR(200)
)
AS
BEGIN
	SELECT
		 MoradorID
		,Nome
		,RG
		,CPF
		,Email
		,CaminhoImagem
		,UltimoNome
		,LoginSite
		,DataNascimento
		,IsResponsavel
		,Senha
		,Excluido
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
	FROM
		UVW_MORADOR
	WHERE
		 UPPER(LoginSite) = UPPER(@Login)
	AND
		Senha = REPLACE(REPLACE(@Senha, '.',''), '-','')
END
GO