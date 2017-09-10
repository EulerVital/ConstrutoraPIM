IF NOT EXISTS(select * from sys.tables  where name = 'TB_PREDIO')
BEGIN
	CREATE TABLE TB_PREDIO
	(
		 PredioID INT PRIMARY KEY IDENTITY(1,1)
		,Nome VARCHAR(150) NOT NULL
		,QtdApartamentos VARCHAR(150) NOT NULL
		,BlocoID INT FOREIGN KEY (BlocoID) REFERENCES TB_BLOCO 
	)
END
GO

ALTER TABLE TB_PREDIO
ADD Excluido BIT NOT NULL DEFAULT(0)

ALTER TABLE TB_PREDIO
ALTER COLUMN QtdApartamentos INT NULL