IF NOT EXISTS(select * from sys.tables where name =  'TB_RESERVAR_AREA')
BEGIN
	CREATE TABLE TB_RESERVAR_AREA
	(
	 	 ReservaAreaID INT PRIMARY KEY IDENTITY(1,1)
		,DataHora DATETIME NOT NULL
		,MoradorID INT NOT NULL FOREIGN KEY(MoradorID) REFERENCES TB_MORADOR 
		,AreaID INT NOT NULL FOREIGN KEY(AreaID) REFERENCES TB_AREA 
	)
END
GO