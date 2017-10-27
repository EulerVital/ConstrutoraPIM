IF NOT EXISTS(select * from sys.tables where name = 'TB_TIPOESTADIA')
BEGIN
	CREATE TABLE TB_TIPOESTADIA
	(
		 TipoEstadiaID INT PRIMARY KEY IDENTITY(1,1) NOT NULL
		,Nome VARCHAR(50) NOT NULL
		,ValorFixo DECIMAL(10,2) NULL
	)
END
GO

ALTER TABLE TB_TIPOESTADIA
ADD Excluido BIT NOT NULL DEFAULT(0)