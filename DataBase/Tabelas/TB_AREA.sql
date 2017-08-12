IF NOT EXISTS(select * from sys.tables where name =  'TB_AREA')
BEGIN
	CREATE TABLE TB_AREA
	(
	 	 AreaID INT PRIMARY KEY IDENTITY(1,1)
		,NomeArea VARCHAR(100) NOT NULL
		,TipoArea VARCHAR(50) NOT NULL
		,ModoUso CHAR(1) NOT NULL -- ModoUso = Uso Publico ou Uso Pessoa 
		,IsAreaPaga BIT NOT NULL
		,ValorArea DECIMAL NULL
		,ListaHorarios VARCHAR(MAX)
		,StatusAtivo BIT NOT NULL DEFAULT(1)
		,CondominioID INT FOREIGN KEY(CondominioID) REFERENCES TB_CONDOMINIO
	)
END
GO