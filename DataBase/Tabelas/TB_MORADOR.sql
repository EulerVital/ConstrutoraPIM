IF NOT EXISTS(select * from sys.tables where name = 'TB_MORADOR')
BEGIN
	CREATE TABLE TB_MORADOR
	(
		 MoradorID INT PRIMARY KEY IDENTITY(1,1)
		,NomeCompleto VARCHAR(100) NOT NULL
		,RG VARCHAR(20) NULL
		,CPF VARCHAR(20) NULL
		,Email VARCHAR(20) NULL
		,CaminhoImagem VARCHAR(MAX) NULL
		,TelefoneID INT FOREIGN KEY(TelefoneID) REFERENCES TB_TELEFONE 
		,VisitanteID INT FOREIGN KEY(VisitanteID) REFERENCES TB_VISITANTE
		,EstacionamentoID INT FOREIGN KEY(EstacionamentoID) REFERENCES TB_ESTACIONAMENTO
		,ApartamentoID INT FOREIGN KEY(ApartamentoID) REFERENCES TB_APARTAMENTO
	)
END
GO