IF NOT EXISTS(select * from sys.tables  where name = 'TB_BLOCO')
BEGIN
	CREATE TABLE TB_BLOCO
	(
		 BlocoID INT PRIMARY KEY IDENTITY(1,1) --auto_increment
		,Nome VARCHAR(150) NOT NULL
		,QtdPredios INT NOT NULL
		,CondominioID INT FOREIGN KEY (CondominioID) REFERENCES TB_CONDOMINIO
	)
END
GO

ALTER TABLE TB_BLOCO
ADD TipoBloco CHAR(1) NOT NULL
GO

ALTER TABLE TB_BLOCO
ADD StatusAtivo BIT NOT NULL DEFAULT(0)
GO

ALTER TABLE TB_BLOCO
DROP CONSTRAINT DF__TB_BLOCO__Status__38996AB5
GO

ALTER TABLE TB_BLOCO
DROP COLUMN StatusAtivo
GO

ALTER TABLE TB_BLOCO
ADD StatusAtivo BIT NOT NULL DEFAULT(1)
GO

ALTER TABLE TB_BLOCO
ALTER COLUMN QtdPredios INT NULL

ALTER TABLE TB_BLOCO
ALTER COLUMN TipoBloco CHAR(2) NOT NULL
GO