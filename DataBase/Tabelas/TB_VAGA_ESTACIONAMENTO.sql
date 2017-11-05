IF NOT EXISTS(select * from sys.tables where name = 'TB_VAGA_ESTACIONAMENTO')
BEGIN
	CREATE TABLE TB_VAGA_ESTACIONAMENTO
	(
		 VagaEstacionamentoID INT PRIMARY KEY IDENTITY(1,1)
		,NumeroVaga VARCHAR(100) NOT NULL
		,TipoVaga BIT NOT NULL
		,ReservadaAluguel BIT NULL
		,EstacionamentoID INT FOREIGN KEY(EstacionamentoID) REFERENCES TB_ESTACIONAMENTO
	)
END
GO

ALTER TABLE dbo.TB_VAGA_ESTACIONAMENTO
ADD Excluido BIT DEFAULT(0)

/*
P = Pequena / Motos
M = Media / Veiculos Leves
G = Grande / Veiculos Pesados e Caminhões
*/
ALTER TABLE dbo.TB_VAGA_ESTACIONAMENTO
ALTER COLUMN TipoVaga CHAR(1) NOT NULL

