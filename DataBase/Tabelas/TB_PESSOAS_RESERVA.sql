IF NOT EXISTS(select * from sys.tables where name =  'TB_PESSOAS_RESERVA')
BEGIN
	CREATE TABLE TB_PESSOAS_RESERVA
	(
	 	 PessoaReservaID INT PRIMARY KEY IDENTITY(1,1)
		,Nome VARCHAR(200) NOT NULL
		,CPF VARCHAR(50) NULL
		,RG VARCHAR(50) NULL
		,IsMenorIdade BIT NOT NULL DEFAULT(0)
		,ResponsavelID INT NULL
		,TipoPagamento VARCHAR(200) NULL
	)
END
GO

ALTER TABLE TB_PESSOAS_RESERVA
ADD ReservaAreaID INT NOT NULL FOREIGN KEY (ReservaID) REFERENCES TB_RESERVAR_AREA
