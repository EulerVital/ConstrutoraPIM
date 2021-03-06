IF NOT EXISTS(select * from sys.tables where name = 'TB_CORRESPONDENCIA')
BEGIN
	CREATE TABLE TB_CORRESPONDENCIA
	(
		 CorrespondenciaID INT PRIMARY KEY IDENTITY(1,1)
		,TipoNome VARCHAR(100) NOT NULL
		,DataHora DATETIME NOT NULL
		,Titulo VARCHAR(100) NULL
		,AvisoDescricao VARCHAR(MAX) NULL
		,MoradorID INT FOREIGN KEY(MoradorID) REFERENCES TB_MORADOR
		,TipoCorespondeciaID INT FOREIGN KEY(TipoCorespondeciaID) REFERENCES TB_TIPO_CORRESPONDENCIA
	)
END
GO