IF NOT EXISTS(select * from sys.tables where name = 'TB_APARTAMENTO')
BEGIN
	CREATE TABLE TB_APARTAMENTO
	(
		 ApartamentoID INT PRIMARY KEY IDENTITY(1,1)
		,NumeroApartamento INT NOT NULL
		,TipoEstadia CHAR(1) NOT NULL
		,AndarPredio INT NOT NULL
		,PredioID INT FOREIGN KEY(PredioID) REFERENCES TB_PREDIO
	)
END
GO

/*

OBS: TipoEstadia

A = Aluguel
P = Proprietário
T = Temporario

*/