IF NOT EXISTS(select * from sys.tables where name = 'TB_USUARIO')
BEGIN
	CREATE TABLE TB_USUARIO
	(
		 UsuarioID INT PRIMARY KEY IDENTITY(1,1)
		,NomeUser VARCHAR(20) NOT NULL -- Nome de Usuário servira como login junto com a senha
		,Senha VARCHAR(20) NOT NULL
		,Sexo BIT NOT NULL
		,CondominioID INT FOREIGN KEY(CondominioID) REFERENCES TB_CONDOMINIO

	)
	END
GO

ALTER TABLE TB_USUARIO
ADD TipoUsuario CHAR(1) NOT NULL
GO

