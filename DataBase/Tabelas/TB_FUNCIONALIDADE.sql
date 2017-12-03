IF NOT EXISTS(select * from sys.tables where name = 'TB_FUNCIONALIDADE')
BEGIN
	CREATE TABLE TB_FUNCIONALIDADE
	(
		 FuncionalidadeID INT PRIMARY KEY IDENTITY(1,1)
		,Descricao VARCHAR(100) NOT NULL 
		,AreaFuncionalidade VARCHAR(50) NOT NULL
		,Excluido BIT NOT NULL DEFAULT(0)
	)
	END
GO

ALTER TABLE TB_FUNCIONALIDADE
ADD Codigo INT NOT NULL
