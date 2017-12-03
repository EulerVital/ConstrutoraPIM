IF EXISTS(select * from sys.procedures where name = 'USP_MORADOR_SET')
BEGIN
	DROP PROC USP_MORADOR_SET
END
GO

/*
--- CONSTRUTORA PIM ----
**CRIA��O
* Motivo: Faz a inser��o/altera��o de moradores na base de dados
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

CREATE PROC USP_MORADOR_SET
(
	 @MoradorID INT = 0
	,@Nome VARCHAR(100)
	,@RG VARCHAR(20) = NULL
	,@CPF VARCHAR(20) = NULL
	,@Email VARCHAR(200) = NULL
	,@CaminhoImagem VARCHAR(MAX) = NULL
	,@ApartamentoID INT = NULL
	,@UltimoNome VARCHAR(50) = NULL
	,@DataNascimento DATE
	,@VagaEstacionamentoID INT = NULL
	,@IsResponsavel BIT = 0
	,@Excluido BIT = 0
	,@Senha VARCHAR(20) = NULL
)
AS
BEGIN
	IF @MoradorID = 0
	BEGIN
		IF(select count(1) from UVW_MORADOR where CPF = @CPF and ApartamentoID = @ApartamentoID) = 0
		BEGIN
			INSERT INTO TB_MORADOR
			(
				 Nome
				,RG
				,CPF
				,Email
				,CaminhoImagem
				,ApartamentoID
				,UltimoNome
				,DataNascimento
				,VagaEstacionamentoID
				,IsResponsavel
				,Excluido
				,Senha
			)SELECT
				 @Nome
				,@RG
				,@CPF
				,@Email
				,@CaminhoImagem
				,@ApartamentoID
				,@UltimoNome
				,@DataNascimento
				,@VagaEstacionamentoID
				,@IsResponsavel
				,@Excluido
				,@CPF --Regra ao inserir um novo Morador ele ter� como senha seu CPF

			SET @MoradorID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_MORADOR SET
			 Nome = @Nome
			,RG = @RG
			,CPF = @CPF
			,Email = @Email
			,CaminhoImagem = @CaminhoImagem
			,ApartamentoID = @ApartamentoID
			,UltimoNome = @UltimoNome
			,DataNascimento = @DataNascimento
			,VagaEstacionamentoID = @VagaEstacionamentoID
			,IsResponsavel = @IsResponsavel
			,Excluido = @Excluido
			,Senha = @Senha
		WHERE
			MoradorID = @MoradorID
	END

	SELECT @MoradorID
END
GO