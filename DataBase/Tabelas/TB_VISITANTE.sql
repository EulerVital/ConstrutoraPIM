IF NOT EXISTS(select * from sys.tables where name = 'TB_VISITANTE')
BEGIN
	CREATE TABLE TB_VISITANTE
	(
		 VisitanteID INT PRIMARY KEY IDENTITY(1,1)
		,NomeCompleto VARCHAR(100) NOT NULL
		,RG VARCHAR(20) NULL
		,CPF VARCHAR(20) NULL
		,Email VARCHAR(100) NULL
		,Entrada VARCHAR(10) NULL
		,Saida VARCHAR(10) NULL
		,QtdDias INT NULL
		,Mes INT NULL
		,Semana VARCHAR(50) NULL
		,TempoPermanencia VARCHAR(50) NULL
		,Ano INT NULL
		,EstacionamentoID INT FOREIGN KEY(EstacionamentoID) REFERENCES TB_ESTACIONAMENTO
		,TelefoneID INT FOREIGN KEY (TelefoneID) REFERENCES TB_TELEFONE
	)
END
GO

ALTER TABLE TB_VISITANTE
ADD TipoVisitante CHAR(1) NOT NULL

--TipoVisitante
--R = Visitante Rapido
--P = Visitante Prestador de Serviço
--E = Visitante Estavél

ALTER TABLE TB_VISITANTE
ADD Excluido BIT NOT NULL DEFAULT(0)