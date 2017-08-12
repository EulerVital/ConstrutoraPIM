IF NOT EXISTS(select * from sys.tables  where name = 'TB_FUNCIONARIO')
BEGIN
	CREATE TABLE TB_FUNCIONARIO
	(
		 FuncionarioID INT PRIMARY KEY IDENTITY(1,1)
		,NomeCompleto VARCHAR(150) NOT NULL
		,RG  VARCHAR(20) NOT NULL
		,CPF VARCHAR(15) NOT NULL
		,DataNascimento DATE NOT NULL
		,TelefoneFixo VARCHAR(15) NULL
		,TelefoneCelular VARCHAR(15) NOT NULL
		,Endereco VARCHAR(300)
		,Bairro VARCHAR(100)
		,CEP VARCHAR(15)
		,CondominioID INT FOREIGN KEY (CondominioID) REFERENCES TB_CONDOMINIO
		,BlocoID INT FOREIGN KEY (BlocoID) REFERENCES TB_BLOCO 
		,ProfissaoID INT FOREIGN KEY (ProfissaoID) REFERENCES TB_PROFISSAO 
	)
END
GO

ALTER TABLE TB_FUNCIONARIO
ADD UsuarioID INT FOREIGN KEY(UsuarioID) REFERENCES TB_USUARIO
GO