USE [Construtora]
GO
CREATE TABLE [dbo].[TB_ESTADO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTB_PAIS] [int] NULL,
	[Name] [varchar](100) NULL,
	[UF] [varchar](2) NOT NULL,
 CONSTRAINT [PK_TB_ESTADO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_ESTADO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de estados da base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_ESTADO]
AS
	SELECT
		 Id
		,Name
		,UF
	FROM
		TB_ESTADO 

GO
/****** Object:  Table [dbo].[TB_FUNCIONALIDADE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_FUNCIONALIDADE](
	[FuncionalidadeID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[AreaFuncionalidade] [varchar](50) NOT NULL,
	[Excluido] [bit] NOT NULL,
	[Codigo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FuncionalidadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_FUNCIONALIDADE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de funcionalidades na base de dados
* Data Criação: 27/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_FUNCIONALIDADE]
AS
	SELECT
		 FuncionalidadeID
		,Descricao
		,AreaFuncionalidade
		,Codigo
		,Excluido
	FROM
		TB_FUNCIONALIDADE U

GO
/****** Object:  Table [dbo].[TB_USUARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_USUARIO](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[NomeUser] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[CondominioID] [int] NULL,
	[TipoUsuario] [char](1) NOT NULL,
	[BlocoID] [int] NULL,
	[PredioID] [int] NULL,
	[Excluido] [int] NOT NULL,
	[Email] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_CIDADE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CIDADE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[EstadoID] [int] NULL,
 CONSTRAINT [PK_TB_CIDADE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_CIDADE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de cidades da base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_CIDADE]
AS
	SELECT
		 C.Id
		,C.Name Nome
		,ISNULL(C.EstadoID, 0) EstadoID
		,ISNULL(E.Name, 'ND') EstadoNome
		,ISNULL(E.UF, 'ND') UF
	FROM
		TB_CIDADE C
	left join
		UVW_ESTADO E
	ON
		E.Id = C.EstadoID

GO
/****** Object:  Table [dbo].[TB_CONDOMINIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CONDOMINIO](
	[CondominioID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[QtdBlocos] [int] NOT NULL,
	[Endereco] [varchar](300) NULL,
	[CEP] [varchar](20) NULL,
	[Bairro] [varchar](100) NULL,
	[CidadeID] [int] NULL,
	[Excluido] [bit] NOT NULL,
	[DataFundacao] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CondominioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_CONDOMINIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de condominos na base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_CONDOMINIO]
AS
	SELECT
		 CondominioID
		,CO.Nome
		,QtdBlocos
		,ISNULL(Endereco, 'ND') Endereco
		,ISNULL(CEP, 'ND') CEP
		,ISNULL(Bairro, 'ND') Bairro
		,ISNULL(CI.Id, 0) CidadeID
		,ISNULL(CI.Nome, 'ND') CidadeNome
		,DataFundacao
		,EstadoID
		,EstadoNome
		,UF
		,Excluido
	FROM
		TB_CONDOMINIO CO
	left join
		UVW_CIDADE CI
	ON
		CI.Id = CO.CidadeID

GO
/****** Object:  Table [dbo].[TB_BLOCO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_BLOCO](
	[BlocoID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[QtdPredios] [int] NULL,
	[CondominioID] [int] NULL,
	[TipoBloco] [char](2) NOT NULL,
	[StatusAtivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BlocoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_BLOCO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de blocos na base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_BLOCO]
AS
	SELECT
		 B.BlocoID
		,B.Nome
		,B.QtdPredios
		,B.TipoBloco
		,B.StatusAtivo
		,ISNULL(C.CondominioID, 0) CondominioID
		,ISNULL(C.Nome, 'ND') NomeCondominio
		,ISNULL(C.QtdBlocos, 0) QtdBlocos
		,C.DataFundacao
		,ISNULL(C.Endereco, 'ND') Endereco
		,ISNULL(C.CEP, 'ND') CEP
		,ISNULL(C.Bairro, 'ND') Bairro
		,ISNULL(C.CidadeID, 0) CidadeID
		,ISNULL(C.CidadeNome, 'ND') CidadeNome
		,ISNULL(C.Excluido, 0) Excluido 
	FROM
		TB_BLOCO B
	left join
		UVW_CONDOMINIO C
	ON
		B.CondominioID = C.CondominioID

GO
/****** Object:  Table [dbo].[TB_PREDIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PREDIO](
	[PredioID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[QtdApartamentos] [int] NULL,
	[BlocoID] [int] NULL,
	[Excluido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PredioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_PREDIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de predios da base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_PREDIO]
AS
	SELECT
		 P.PredioID
		,P.Nome
		,ISNULL(P.QtdApartamentos, 0) QtdApartamentos
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,P.Excluido 
		,ISNULL(B.QtdPredios, 0) QtdPredios
		,ISNULL(B.TipoBloco, 'ND') TipoBloco
		,ISNULL(B.StatusAtivo, 0) StatusAtivo
		,ISNULL(B.CondominioID, 0) CondominioID
		,ISNULL(B.NomeCondominio, 'ND') NomeCondominio
		,B.DataFundacao
		,ISNULL(B.QtdBlocos, 0) QtdBlocos
		,ISNULL(B.Endereco, 'ND') Endereco
		,ISNULL(B.CEP, 'ND') CEP
		,ISNULL(B.Bairro, 'ND') Bairro
		,ISNULL(B.CidadeID, 0) CidadeID
		,ISNULL(B.CidadeNome, 'ND') CidadeNome
		,ISNULL(B.Excluido, 0) CondominioExcluido
	FROM
		TB_PREDIO P
	left join
		UVW_BLOCO B
	ON
		B.BlocoID = P.BlocoID

GO
/****** Object:  View [dbo].[UVW_USUARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de usuarios na base de dados
* Data Criação: 25/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_USUARIO]
AS
	SELECT
		 U.UsuarioID
		,U.NomeUser
		,U.Senha
		,U.Email
		,U.TipoUsuario
		,U.Excluido
		,ISNULL(CO.CondominioID, 0) CondominioID
		,ISNULL(CO.Nome, 'ND') NomeCondominio
		,CO.QtdBlocos
		,CO.Endereco
		,CO.CEP
		,CO.Bairro
		,CO.CidadeID
		,CO.CidadeNome
		,CO.DataFundacao
		,CO.EstadoID
		,CO.EstadoNome
		,CO.UF
		,CO.Excluido ExcluidoCondominio
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,B.QtdPredios
		,B.TipoBloco
		,B.StatusAtivo
		,ISNULL(P.PredioID, 0) PredioID
		,ISNULL(P.Nome, 'ND') NomePredio
		,P.QtdApartamentos
	FROM
		TB_USUARIO U
	LEFT JOIN
		UVW_CONDOMINIO CO
	ON
		CO.CondominioID = U.CondominioID
	LEFT JOIN
		UVW_BLOCO B
	ON
		B.BlocoID = U.BlocoID
	LEFT JOIN
		UVW_PREDIO P
	ON
		P.PredioID = U.PredioID
GO
/****** Object:  Table [dbo].[TB_FUNCIONALIDADE_USUARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_FUNCIONALIDADE_USUARIO](
	[FuncionarioUser] [int] IDENTITY(1,1) NOT NULL,
	[FuncionalidadeID] [int] NOT NULL,
	[UsuarioID] [int] NOT NULL,
	[Excluido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FuncionarioUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_FUNCIONALIDADE_USUARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de funcionalidade usuarios na base de dados
* Data Criação: 27/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_FUNCIONALIDADE_USUARIO]
AS
	SELECT
		 FU.FuncionarioUser
		,FU.Excluido
		,F.FuncionalidadeID
		,F.Descricao
		,F.AreaFuncionalidade
		,F.Excluido ExcluidoFuncionario
		,U.UsuarioID
		,U.NomeUser
		,U.Senha
		,U.Email
		,U.TipoUsuario
		,U.Excluido ExcluidoUser
		,U.CondominioID
		,U.NomeCondominio
		,U.QtdBlocos
		,U.Endereco
		,U.CEP
		,U.Bairro
		,U.CidadeID
		,U.CidadeNome
		,U.DataFundacao
		,U.EstadoID
		,U.EstadoNome
		,U.UF
		,U.ExcluidoCondominio
	FROM
		TB_FUNCIONALIDADE_USUARIO FU
	JOIN
		UVW_FUNCIONALIDADE F
	ON
		FU.FuncionalidadeID = F.FuncionalidadeID
	JOIN	
		UVW_USUARIO U
	ON
		U.UsuarioID = FU.UsuarioID

GO
/****** Object:  Table [dbo].[TB_TIPOESTADIA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TIPOESTADIA](
	[TipoEstadiaID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[ValorFixo] [decimal](10, 2) NULL,
	[Excluido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoEstadiaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_TIPOESTADIA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo estadia de apartamentos da base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_TIPOESTADIA]
AS
	SELECT
		 TipoEstadiaID
		,Nome
		,ISNULL(ValorFixo, 0.00) ValorFixo
		,Excluido
	FROM
		TB_TIPOESTADIA

GO
/****** Object:  Table [dbo].[TB_APARTAMENTO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_APARTAMENTO](
	[ApartamentoID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroApartamento] [int] NOT NULL,
	[AndarPredio] [int] NOT NULL,
	[PredioID] [int] NULL,
	[ValorApartamento] [decimal](10, 2) NOT NULL,
	[TipoEstadiaID] [int] NOT NULL,
	[IsCadAutomatico] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ApartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_APARTAMENTO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de apartamentos da base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_APARTAMENTO]
AS
	SELECT
		 ApartamentoID
		,NumeroApartamento
		,ValorApartamento
		,AndarPredio
		,A.IsCadAutomatico
		,TE.TipoEstadiaID
		,TE.Nome TipoEstadiaNome
		,TE.ValorFixo
		,TE.Excluido TipoEstadiaExcluido
		,ISNULL(P.PredioID, 0) PredioID
		,ISNULL(P.Nome, 'ND') Nome
		,ISNULL(P.QtdApartamentos, 0) QtdApartamentos
		,ISNULL(P.BlocoID, 0) BlocoID
		,ISNULL(P.Nome, 'ND') NomeBloco
		,P.Excluido 
		,ISNULL(P.QtdPredios, 0) QtdPredios
		,ISNULL(P.TipoBloco, 'ND') TipoBloco
		,ISNULL(P.StatusAtivo, 0) StatusAtivo
		,ISNULL(P.CondominioID, 0) CondominioID
		,ISNULL(P.NomeCondominio, 'ND') NomeCondominio
		,P.DataFundacao
		,ISNULL(P.QtdBlocos, 0) QtdBlocos
		,ISNULL(P.Endereco, 'ND') Endereco
		,ISNULL(P.CEP, 'ND') CEP
		,ISNULL(P.Bairro, 'ND') Bairro
		,ISNULL(P.CidadeID, 0) CidadeID
		,ISNULL(P.CidadeNome, 'ND') CidadeNome
		,ISNULL(P.Excluido, 0) CondominioExcluido
	FROM
		TB_APARTAMENTO A
	left join
		UVW_PREDIO P
	ON
		A.PredioID = P.PredioID
	left join
		UVW_TIPOESTADIA TE
	ON
		A.TipoEstadiaID = TE.TipoEstadiaID

GO
/****** Object:  Table [dbo].[TB_MORADOR]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_MORADOR](
	[MoradorID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[RG] [varchar](20) NULL,
	[CPF] [varchar](20) NULL,
	[Email] [varchar](200) NULL,
	[CaminhoImagem] [varchar](max) NULL,
	[ApartamentoID] [int] NULL,
	[UltimoNome] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[VagaEstacionamentoID] [int] NULL,
	[Excluido] [bit] NOT NULL,
	[IsResponsavel] [bit] NULL,
	[Senha] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MoradorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_ESTACIONAMENTO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ESTACIONAMENTO](
	[EstacionamentoID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[QtdVagas] [int] NOT NULL,
	[TipoEstacionamento] [char](1) NULL,
	[CondominioID] [int] NULL,
	[BlocoID] [int] NULL,
	[Excluido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[EstacionamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_ESTACIONAMENTO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de Estacionamento da base de dados
* Data Criação: 05/09/2017
* Autor: Rafael Marques
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_ESTACIONAMENTO]
AS
	SELECT
		 E.EstacionamentoID
		,E.Nome
		,E.QtdVagas
		,ISNULL(TipoEstacionamento, 'ND') TipoEstacionamento
		,E.Excluido
		,ISNULL(B.BlocoID, 0) BlocoID
		,ISNULL(B.Nome, 'ND') NomeBloco
		,ISNULL(B.QtdPredios, 0) QtdPredios
		,ISNULL(B.TipoBloco, 'ND') TipoBloco
		,ISNULL(B.StatusAtivo, 0) StatusAtivo
		,ISNULL(C.CondominioID, 0) CondominioID
		,ISNULL(C.Nome, 'ND') NomeCondominio
		,ISNULL(C.QtdBlocos, 0) QtdBlocos
		,C.DataFundacao
		,ISNULL(C.Endereco, 'ND') Endereco
		,ISNULL(C.CEP, 'ND') CEP
		,ISNULL(C.Bairro, 'ND') Bairro
		,ISNULL(C.CidadeID, 0) CidadeID
		,ISNULL(C.CidadeNome, 'ND') CidadeNome
		,ISNULL(C.Excluido, 0) CondominioExcluido
	FROM
		TB_ESTACIONAMENTO E
	left join
		UVW_BLOCO B
	ON
		B.BlocoID = E.BlocoID
	left join 
		UVW_CONDOMINIO C
     ON
		C.CondominioID = E.CondominioID

GO
/****** Object:  Table [dbo].[TB_VAGA_ESTACIONAMENTO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_VAGA_ESTACIONAMENTO](
	[VagaEstacionamentoID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroVaga] [varchar](100) NOT NULL,
	[TipoVaga] [char](1) NOT NULL,
	[ReservadaAluguel] [bit] NULL,
	[EstacionamentoID] [int] NULL,
	[Excluido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[VagaEstacionamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_VAGA_ESTACIONAMENTO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[UVW_VAGA_ESTACIONAMENTO]
AS
	SELECT
		 VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ISNULL(ReservadaAluguel, 0) ReservadaAluguel
		,ISNULL(VE.EstacionamentoID, 0) EstacionamentoID
		,VE.Excluido
		,E.Nome
		,E.QtdVagas
		,E.TipoEstacionamento
		,E.Excluido AS ExcluidoEstacionamento
		,E.BlocoID
		,E.NomeBloco
		,E.QtdPredios
		,E.TipoBloco
		,E.StatusAtivo
		,E.CondominioID
		,E.NomeCondominio
		,E.QtdBlocos
		,E.DataFundacao
		,E.Endereco
		,E.CEP
		,E.Bairro
		,E.CidadeID
		,E.CidadeNome
		,E.CondominioExcluido
	FROM
		TB_VAGA_ESTACIONAMENTO VE
	LEFT JOIN
		UVW_ESTACIONAMENTO E
	ON
		E.EstacionamentoID = VE.EstacionamentoID
GO
/****** Object:  View [dbo].[UVW_MORADOR]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[UVW_MORADOR]
AS
	SELECT
		 MoradorID
		,ISNULL(M.Nome, 'ND') Nome
		,ISNULL(RG, 'ND') RG
		,ISNULL(CPF, '') CPF
		,ISNULL(Email, 'ND') Email
		,ISNULL(CaminhoImagem, '') CaminhoImagem
		,UltimoNome
		,ISNULL(M.Nome + '.' + M.UltimoNome, 'ND') LoginSite
		,DataNascimento
		,M.Excluido 
		,IsResponsavel
		,Senha
		,A.ApartamentoID
		,A.NumeroApartamento
		,A.ValorApartamento
		,A.AndarPredio
		,A.IsCadAutomatico
		,A.TipoEstadiaID
		,A.TipoEstadiaNome
		,A.ValorFixo
		,A.TipoEstadiaExcluido
		,A.PredioID
		,A.Nome AS NomePredio
		,A.QtdApartamentos
		,A.BlocoID
		,A.NomeBloco
		,A.Excluido ExcluidoBloco
		,A.QtdPredios
		,A.TipoBloco
		,A.StatusAtivo
		,A.CondominioID
		,A.NomeCondominio
		,A.DataFundacao
		,A.QtdBlocos
		,A.Endereco
		,A.CEP
		,A.Bairro
		,A.CidadeID
		,A.CidadeNome
		,A.CondominioExcluido
		,ISNULL(VE.VagaEstacionamentoID, 0) VagaEstacionamentoID
		,ISNULL(VE.NumeroVaga, 'ND') NumeroVaga
		,ISNULL(VE.TipoVaga, 0) TipoVaga
		,ISNULL(VE.ReservadaAluguel, 0) ReservadaAluguel
		,ISNULL(VE.EstacionamentoID, 0) EstacionamentoID
		,ISNULL(VE.Nome, 'ND') NomeEstacionamento
		,ISNULL(VE.QtdVagas, 0) QtdVagas
		,ISNULL(VE.TipoEstacionamento, 'ND') TipoEstacionamento
	FROM
		TB_MORADOR M
	LEFT JOIN
		UVW_VAGA_ESTACIONAMENTO VE
	ON
		M.VagaEstacionamentoID = VE.VagaEstacionamentoID
	LEFT JOIN
		UVW_APARTAMENTO A
	ON
		A.ApartamentoID = M.ApartamentoID

GO
/****** Object:  Table [dbo].[TB_AREA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AREA](
	[AreaID] [int] IDENTITY(1,1) NOT NULL,
	[NomeArea] [varchar](100) NOT NULL,
	[TipoArea] [varchar](50) NOT NULL,
	[ModoUso] [char](2) NOT NULL,
	[IsAreaPaga] [bit] NOT NULL,
	[ValorArea] [decimal](18, 0) NULL,
	[Status] [bit] NOT NULL,
	[CondominioID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_AREA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de area na base de dados
* Data Criação: 09/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_AREA]
AS
	SELECT
		 AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ISNULL(ValorArea, 0.0) ValorArea
		,Status
		,ISNULL(A.CondominioID, 0) CondominioID
		,ISNULL(Nome, 'ND') Nome
		,ISNULL(QtdBlocos , 0) QtdBlocos
		,ISNULL(Endereco, 'ND') Endereco
		,ISNULL(CEP, 'ND') CEP
		,ISNULL(Bairro, 'ND') Bairro
		,ISNULL(CidadeID, 0) CidadeID
		,ISNULL(CidadeNome, 'ND') CidadeNome
		,DataFundacao
		,ISNULL(EstadoID, 0) EstadoID
		,ISNULL(EstadoNome, 'ND') EstadoNome
		,ISNULL(UF, 'ND') UF
		,ISNULL(Excluido, 0) Excluido
	FROM
		TB_AREA A
	LEFT JOIN
		dbo.UVW_CONDOMINIO UVC
	ON
		UVC.CondominioID = A.CondominioID



GO
/****** Object:  Table [dbo].[TB_TELEFONE_MORADOR]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TELEFONE_MORADOR](
	[TelefoneID] [int] NULL,
	[MoradorID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_TELEFONE_MORADOR]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de telefone morador da base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_TELEFONE_MORADOR]
AS
	SELECT
		  ISNULL(TelefoneID, 0) TelefoneID
		 ,ISNULL(TM.MoradorID, 0) MoradorID
		 ,M.Nome 
		 ,M.UltimoNome
	FROM
		TB_TELEFONE_MORADOR TM
	JOIN
		UVW_MORADOR M
	ON
		M.MoradorID = TM.MoradorID

GO
/****** Object:  Table [dbo].[TB_TIPO_TELEFONE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TIPO_TELEFONE](
	[TipoTelefoneID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Excluido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoTelefoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_TIPO_TELEFONE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo_telefones da base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_TIPO_TELEFONE]
AS
	SELECT
		 TipoTelefoneID
		,Descricao
		,Excluido
	FROM
		TB_TIPO_TELEFONE

GO
/****** Object:  Table [dbo].[TB_TELEFONE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TELEFONE](
	[TelefoneID] [int] IDENTITY(1,1) NOT NULL,
	[Contato] [varchar](50) NOT NULL,
	[TipoTelefoneID] [int] NULL,
	[Excluido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TelefoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_TELEFONE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de telefones da base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_TELEFONE]
AS
	SELECT
		  T.TelefoneID
		 ,Contato
		 ,T.Excluido
		 ,TT.TipoTelefoneID 
		 ,TT.Descricao TipoTelefone
		 ,TT.Excluido TipoTelefoneExcluido
	FROM
		TB_TELEFONE T
	LEFT JOIN
		UVW_TIPO_TELEFONE TT
	ON
		TT.TipoTelefoneID = T.TipoTelefoneID

GO
/****** Object:  Table [dbo].[TB_RESERVAR_AREA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_RESERVAR_AREA](
	[ReservaAreaID] [int] IDENTITY(1,1) NOT NULL,
	[DataReserva] [date] NULL,
	[MoradorID] [int] NOT NULL,
	[AreaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReservaAreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_RESERVAR_AREA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[UVW_RESERVAR_AREA]
AS
	SELECT
		 RA.ReservaAreaID
		,RA.DataReserva
		,M.MoradorID
		,M.Nome
		,M.RG
		,M.CPF
		,M.Email
		,M.CaminhoImagem
		,M.UltimoNome
		,M.LoginSite
		,M.DataNascimento
		,M.Excluido
		,M.IsResponsavel
		,M.ApartamentoID
		,M.NumeroApartamento
		,M.ValorApartamento
		,M.AndarPredio
		,M.IsCadAutomatico
		,M.TipoEstadiaID
		,M.TipoEstadiaNome
		,M.ValorFixo
		,M.TipoEstadiaExcluido
		,M.PredioID
		,M.NomePredio
		,M.QtdApartamentos
		,M.BlocoID
		,M.NomeBloco
		,M.ExcluidoBloco
		,M.QtdPredios
		,M.TipoBloco
		,M.StatusAtivo
		,M.CondominioID
		,M.NomeCondominio
		,M.DataFundacao
		,M.QtdBlocos
		,M.Endereco
		,M.CEP
		,M.Bairro
		,M.CidadeID
		,M.CidadeNome
		,M.CondominioExcluido
		,M.VagaEstacionamentoID
		,M.NumeroVaga
		,M.TipoVaga
		,M.ReservadaAluguel
		,M.EstacionamentoID
		,M.NomeEstacionamento
		,M.QtdVagas
		,M.TipoEstacionamento
		,A.AreaID
		,A.NomeArea
		,A.TipoArea
		,A.ModoUso
		,A.IsAreaPaga
		,A.ValorArea
		,A.Status
	FROM
		TB_RESERVAR_AREA RA
	LEFT JOIN
		UVW_MORADOR M
	ON
		M.MoradorID = RA.MoradorID
	LEFT JOIN
		UVW_AREA A
	ON
		A.AreaID = RA.AreaID
GO
/****** Object:  Table [dbo].[TB_PROFISSAO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PROFISSAO](
	[ProfissaoID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[Area] [varchar](150) NOT NULL,
	[Descricao] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProfissaoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_PROFISSAO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de profissão na base de dados
* Data Criação: 16/08/2017
* Autor: Rafael Marques
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_PROFISSAO]
AS
	SELECT
		 ProfissaoID
		,Nome
		,Area
		,ISNULL(Descricao, 'ND') Descricao
	FROM
		TB_PROFISSAO

GO
/****** Object:  Table [dbo].[TB_HORARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_HORARIO](
	[HorarioID] [int] IDENTITY(1,1) NOT NULL,
	[HoraInicio] [varchar](50) NOT NULL,
	[HoraFim] [varchar](50) NULL,
	[Excluido] [bit] NOT NULL,
	[AreaID] [int] NOT NULL,
	[Reservado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[HorarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_HORARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de Horario na base de dados
* Data Criação: 11/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE VIEW [dbo].[UVW_HORARIO]
AS
	SELECT
		 HorarioID
		,HoraInicio
		,HoraFim
		,H.Excluido
		,H.Reservado
		,UVA.AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		TB_HORARIO H
	LEFT JOIN
		dbo.UVW_AREA UVA
	ON
		UVA.AreaID = H.AreaID

GO
/****** Object:  Table [dbo].[TB_PESSOAS_RESERVA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PESSOAS_RESERVA](
	[PessoaReservaID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[CPF] [varchar](50) NULL,
	[RG] [varchar](50) NULL,
	[IsMenorIdade] [bit] NOT NULL,
	[ResponsavelID] [int] NULL,
	[TipoPagamento] [varchar](200) NULL,
	[ReservaAreaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PessoaReservaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_PESSOAS_RESERVA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[UVW_PESSOAS_RESERVA]
AS
	SELECT
		 PA.PessoaReservaID
		,PA.Nome
		,PA.CPF
		,PA.RG
		,PA.IsMenorIdade
		,PA.ResponsavelID
		,PA.TipoPagamento
		,RA.ReservaAreaID
		,RA.DataReserva
		,RA.MoradorID
		,RA.Nome NomeMorador
		,RA.RG RgMorador
		,RA.CPF CpfMorador
		,RA.Email
		,RA.CaminhoImagem
		,RA.UltimoNome
		,RA.LoginSite
		,RA.DataNascimento
		,RA.Excluido
		,RA.IsResponsavel
		,RA.AreaID
		,RA.NomeArea
		,RA.TipoArea
		,RA.ModoUso
		,RA.IsAreaPaga
		,RA.ValorArea
		,RA.Status
	FROM
		TB_PESSOAS_RESERVA PA
	LEFT JOIN
		UVW_RESERVAR_AREA RA
	ON
		RA.ReservaAreaID = PA.ReservaAreaID
	
GO
/****** Object:  Table [dbo].[TB_CORRESPONDENCIA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CORRESPONDENCIA](
	[CorrespondenciaID] [int] IDENTITY(1,1) NOT NULL,
	[TipoNome] [varchar](100) NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[Titulo] [varchar](100) NULL,
	[AvisoDescricao] [varchar](max) NULL,
	[MoradorID] [int] NULL,
	[TipoCorespondeciaID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CorrespondenciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_FUNCIONARIO]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_FUNCIONARIO](
	[FuncionarioID] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](150) NOT NULL,
	[RG] [varchar](20) NOT NULL,
	[CPF] [varchar](15) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[TelefoneFixo] [varchar](15) NULL,
	[TelefoneCelular] [varchar](15) NOT NULL,
	[Endereco] [varchar](300) NULL,
	[Bairro] [varchar](100) NULL,
	[CEP] [varchar](15) NULL,
	[CondominioID] [int] NULL,
	[BlocoID] [int] NULL,
	[ProfissaoID] [int] NULL,
	[UsuarioID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FuncionarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_PAIS]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PAIS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_TB_PAIS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_TIPO_CORRESPONDENCIA]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TIPO_CORRESPONDENCIA](
	[TipoCorrespondenciaID] [int] IDENTITY(1,1) NOT NULL,
	[TipoNome] [varchar](100) NOT NULL,
	[Excluido] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoCorrespondenciaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_VISITANTE]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_VISITANTE](
	[VisitanteID] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](100) NOT NULL,
	[RG] [varchar](20) NULL,
	[CPF] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Entrada] [varchar](10) NULL,
	[Saida] [varchar](10) NULL,
	[QtdDias] [int] NULL,
	[Mes] [int] NULL,
	[Semana] [varchar](50) NULL,
	[TempoPermanencia] [varchar](50) NULL,
	[Ano] [int] NULL,
	[EstacionamentoID] [int] NULL,
	[TelefoneID] [int] NULL,
	[TipoVisitante] [char](1) NOT NULL,
	[Excluido] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VisitanteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[TB_APARTAMENTO] ADD  DEFAULT ((0.00)) FOR [ValorApartamento]
GO
ALTER TABLE [dbo].[TB_APARTAMENTO] ADD  DEFAULT ((0)) FOR [IsCadAutomatico]
GO
ALTER TABLE [dbo].[TB_AREA] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[TB_BLOCO] ADD  DEFAULT ((1)) FOR [StatusAtivo]
GO
ALTER TABLE [dbo].[TB_CONDOMINIO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_ESTACIONAMENTO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_FUNCIONALIDADE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_FUNCIONALIDADE_USUARIO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_HORARIO] ADD  DEFAULT ((1)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_HORARIO] ADD  DEFAULT ((0)) FOR [Reservado]
GO
ALTER TABLE [dbo].[TB_MORADOR] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_MORADOR] ADD  DEFAULT ((0)) FOR [IsResponsavel]
GO
ALTER TABLE [dbo].[TB_PESSOAS_RESERVA] ADD  DEFAULT ((0)) FOR [IsMenorIdade]
GO
ALTER TABLE [dbo].[TB_PREDIO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_TELEFONE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_TIPO_TELEFONE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_TIPOESTADIA] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_USUARIO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_VAGA_ESTACIONAMENTO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_VISITANTE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_APARTAMENTO]  WITH CHECK ADD FOREIGN KEY([PredioID])
REFERENCES [dbo].[TB_PREDIO] ([PredioID])
GO
ALTER TABLE [dbo].[TB_APARTAMENTO]  WITH CHECK ADD FOREIGN KEY([TipoEstadiaID])
REFERENCES [dbo].[TB_TIPOESTADIA] ([TipoEstadiaID])
GO
ALTER TABLE [dbo].[TB_AREA]  WITH CHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_BLOCO]  WITH CHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_CIDADE]  WITH CHECK ADD  CONSTRAINT [FK_TB_CIDADE_TB_ESTADO] FOREIGN KEY([EstadoID])
REFERENCES [dbo].[TB_ESTADO] ([Id])
GO
ALTER TABLE [dbo].[TB_CIDADE] CHECK CONSTRAINT [FK_TB_CIDADE_TB_ESTADO]
GO
ALTER TABLE [dbo].[TB_CONDOMINIO]  WITH CHECK ADD FOREIGN KEY([CidadeID])
REFERENCES [dbo].[TB_CIDADE] ([Id])
GO
ALTER TABLE [dbo].[TB_CORRESPONDENCIA]  WITH CHECK ADD FOREIGN KEY([MoradorID])
REFERENCES [dbo].[TB_MORADOR] ([MoradorID])
GO
ALTER TABLE [dbo].[TB_CORRESPONDENCIA]  WITH CHECK ADD FOREIGN KEY([TipoCorespondeciaID])
REFERENCES [dbo].[TB_TIPO_CORRESPONDENCIA] ([TipoCorrespondenciaID])
GO
ALTER TABLE [dbo].[TB_ESTACIONAMENTO]  WITH NOCHECK ADD FOREIGN KEY([BlocoID])
REFERENCES [dbo].[TB_BLOCO] ([BlocoID])
GO
ALTER TABLE [dbo].[TB_ESTACIONAMENTO]  WITH NOCHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_ESTADO]  WITH CHECK ADD  CONSTRAINT [FK_TB_ESTADO_TB_PAIS] FOREIGN KEY([IdTB_PAIS])
REFERENCES [dbo].[TB_PAIS] ([Id])
GO
ALTER TABLE [dbo].[TB_ESTADO] CHECK CONSTRAINT [FK_TB_ESTADO_TB_PAIS]
GO
ALTER TABLE [dbo].[TB_FUNCIONALIDADE_USUARIO]  WITH NOCHECK ADD FOREIGN KEY([FuncionalidadeID])
REFERENCES [dbo].[TB_FUNCIONALIDADE] ([FuncionalidadeID])
GO
ALTER TABLE [dbo].[TB_FUNCIONALIDADE_USUARIO]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[TB_USUARIO] ([UsuarioID])
GO
ALTER TABLE [dbo].[TB_FUNCIONARIO]  WITH CHECK ADD FOREIGN KEY([BlocoID])
REFERENCES [dbo].[TB_BLOCO] ([BlocoID])
GO
ALTER TABLE [dbo].[TB_FUNCIONARIO]  WITH CHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_FUNCIONARIO]  WITH CHECK ADD FOREIGN KEY([ProfissaoID])
REFERENCES [dbo].[TB_PROFISSAO] ([ProfissaoID])
GO
ALTER TABLE [dbo].[TB_FUNCIONARIO]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[TB_USUARIO] ([UsuarioID])
GO
ALTER TABLE [dbo].[TB_HORARIO]  WITH CHECK ADD FOREIGN KEY([AreaID])
REFERENCES [dbo].[TB_AREA] ([AreaID])
GO
ALTER TABLE [dbo].[TB_MORADOR]  WITH CHECK ADD FOREIGN KEY([ApartamentoID])
REFERENCES [dbo].[TB_APARTAMENTO] ([ApartamentoID])
GO
ALTER TABLE [dbo].[TB_MORADOR]  WITH CHECK ADD FOREIGN KEY([VagaEstacionamentoID])
REFERENCES [dbo].[TB_VAGA_ESTACIONAMENTO] ([VagaEstacionamentoID])
GO
ALTER TABLE [dbo].[TB_PESSOAS_RESERVA]  WITH CHECK ADD FOREIGN KEY([ResponsavelID])
REFERENCES [dbo].[TB_PESSOAS_RESERVA] ([PessoaReservaID])
GO
ALTER TABLE [dbo].[TB_PREDIO]  WITH CHECK ADD FOREIGN KEY([BlocoID])
REFERENCES [dbo].[TB_BLOCO] ([BlocoID])
GO
ALTER TABLE [dbo].[TB_RESERVAR_AREA]  WITH CHECK ADD FOREIGN KEY([AreaID])
REFERENCES [dbo].[TB_AREA] ([AreaID])
GO
ALTER TABLE [dbo].[TB_RESERVAR_AREA]  WITH CHECK ADD FOREIGN KEY([MoradorID])
REFERENCES [dbo].[TB_MORADOR] ([MoradorID])
GO
ALTER TABLE [dbo].[TB_TELEFONE]  WITH NOCHECK ADD FOREIGN KEY([TipoTelefoneID])
REFERENCES [dbo].[TB_TIPO_TELEFONE] ([TipoTelefoneID])
GO
ALTER TABLE [dbo].[TB_TELEFONE_MORADOR]  WITH CHECK ADD FOREIGN KEY([MoradorID])
REFERENCES [dbo].[TB_MORADOR] ([MoradorID])
GO
ALTER TABLE [dbo].[TB_TELEFONE_MORADOR]  WITH CHECK ADD FOREIGN KEY([TelefoneID])
REFERENCES [dbo].[TB_TELEFONE] ([TelefoneID])
GO
ALTER TABLE [dbo].[TB_USUARIO]  WITH CHECK ADD FOREIGN KEY([BlocoID])
REFERENCES [dbo].[TB_BLOCO] ([BlocoID])
GO
ALTER TABLE [dbo].[TB_USUARIO]  WITH CHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_USUARIO]  WITH CHECK ADD FOREIGN KEY([PredioID])
REFERENCES [dbo].[TB_PREDIO] ([PredioID])
GO
ALTER TABLE [dbo].[TB_VAGA_ESTACIONAMENTO]  WITH CHECK ADD FOREIGN KEY([EstacionamentoID])
REFERENCES [dbo].[TB_ESTACIONAMENTO] ([EstacionamentoID])
GO
ALTER TABLE [dbo].[TB_VISITANTE]  WITH CHECK ADD FOREIGN KEY([EstacionamentoID])
REFERENCES [dbo].[TB_ESTACIONAMENTO] ([EstacionamentoID])
GO
ALTER TABLE [dbo].[TB_VISITANTE]  WITH CHECK ADD FOREIGN KEY([TelefoneID])
REFERENCES [dbo].[TB_TELEFONE] ([TelefoneID])
GO
/****** Object:  StoredProcedure [dbo].[Qtd]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de predios com filtros base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[Qtd]
(
	 @PredioID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@BlocoID INT = NULL
	,@NomeBloco VARCHAR(150) = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 PredioID
		,Nome
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,Excluido
	FROM
		UVW_PREDIO
	WHERE
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 QtdApartamentos = COALESCE(@QtdApartamentos, QtdApartamentos)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 NomeBloco = COALESCE(@NomeBloco, NomeBloco)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 NomeCondominio = COALESCE(@NomeCondominio, NomeCondominio)
	AND
		Excluido = COALESCE(@Excluido, Excluido)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_APARTAMENTO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de apartamentos com filtros base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_APARTAMENTO_GET]
(
	 @ApartamentoID INT  = NULL
	,@PredioID INT = NULL
	,@NomePredio VARCHAR(100) = NULL
	,@IsApartamentoSemMorador BIT = NULL
)
AS
BEGIN
	
	IF @IsApartamentoSemMorador IS NULL
	BEGIN
		SELECT
			 A.ApartamentoID
			,A.NumeroApartamento
			,A.TipoEstadiaID
			,A.TipoEstadiaNome
			,A.ValorFixo
			,A.IsCadAutomatico
			,A.TipoEstadiaExcluido
			,A.AndarPredio
			,A.ValorApartamento
			,A.PredioID
			,A.Nome
			,A.QtdApartamentos
			,A.BlocoID
			,A.NomeBloco
			,A.Excluido
			,A.QtdPredios
			,A.TipoBloco
			,A.StatusAtivo
			,A.CondominioID
			,A.NomeCondominio
			,A.DataFundacao
			,A.QtdBlocos
			,A.Endereco
			,A.CEP
			,A.Bairro
			,A.CidadeID
			,A.CidadeNome
			,A.CondominioExcluido
		FROM
			UVW_APARTAMENTO A
		WHERE
			 A.ApartamentoID = COALESCE(@ApartamentoID, A.ApartamentoID)
		AND
			 A.PredioID = COALESCE(@PredioID, A.PredioID)
		AND
			 A.Nome = COALESCE(@NomePredio, A.Nome)
	END
	ELSE IF @IsApartamentoSemMorador = 1
	BEGIN
			SELECT
			 A.ApartamentoID
			,A.NumeroApartamento
			,A.TipoEstadiaID
			,A.TipoEstadiaNome
			,A.ValorFixo
			,A.IsCadAutomatico
			,A.TipoEstadiaExcluido
			,A.AndarPredio
			,A.ValorApartamento
			,A.PredioID
			,A.Nome
			,A.QtdApartamentos
			,A.BlocoID
			,A.NomeBloco
			,A.Excluido
			,A.QtdPredios
			,A.TipoBloco
			,A.StatusAtivo
			,A.CondominioID
			,A.NomeCondominio
			,A.DataFundacao
			,A.QtdBlocos
			,A.Endereco
			,A.CEP
			,A.Bairro
			,A.CidadeID
			,A.CidadeNome
			,A.CondominioExcluido
			,M.MoradorID
		FROM
			UVW_APARTAMENTO A
		LEFT JOIN
			dbo.UVW_MORADOR M
		ON
			A.ApartamentoID = M.ApartamentoID
		WHERE
			 A.ApartamentoID = COALESCE(@ApartamentoID, A.ApartamentoID)
		AND
			 A.PredioID = COALESCE(@PredioID, A.PredioID)
		AND
			 A.Nome = COALESCE(@NomePredio, A.Nome)
		AND
			M.MoradorID IS NULL
	END
	ELSE
	BEGIN
			SELECT
			 A.ApartamentoID
			,A.NumeroApartamento
			,A.TipoEstadiaID
			,A.TipoEstadiaNome
			,A.ValorFixo
			,A.IsCadAutomatico
			,A.TipoEstadiaExcluido
			,A.AndarPredio
			,A.ValorApartamento
			,A.PredioID
			,A.Nome
			,A.QtdApartamentos
			,A.BlocoID
			,A.NomeBloco
			,A.Excluido
			,A.QtdPredios
			,A.TipoBloco
			,A.StatusAtivo
			,A.CondominioID
			,A.NomeCondominio
			,A.DataFundacao
			,A.QtdBlocos
			,A.Endereco
			,A.CEP
			,A.Bairro
			,A.CidadeID
			,A.CidadeNome
			,A.CondominioExcluido
			,M.MoradorID
		FROM
			UVW_APARTAMENTO A
		RIGHT JOIN
			dbo.UVW_MORADOR M
		ON
			A.ApartamentoID = M.ApartamentoID
		WHERE
			 A.ApartamentoID = COALESCE(@ApartamentoID, A.ApartamentoID)
		AND
			 A.PredioID = COALESCE(@PredioID, A.PredioID)
		AND
			 A.Nome = COALESCE(@NomePredio, A.Nome)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[USP_APARTAMENTO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de apartamento na base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_APARTAMENTO_SET]
(
	 @ApartamentoID INT = 0
	,@NumeroApartamento INT
	,@TipoEstadiaID INT
	,@ValorApartamento DECIMAL(10,2)
	,@AndarPredio INT
	,@PredioID INT = NULL
	,@IsCadAutomatico BIT = NULL
)
AS
BEGIN

	IF @ApartamentoID = 0
	BEGIN
		INSERT INTO TB_APARTAMENTO
		(
			 NumeroApartamento
			,TipoEstadiaID
			,ValorApartamento
			,AndarPredio
			,PredioID
			,IsCadAutomatico
		)SELECT
			 @NumeroApartamento
			,@TipoEstadiaID
			,@ValorApartamento
			,@AndarPredio
			,@PredioID
			,@IsCadAutomatico

		SET @ApartamentoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_APARTAMENTO SET
			 NumeroApartamento = @NumeroApartamento
			,TipoEstadiaID = @TipoEstadiaID
			,ValorApartamento = @ValorApartamento
			,AndarPredio = @AndarPredio
			,PredioID = @PredioID
			,IsCadAutomatico = @IsCadAutomatico
		WHERE
			ApartamentoID = @ApartamentoID
	END

	SELECT @ApartamentoID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_AREA_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de areas com filtros base de dados
* Data Criação: 11/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_AREA_GET]
(
	  @AreaID INT = NULL
	 ,@IsAreaPaga BIT = NULL
	 ,@CondominioID INT = NULL
)
AS
BEGIN
	SELECT
		 AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
		,CondominioID
		,Nome
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,DataFundacao
		,EstadoID
		,EstadoNome
		,UF
		,Excluido
	FROM
		UVW_AREA
	WHERE
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 IsAreaPaga = COALESCE(@IsAreaPaga, IsAreaPaga)
		
END

GO
/****** Object:  StoredProcedure [dbo].[USP_AREA_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de area na base de dados
* Data Criação: 09/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_AREA_SET]
(
	 @AreaID INT = 0
	,@NomeArea VARCHAR(100)
	,@TipoArea VARCHAR(50)
	,@ModoUso CHAR(2)
	,@IsAreaPaga BIT
	,@ValorArea DECIMAL = NULL
	,@Status BIT
	,@CondominioID INT = NULL
)
AS
BEGIN

	IF @AREAID = 0
	BEGIN
		INSERT INTO TB_AREA
		(
			 NomeArea
			,TipoArea
			,ModoUso
			,IsAreaPaga
			,ValorArea
			,Status
			,CondominioID
		)SELECT
			 @NomeArea
			,@TipoArea
			,@ModoUso
			,@IsAreaPaga
			,@ValorArea
			,@Status
			,@CondominioID

		SET @AreaID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_AREA SET
			 NomeArea = @NomeArea
			,TipoArea = @TipoArea
			,ModoUso = @ModoUso
			,IsAreaPaga = @IsAreaPaga
			,ValorArea = @ValorArea
			,Status = @Status
			,CondominioID = @CondominioID
		WHERE
			AREAID = @AREAID
	END

	SELECT @AreaID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_BLOCO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de condominos com filtros base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_BLOCO_GET]
(
	 @BlocoID INT = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdPredios INT = NULL
	,@TipoBloco CHAR(2) = NULL
	,@StatusAtivo BIT = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
)
AS
BEGIN
	SELECT
		 BlocoID
		,Nome
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,DataFundacao
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,Excluido
	FROM
		UVW_BLOCO
	WHERE
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 TipoBloco = COALESCE(@TipoBloco, TipoBloco)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 NomeCondominio = COALESCE(@NomeCondominio, NomeCondominio)
		
END

GO
/****** Object:  StoredProcedure [dbo].[USP_BLOCO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de BLOCO na base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_BLOCO_SET]
(
	 @BlocoID INT = 0
	,@Nome VARCHAR(150) = NULL
	,@QtdPredios INT = NULL
	,@CondominioID INT = NULL
	,@TipoBloco CHAR(2) = NULL
	,@StatusAtivo BIT = NULL
)
AS
BEGIN
	
	IF @CondominioID = 0
	BEGIN
		SET @CondominioID = NULL
	END

	IF @BlocoID = 0
	BEGIN
		INSERT INTO TB_BLOCO
		(
				Nome
			,QtdPredios
			,CondominioID
			,TipoBloco
			,StatusAtivo
		)SELECT
			 @Nome
			,@QtdPredios
			,@CondominioID
			,@TipoBloco
			,@StatusAtivo

		SET @BlocoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_BLOCO SET
			 Nome = @Nome
			,QtdPredios = @QtdPredios
			,CondominioID = @CondominioID
			,TipoBloco = @TipoBloco
			,StatusAtivo = @StatusAtivo
		WHERE
			BlocoID = @BlocoID
	END

	SELECT @BlocoID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_CIDADE_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de cidades com filtros base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_CIDADE_GET]
(
	 @CidadeID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@EstadoID INT = NULL
	,@UF VARCHAR(2) = NULL
)
AS
BEGIN
	SELECT
		  Id
		 ,Nome
		 ,EstadoID
		 ,EstadoNome
		 ,UF
	FROM
		UVW_CIDADE
	WHERE
		 Id = COALESCE(@CidadeID, Id)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 EstadoID = COALESCE(@EstadoID, EstadoID)
	AND
		 UF = COALESCE(@UF, UF)
	ORDER BY
		Nome
END

GO
/****** Object:  StoredProcedure [dbo].[USP_CONDOMINIO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de condominos com filtros base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_CONDOMINIO_GET]
(
	 @CondominioID INT = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdBlocos INT = NULL
	,@Endereco VARCHAR(300) = NULL
	,@CEP VARCHAR(20) = NULL
	,@Bairro VARCHAR(100) = NULL
	,@CidadeID INT = NULL
	,@DataFundacao DATE = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 CondominioID
		,Nome
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,EstadoID
		,EstadoNome
		,UF
		,Excluido
		,DataFundacao
	FROM
		UVW_CONDOMINIO
	WHERE
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 Nome = COALESCE(@Nome, Nome)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_CONDOMINIO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de condominos na base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_CONDOMINIO_SET]
(
	 @CondominioID INT = 0
	,@Nome VARCHAR(150)
	,@QtdBlocos INT 
	,@Endereco VARCHAR(300) = NULL
	,@CEP VARCHAR(20) = NULL
	,@Bairro VARCHAR(100) = NULL
	,@CidadeID INT = NULL
	,@DataFundacao DATE = NULL
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @CondominioID = 0
	BEGIN
		IF(select count(1) from TB_CONDOMINIO where Nome = @Nome and CEP = @CEP) = 0
		BEGIN
			INSERT INTO TB_CONDOMINIO
			(
				 Nome
				,QtdBlocos
				,Endereco
				,CEP
				,Bairro
				,CidadeID
				,Excluido
				,DataFundacao
			)SELECT
				 @Nome
				,@QtdBlocos
				,@Endereco
				,@CEP
				,@Bairro
				,@CidadeID
				,@Excluido
				,@DataFundacao

			SET @CondominioID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_CONDOMINIO SET
			 Nome = ISNULL(@Nome, Nome)
			,QtdBlocos = ISNULL(@QtdBlocos, QtdBlocos)
			,Endereco = ISNULL(@Endereco, Endereco)
			,CEP = ISNULL(@CEP, CEP)
			,Bairro = ISNULL(@Bairro, Bairro)
			,CidadeID = ISNULL(@CidadeID, CidadeID)
			,Excluido = ISNULL(@Excluido, Excluido)
		WHERE
			CondominioID = @CondominioID
	END

	SELECT @CondominioID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_ESTACIONAMENTO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de estacionamento com filtros base de dados
* Data Criação: 05/09/2017
* Autor: Rafael Marques
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_ESTACIONAMENTO_GET]
(
	 @EstacionamentoID INT = NULL
	,@CondominioID INT = NULL
	,@BlocoID INT = NULL
)
AS
BEGIN
	SELECT
		 EstacionamentoID
		,Nome
		,QtdVagas
		,TipoEstacionamento
		,Excluido
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		UVW_ESTACIONAMENTO
	WHERE
		dbo.UVW_ESTACIONAMENTO.EstacionamentoID = COALESCE(@EstacionamentoID, EstacionamentoID)
	AND
		dbo.UVW_ESTACIONAMENTO.CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		dbo.UVW_ESTACIONAMENTO.BlocoID = COALESCE(@BlocoID, BlocoID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_ESTACIONAMENTO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de ESTACIONAMENTO na base de dados
* Data Criação: 05/09/2017
* Autor:Rafael Marques
*********************
**Alterações
* Motivo: Add o campo excluido
* Data Alteração: 05/11/2017 
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_ESTACIONAMENTO_SET]
(
	 @EstacionamentoID INT = 0
	,@Nome VARCHAR(150)
	,@QtdVagas INT
	,@TipoEstacionamento CHAR(1) = NULL
	,@CondominioID INT = NULL
	,@BlocoID INT = NULL
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @CondominioID = 0
	BEGIN
		SET @CondominioID = NULL
	END 

	IF @BlocoID = 0
	BEGIN
		SET @BlocoID = NULL
	END 

	IF @EstacionamentoID = 0
	BEGIN
		INSERT INTO TB_ESTACIONAMENTO
		(
			  Nome	
			 ,QtdVagas
			 ,TipoEstacionamento
			 ,CondominioID
			 ,BlocoID
			 ,Excluido
		)SELECT
			 @Nome
			,@QtdVagas
			,@TipoEstacionamento
			,@CondominioID
			,@BlocoID
			,@Excluido

		SET @EstacionamentoID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_ESTACIONAMENTO SET
			 Nome = @Nome
			,QtdVagas = @QtdVagas
			,TipoEstacionamento = @TipoEstacionamento
			,CondominioID = @CondominioID
			,BlocoID = @BlocoID
			,Excluido = @Excluido 
		WHERE
			EstacionamentoID = @EstacionamentoID
	END

	SELECT @EstacionamentoID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_ESTADO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de ESTADOs com filtros base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_ESTADO_GET]
(
	 @EstadoID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@UF VARCHAR(2) = NULL
)
AS
BEGIN
	SELECT
		  Id
		 ,Name Nome
		 ,UF
	FROM
		UVW_ESTADO
	WHERE
		 Id = COALESCE(@EstadoID, Id)
	AND
		 Name = COALESCE(@Nome, Name)
	AND
		 UF = COALESCE(@UF, UF)
	ORDER BY
		UF
END

GO
/****** Object:  StoredProcedure [dbo].[USP_FUNCIONALIDADE_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de funcionalidade com filtros base de dados
* Data Criação: 29/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_FUNCIONALIDADE_GET]
(
	 @FuncionalidadeID INT = NULL
	,@AreaFuncionalidade VARCHAR(150) = NULL
	,@Codigo INT = NULL
)
AS
BEGIN
	SELECT DISTINCT
		 FuncionalidadeID
		,Descricao
		,AreaFuncionalidade
		,Codigo
		,Excluido
	FROM
		UVW_FUNCIONALIDADE F
	WHERE
		F.FuncionalidadeID = COALESCE(@FuncionalidadeID, F.FuncionalidadeID)
	AND
		F.AreaFuncionalidade = COALESCE(@AreaFuncionalidade, F.AreaFuncionalidade)
	AND
		Codigo = COALESCE(@Codigo, Codigo)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_HORARIO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de Horario com filtros base de dados
* Data Criação: 11/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_HORARIO_GET]
(
	  @HorarioID INT = NULL
	 ,@AreaID INT = NULL
	 ,@Reservado BIT = NULL
)
AS
BEGIN
	SELECT
		 HorarioID
		,HoraInicio
		,HoraFim
		,Excluido
		,Reservado
		,AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		UVW_HORARIO
	WHERE
		 HorarioID = COALESCE(@HorarioID, HorarioID)
	AND
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		 Reservado = COALESCE(@Reservado, Reservado)
		
END

GO
/****** Object:  StoredProcedure [dbo].[USP_HORARIO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de HORARIO na base de dados
* Data Criação: 11/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_HORARIO_SET]
(
	 @HorarioID INT = 0
	,@HoraInicio VARCHAR(50)
	,@HoraFim VARCHAR(50) = NULL
	,@Excluido BIT = 0
	,@AreaID INT
	,@Reservado BIT = 0
)
AS
BEGIN

	IF @HORARIOID = 0
	BEGIN
		IF NOT EXISTS (select count(1) from tb_horario where HoraInicio = @HoraInicio and HoraFim = @HoraFim and AreaID = @AreaID)
		BEGIN
				INSERT INTO TB_HORARIO
				(
					 HoraInicio
					,HoraFim
					,Excluido
					,AreaID
					,Reservado
				)SELECT
					 @HoraInicio
					,@HoraFim
					,@Excluido
					,@AreaID
					,@Reservado

				SET @HorarioID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_HORARIO SET
			 HoraInicio = @HoraInicio
			,HoraFim = @HoraFim
			,Excluido = @Excluido
			,AreaID = @AreaID
			,Reservado = @Reservado
		WHERE
			HorarioID = @HorarioID
	END

	SELECT @HorarioID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_IS_ESTACIONAMENTO_COND_BLOC]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Verifica se o condominio ou o bloco especificado possui estacionamento
* Data Criação: 05/11/2017
* Autor:Euler Vital
*********************
**Alterações
* Motivo: 
* Data 
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_IS_ESTACIONAMENTO_COND_BLOC]
(
	 @CondominioID INT = NULL
	,@BlocoID INT = NULL
)
AS
BEGIN

	SELECT	
		 NomeCondominio
		,CondominioID
		,NomeBloco
		,BlocoID
	FROM	
		UVW_VAGA_ESTACIONAMENTO
	WHERE
		CondominioID = @CondominioID
	AND
		BlocoID = @BlocoID
END

GO
/****** Object:  StoredProcedure [dbo].[USP_LOGAR_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: loga no sistema com filtros base de dados
* Data Criação: 26/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_LOGAR_GET]
(
	  @NomeUser VARCHAR(20) = NULL
	 ,@Senha VARCHAR(20) = NULL 
)
AS
BEGIN
	SELECT
		 UsuarioID
		,NomeUser
		,Senha
		,Email
	FROM
		UVW_USUARIO
	WHERE
		 NomeUser = @NomeUser
	AND
		 Senha = @Senha
END

GO
/****** Object:  StoredProcedure [dbo].[USP_MORADOR_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de moradores com filtros base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_MORADOR_GET]
(
	 @MoradorID INT = NULL
	,@Nome VARCHAR(100) = NULL
	,@ApartamentoID INT = NULL
	,@VagaEstacionamentoID INT = NULL
	,@CondominioID INT = NULL
)
AS
BEGIN
	SELECT
		 MoradorID
		,Nome
		,RG
		,CPF
		,Email
		,CaminhoImagem
		,UltimoNome
		,DataNascimento
		,IsResponsavel
		,Senha
		,Excluido
		,EstacionamentoID
		,NomeEstacionamento
		,QtdVagas
		,TipoEstacionamento
		,ApartamentoID
		,NumeroApartamento
		,ValorApartamento
		,AndarPredio
		,IsCadAutomatico
		,TipoEstadiaID
		,TipoEstadiaNome
		,ValorFixo
		,TipoEstadiaExcluido
		,PredioID
		,NomePredio
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,ExcluidoBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,DataFundacao
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
		,VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ReservadaAluguel
	FROM
		UVW_MORADOR
	WHERE
		 MoradorID = COALESCE(@MoradorID, MoradorID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		ApartamentoID = COALESCE(@ApartamentoID, ApartamentoID)
	AND
		VagaEstacionamentoID = COALESCE(@VagaEstacionamentoID, VagaEstacionamentoID)
	AND
		CondominioID = COALESCE(@CondominioID,CondominioID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_MORADOR_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de moradores na base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_MORADOR_SET]
(
	 @MoradorID INT = 0
	,@Nome VARCHAR(100)
	,@RG VARCHAR(20) = NULL
	,@CPF VARCHAR(20) = NULL
	,@Email VARCHAR(200) = NULL
	,@CaminhoImagem VARCHAR(MAX) = NULL
	,@ApartamentoID INT = NULL
	,@UltimoNome VARCHAR(50) = NULL
	,@DataNascimento DATE
	,@VagaEstacionamentoID INT = NULL
	,@IsResponsavel BIT = 0
	,@Excluido BIT = 0
	,@Senha VARCHAR(20) = NULL
)
AS
BEGIN
	IF @MoradorID = 0
	BEGIN
		IF(select count(1) from UVW_MORADOR where CPF = @CPF and ApartamentoID = @ApartamentoID) = 0
		BEGIN
			INSERT INTO TB_MORADOR
			(
				 Nome
				,RG
				,CPF
				,Email
				,CaminhoImagem
				,ApartamentoID
				,UltimoNome
				,DataNascimento
				,VagaEstacionamentoID
				,IsResponsavel
				,Excluido
				,Senha
			)SELECT
				 @Nome
				,@RG
				,@CPF
				,@Email
				,@CaminhoImagem
				,@ApartamentoID
				,@UltimoNome
				,@DataNascimento
				,@VagaEstacionamentoID
				,@IsResponsavel
				,@Excluido
				,@CPF

			SET @MoradorID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_MORADOR SET
			 Nome = @Nome
			,RG = @RG
			,CPF = @CPF
			,Email = @Email
			,CaminhoImagem = @CaminhoImagem
			,ApartamentoID = @ApartamentoID
			,UltimoNome = @UltimoNome
			,DataNascimento = @DataNascimento
			,VagaEstacionamentoID = @VagaEstacionamentoID
			,IsResponsavel = @IsResponsavel
			,Excluido = @Excluido
			,Senha = @Senha
		WHERE
			MoradorID = @MoradorID
	END

	SELECT @MoradorID
END

GO
/****** Object:  StoredProcedure [dbo].[USP_PESSOAS_RESERVA_DEL]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: deletar dados de pessoas reserva
* Data Criação: 20/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PESSOAS_RESERVA_DEL]
(
	 @PessoaReservaID INT
)
AS
BEGIN
	DELETE 
	FROM 
		TB_PESSOAS_RESERVA 
	WHERE 
		PessoaReservaID = @PessoaReservaID

	DECLARE @Deletou BIT = 0

	IF(select count(1) from tb_pessoas_reserva where pessoaReservaID = @PessoaReservaID) = 0 
	BEGIN
		SET @Deletou = 1
	END

	SELECT @Deletou Deletou
END

GO
/****** Object:  StoredProcedure [dbo].[USP_PESSOAS_RESERVA_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de pessoas reserva com filtros base de dados
* Data Criação: 15/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PESSOAS_RESERVA_GET]
(
	 @PessoaReservaID INT = NULL
	,@ReservaAreaID INT = NULL
	,@MoradorID INT = NULL
	,@AreaID INT = NULL
)
AS
BEGIN
	SELECT
		 PessoaReservaID
		,Nome
		,CPF
		,RG
		,IsMenorIdade
		,ResponsavelID
		,TipoPagamento
		,ReservaAreaID
		,DataReserva
		,MoradorID
		,NomeMorador
		,RgMorador
		,CpfMorador
		,Email
		,CaminhoImagem
		,UltimoNome
		,LoginSite
		,DataNascimento
		,Excluido
		,IsResponsavel
		,AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		UVW_PESSOAS_RESERVA
	WHERE
		 PessoaReservaID = COALESCE(@PessoaReservaID, PessoaReservaID)
	AND
		 MoradorID = COALESCE(@MoradorID, MoradorID)
	AND
		 AreaID = COALESCE(@AreaID, AreaID)
	AND
		ReservaAreaID = COALESCE(@ReservaAreaID, ReservaAreaID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_PESSOAS_RESERVA_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de pessoa reserva na base de dados
* Data Criação: 15/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PESSOAS_RESERVA_SET]
(
	 @PessoaReservaID INT = 0
	,@Nome VARCHAR(200)
	,@CPF VARCHAR(50) = NULL
	,@RG VARCHAR(50) = NULL
	,@IsMenorIdade BIT = 0
	,@ResponsavelID  INT = NULL
	,@TipoPagamento VARCHAR(200) = NULL
	,@ReservaAreaID INT
)
AS
BEGIN

	IF @PessoaReservaID = 0
	BEGIN
		IF(select count(1) from TB_PESSOAS_RESERVA where CPF = @CPF and ReservaAreaID = @ReservaAreaID) = 0
		BEGIN
			INSERT INTO TB_PESSOAS_RESERVA
			(
				 Nome
				,CPF
				,RG
				,IsMenorIdade
				,ResponsavelID
				,TipoPagamento
				,ReservaAreaID
			)SELECT
			     @Nome
				,@CPF
				,@RG
				,@IsMenorIdade
				,@ResponsavelID
				,@TipoPagamento
				,@ReservaAreaID

			SET @PessoaReservaID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_PESSOAS_RESERVA SET
			 Nome = @Nome
			,CPF = @CPF
			,RG = @RG
			,IsMenorIdade = @IsMenorIdade
			,ResponsavelID = @ResponsavelID
			,TipoPagamento = @TipoPagamento
			,ReservaAreaID = @ReservaAreaID
		WHERE
			PessoaReservaID = @PessoaReservaID
	END

	SELECT @PessoaReservaID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_PREDIO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de predios com filtros base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PREDIO_GET]
(
	 @PredioID INT  = NULL
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@BlocoID INT = NULL
	,@NomeBloco VARCHAR(150) = NULL
	,@CondominioID INT = NULL
	,@NomeCondominio VARCHAR(150) = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN
	SELECT
		 PredioID
		,Nome
		,QtdApartamentos
		,Excluido
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,DataFundacao
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		UVW_PREDIO
	WHERE
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_PREDIO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de predios na base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PREDIO_SET]
(
	 @PredioID INT = 0
	,@Nome VARCHAR(150) = NULL
	,@QtdApartamentos INT = NULL
	,@Excluido BIT = 0
	,@BlocoID INT = NULL
)
AS
BEGIN

	IF @PredioID = 0
	BEGIN
		INSERT INTO TB_PREDIO
		(
			 Nome
			,QtdApartamentos
			,BlocoID
			,Excluido
		)SELECT
				@Nome
			,@QtdApartamentos
			,@BlocoID
			,@Excluido

		SET @PredioID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_PREDIO SET
			 Nome = @Nome
			,QtdApartamentos = @QtdApartamentos
			,BlocoID = @BlocoID
			,Excluido = @Excluido
		WHERE
			PredioID = @PredioID
	END

	SELECT @PredioID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_PROFISSAO_DEL]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: deleta profissão da base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PROFISSAO_DEL]
(
	 @ProfissaoID INT
)
AS
BEGIN
	DELETE FROM 
		TB_PROFISSAO 
	WHERE 
		ProfissaoID = @ProfissaoID
END

GO
/****** Object:  StoredProcedure [dbo].[USP_PROFISSAO_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de profissao com filtros base de dados
* Data Criação: 17/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PROFISSAO_GET]
(
	 @ProfissaoID INT = NULL
	,@Nome VARCHAR(150) = NULL
	,@Area VARCHAR(150) = NULL
	,@Descricao VARCHAR(300) = NULL
)
AS
BEGIN
	SELECT
		 ProfissaoID
		,Nome
		,Area
		,Descricao
	FROM
		UVW_PROFISSAO
	WHERE
		 ProfissaoID = COALESCE(@ProfissaoID, ProfissaoID)
	AND
		 Nome = COALESCE(@Nome, Nome)
	AND
		 Area = COALESCE(@Area, Area)
	AND
		 Descricao = COALESCE(@Descricao, Descricao)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_PROFISSAO_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de profissão na base de dados
* Data Criação: 12/08/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_PROFISSAO_SET]
(
	 @ProfissaoID INT = 0
	,@Nome VARCHAR(150) = NULL
	,@Area VARCHAR(150) = NULL
	,@Descricao VARCHAR(300) = NULL
)
AS
BEGIN

	IF @ProfissaoID = 0
	BEGIN
		IF(select count(1) from TB_PROFISSAO where Nome = @Nome and Area = @Area) = 0
		BEGIN
			INSERT INTO TB_PROFISSAO
			(
				 Nome
				,Area
				,Descricao
			)SELECT
				 @Nome
				,@Area
				,@Descricao

			SET @ProfissaoID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_PROFISSAO SET
			 Nome = @Nome
			,Area = @Area
			,Descricao = @Descricao
		WHERE
			ProfissaoID = @ProfissaoID
	END

	SELECT @ProfissaoID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_RESERVAR_AREA_DEL]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_RESERVAR_AREA_DEL]
(
	@ReservaAreaID INT  = NULL
)
AS
BEGIN

	--PEGANDO DATA ATUAL
	DECLARE @DataAtual DATE = GETDATE()
	DECLARE @Deletou BIT = 0

	--PEGANDO RESERVAS FEITAS ANTES DA DATA ATUAL E JOGANDO NA TABELA TEMPORARIA
	CREATE TABLE #RESERVAS
	(
		 ReservaAreaID INT
		,AreaID INT
		,HorarioID INT
	)

	IF @ReservaAreaID IS NULL
	BEGIN
		INSERT INTO #RESERVAS
		SELECT
			 RA.ReservaAreaID
			,RA.AreaID
			,HO.HorarioID
		FROM
			UVW_RESERVAR_AREA RA
		JOIN
			UVW_HORARIO HO
		ON
			RA.AreaID = HO.AreaID
		WHERE 
			DataReserva < @DataAtual

		IF (select count(1) from #reservas) > 0
		BEGIN
			SET @Deletou = 1
		END

		--APAGANDO PESSOAS NÃO RESPONSAVEIS RELACIONADAS A ÁREAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID in (select reservaareaid from #reservas) and ResponsavelID IS NOT NULL
		--APAGANDO PESSOAS RESPONSAVEIS RELACIONADAS A ÁREAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID in (select reservaareaid from #reservas) and ResponsavelID IS NULL
		--APAGANDO PESSOAS NÃO RESPONSAVEIS RELACIONADAS A ÁREAS RESERVADAS
		DELETE FROM TB_RESERVAR_AREA WHERE ReservaAreaID in (select reservaareaid from #reservas)
	END
	ELSE
	BEGIN

		--APAGANDO PESSOAS NÃO RESPONSAVEIS RELACIONADAS A ÁREAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID = @ReservaAreaID and ResponsavelID IS NOT NULL
		--APAGANDO PESSOAS RESPONSAVEIS RELACIONADAS A ÁREAS RESERVADAS
		DELETE FROM TB_PESSOAS_RESERVA WHERE ReservaAreaID = @ReservaAreaID and ResponsavelID IS NULL
		--APAGANDO PESSOAS NÃO RESPONSAVEIS RELACIONADAS A ÁREAS RESERVADAS
		DELETE FROM TB_RESERVAR_AREA WHERE ReservaAreaID = @ReservaAreaID	
		
		IF (select count(1) from tb_reservar_area where ReservaAreaID = @ReservaAreaID) = 0
		BEGIN
			SET @Deletou = 1	
		END
	END

	SELECT @Deletou Deletou

END

GO
/****** Object:  StoredProcedure [dbo].[USP_RESERVAR_AREA_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de reservar area com filtros base de dados
* Data Criação: 15/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_RESERVAR_AREA_GET]
(
	 @ReservaAreaID INT = NULL
	,@MoradorID INT = NULL
	,@AreaID INT = NULL
)
AS
BEGIN
	SELECT
		 ReservaAreaID
		,DataReserva
		,MoradorID
		,Nome
		,RG
		,CPF
		,Email
		,CaminhoImagem
		,UltimoNome
		,LoginSite
		,DataNascimento
		,Excluido
		,IsResponsavel
		,ApartamentoID
		,NumeroApartamento
		,ValorApartamento
		,AndarPredio
		,IsCadAutomatico
		,TipoEstadiaID
		,TipoEstadiaNome
		,ValorFixo
		,TipoEstadiaExcluido
		,PredioID
		,NomePredio
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,ExcluidoBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,DataFundacao
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
		,VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ReservadaAluguel
		,EstacionamentoID
		,NomeEstacionamento
		,QtdVagas
		,TipoEstacionamento
		,AreaID
		,NomeArea
		,TipoArea
		,ModoUso
		,IsAreaPaga
		,ValorArea
		,Status
	FROM
		UVW_RESERVAR_AREA
	WHERE
		 ReservaAreaID = COALESCE(@ReservaAreaID, ReservaAreaID)
	AND
		 MoradorID = COALESCE(@MoradorID, MoradorID)
	AND
		 AreaID = COALESCE(@AreaID, AreaID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_RESERVAR_AREA_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de reserva area na base de dados
* Data Criação: 15/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_RESERVAR_AREA_SET] 
(
	 @ReservaAreaID INT = 0
	,@DataReserva DATE = NULL
	,@MoradorID INT
	,@AreaID INT 
)
AS
BEGIN

	IF @ReservaAreaID = 0
	BEGIN
		IF(select count(1) from TB_RESERVAR_AREA ra join tb_horario h on h.areaid = ra.areaid where MoradorID = @MoradorID and ra.AreaID = @AreaID and dataReserva = @DataReserva and h.reservado = 0) = 0
		BEGIN 
			INSERT INTO TB_RESERVAR_AREA
			(
				 DataReserva
				,MoradorID
				,AreaID
			)SELECT
				@DataReserva
			   ,@MoradorID
			   ,@AreaID

			SET @ReservaAreaID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_RESERVAR_AREA SET
			 DataReserva = @DataReserva
			,MoradorID = @MoradorID
			,AreaID = @AreaID
		WHERE
			ReservaAreaID = @ReservaAreaID
	END

	SELECT @ReservaAreaID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_SITE_LOGAR_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Logora no site
* Data Criação: 02/12/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_SITE_LOGAR_GET]
(
	 @Login VARCHAR(200)
	,@Senha VARCHAR(200)
)
AS
BEGIN
	SELECT
		 MoradorID
		,Nome
		,RG
		,CPF
		,Email
		,CaminhoImagem
		,UltimoNome
		,LoginSite
		,DataNascimento
		,IsResponsavel
		,Senha
		,Excluido
		,EstacionamentoID
		,NomeEstacionamento
		,QtdVagas
		,TipoEstacionamento
		,ApartamentoID
		,NumeroApartamento
		,ValorApartamento
		,AndarPredio
		,IsCadAutomatico
		,TipoEstadiaID
		,TipoEstadiaNome
		,ValorFixo
		,TipoEstadiaExcluido
		,PredioID
		,NomePredio
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,ExcluidoBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,DataFundacao
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
		,VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ReservadaAluguel
	FROM
		UVW_MORADOR
	WHERE
		 UPPER(LoginSite) = UPPER(@Login)
	AND
		Senha = REPLACE(REPLACE(@Senha, '.',''), '-','')
END

GO
/****** Object:  StoredProcedure [dbo].[USP_TELEFONE_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de telefone com filtros base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_TELEFONE_GET]
(
	 @TelefoneID INT = NULL
	,@TipoTelefoneID VARCHAR(150) = NULL
	,@Contato VARCHAR(50) = NULL
	,@MoradorID INT = NULL
)
AS
BEGIN
	SELECT DISTINCT
		 T.TelefoneID
		,Contato
		,ISNULL(Excluido, 0) Excluido
		,ISNULL(TipoTelefoneID, 0) TipoTelefoneID
		,ISNULL(TipoTelefone, 'ND') TipoTelefone
		,ISNULL(TipoTelefoneExcluido, 0) TipoTelefoneExcluido
		,TM.MoradorID
		,TM.Nome
		,TM.UltimoNome
	FROM
		UVW_TELEFONE T
	JOIN
		UVW_TELEFONE_MORADOR TM
	ON
		T.TelefoneID = TM.TelefoneID
	WHERE
		T.TelefoneID = COALESCE(@TelefoneID, T.TelefoneID)
	AND
		Contato = COALESCE(@Contato, Contato)
	AND
		TipoTelefoneID = COALESCE(@TipoTelefoneID, TipoTelefoneID)
	AND 
		TM.MoradorID = COALESCE(@MoradorID, TM.MoradorID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_TELEFONE_SET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de telefone na base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_TELEFONE_SET] 
(
	 @TelefoneID INT = 0
	,@Contato VARCHAR(150) = NULL
	,@TipoTelefoneID INT = NULL
	,@Excluido BIT = NULL
	,@MoradorID INT
)
AS
BEGIN

	DECLARE @contact INT = (select TOP 1 TelefoneID from tb_telefone where Contato = @Contato)

	IF @MoradorID IS NOT NULL
	BEGIN
		IF @TelefoneID = 0
		BEGIN
			IF @contact IS NULL
			BEGIN
				INSERT INTO TB_TELEFONE
				(
					 Contato
					,TipoTelefoneID
					,Excluido
				)SELECT
					 @Contato
					,@TipoTelefoneID
					,@Excluido

				SET @TelefoneID = @@IDENTITY

				INSERT INTO TB_TELEFONE_MORADOR
				SELECT
					 @TelefoneID
					,@MoradorID
			END
			ELSE
			BEGIN
				INSERT INTO TB_TELEFONE_MORADOR
				SELECT
					 @contact
					,@MoradorID

				SET @TelefoneID = @contact
			END
		END
		ELSE
		BEGIN
			UPDATE TB_TELEFONE SET
				 Contato = @Contato
				,TipoTelefoneID = @TipoTelefoneID
				,Excluido = @Excluido
			WHERE
				TelefoneID = @TelefoneID
		END
	END

	SELECT @TelefoneID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_TIPO_TELEFONE_GET]    Script Date: 04/12/2017 20:11:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo_telefone com filtros base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_TIPO_TELEFONE_GET]
(
	 @TipoTelefoneID INT = NULL
)
AS
BEGIN
	SELECT
		 TipoTelefoneID
		,Descricao
		,Excluido
	FROM
		UVW_TIPO_TELEFONE T
	WHERE
		T.TipoTelefoneID = COALESCE(@TipoTelefoneID, T.TipoTelefoneID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_TIPO_TELEFONE_SET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de tipo_telefone na base de dados
* Data Criação: 21/10/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_TIPO_TELEFONE_SET]
(
	 @TipoTelefoneID INT = 0
	,@Descricao VARCHAR(50) = NULL
	,@Excluido BIT = NULL
)
AS
BEGIN

	IF @TipoTelefoneID = 0 AND (select count(1) from tb_tipo_telefone where Descricao = @Descricao) = 0
	BEGIN
		INSERT INTO TB_TIPO_TELEFONE
		(
			 Descricao
			,Excluido
		)SELECT
			 @Descricao
			,@Excluido

		SET @TipoTelefoneID = @@IDENTITY
	END
	ELSE
	BEGIN
		UPDATE TB_TIPO_TELEFONE SET
			 Descricao = @Descricao
			,Excluido = @Excluido
		WHERE
			TipoTelefoneID = @TipoTelefoneID
	END

	SELECT @TipoTelefoneID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_TIPOESTADIA_GET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de tipo estadia de apartamentos com filtros base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_TIPOESTADIA_GET]
(
	 @TipoEstadiaID INT  = NULL
	,@Nome VARCHAR(50) = NULL
)
AS
BEGIN
	SELECT
		 TipoEstadiaID
		,Nome
		,ValorFixo
		,Excluido
	FROM
		UVW_TIPOESTADIA
	WHERE
		 TipoEstadiaID = COALESCE(@TipoEstadiaID, TipoEstadiaID)
	AND
		 Nome = COALESCE(@Nome, Nome)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_TIPOESTADIA_SET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de tipo estadia de apartamento na base de dados
* Data Criação: 17/09/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_TIPOESTADIA_SET]
(
	 @TipoEstadiaID INT = 0
	,@Nome VARCHAR(50)
	,@ValorFixo DECIMAL(10,2)
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @TipoEstadiaID = 0
	BEGIN

		IF NOT EXISTS(select * from TB_TIPOESTADIA where Nome = @Nome)
		BEGIN		
			INSERT INTO TB_TIPOESTADIA
			(
				 Nome
				,ValorFixo
				,Excluido
			)SELECT
				 @Nome
				,@ValorFixo
				,@Excluido

			SET @TipoEstadiaID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_TIPOESTADIA SET
			 Nome = @Nome
			,ValorFixo = @ValorFixo
			,Excluido = @Excluido
		WHERE
			TipoEstadiaID = @TipoEstadiaID
	END

	SELECT @TipoEstadiaID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_USUARIO_GET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de usuario com filtros base de dados
* Data Criação: 25/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_USUARIO_GET]
(
	 @UsuarioID INT = NULL
	,@CondominioID INT = NULL
	,@BlocoID INT = NULL
	,@PredioID INT = NULL
)
AS
BEGIN
	SELECT
		 UsuarioID
		,NomeUser
		,Senha
		,Email
		,TipoUsuario
		,Excluido
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,DataFundacao
		,EstadoID
		,EstadoNome
		,UF
		,ExcluidoCondominio
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,PredioID
		,NomePredio
		,QtdApartamentos
	FROM
		UVW_USUARIO
	WHERE
		 UsuarioID = COALESCE(@UsuarioID, UsuarioID)
	AND
		 CondominioID = COALESCE(@CondominioID, CondominioID)
	AND
		 BlocoID = COALESCE(@BlocoID, BlocoID)
	AND
		 PredioID = COALESCE(@PredioID, PredioID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_USUARIO_SET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de usuário na base de dados
* Data Criação: 25/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_USUARIO_SET] 
(
	 @UsuarioID INT = 0
	,@NomeUser VARCHAR(20)
	,@Senha VARCHAR(20)
	,@CondominioID INT = NULL 
	,@TipoUsuario CHAR(1)
	,@Email VARCHAR(200)
	,@BlocoID INT = NULL
	,@PredioID INT = NULL
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @UsuarioID = 0
	BEGIN
		IF(SELECT count(1) FROM tb_usuario WHERE NomeUser = @NomeUser) = 0
		BEGIN 
			INSERT INTO TB_USUARIO
			(
				 NomeUser
				,Senha
				,CondominioID
				,TipoUsuario
				,BlocoID
				,PredioID
				,Excluido
				,Email
			)SELECT
				 @NomeUser
				,@Senha
				,@CondominioID
				,@TipoUsuario
				,@BlocoID
				,@PredioID
				,@Excluido
				,@Email

			SET @UsuarioID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_USUARIO SET
			 NomeUser = @NomeUser
			,Senha = @Senha
			,CondominioID = @CondominioID
			,TipoUsuario = @TipoUsuario
			,BlocoID = @BlocoID
			,PredioID = @PredioID
			,Excluido = @Excluido
			,Email = @Email
		WHERE
			UsuarioID = @UsuarioID
	END

	SELECT @UsuarioID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_VAGA_ESTACIONAMENTO_GET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Retorna dados de vaga estacionamento com filtros base de dados
* Data Criação: 05/11/2017
* Autor: Euler Vital
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_VAGA_ESTACIONAMENTO_GET]
(
	  @VagaEstacionamentoID INT = NULL
	 ,@EstacionamentoID INT = NULL
)
AS
BEGIN
	SELECT
		 VagaEstacionamentoID
		,NumeroVaga
		,TipoVaga
		,ReservadaAluguel
		,EstacionamentoID
		,Excluido
		,Nome
		,QtdVagas
		,TipoEstacionamento
		,ExcluidoEstacionamento
		,BlocoID
		,NomeBloco
		,QtdPredios
		,TipoBloco
		,StatusAtivo
		,CondominioID
		,NomeCondominio
		,QtdBlocos
		,DataFundacao
		,Endereco
		,CEP
		,Bairro
		,CidadeID
		,CidadeNome
		,CondominioExcluido
	FROM
		dbo.UVW_VAGA_ESTACIONAMENTO
	WHERE
		VagaEstacionamentoID = COALESCE(@VagaEstacionamentoID, VagaEstacionamentoID)
	AND
		EstacionamentoID = COALESCE(@EstacionamentoID, EstacionamentoID)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_VAGA_ESTACIONAMENTO_SET]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
--- CONSTRUTORA PIM ----
**CRIAÇÃO
* Motivo: Faz a inserção/alteração de vaga_estacionamento na base de dados
* Data Criação: 05/11/2017
* Autor:Euler Vital
*********************
**Alterações
* Motivo: 
* Data 
* Autor:
*********************
**Alterações
* Motivo:
* Data Criação:
* Autor:
*/

CREATE PROC [dbo].[USP_VAGA_ESTACIONAMENTO_SET]
(
	 @VagaEstacionamentoID INT = 0
	,@NumeroVaga VARCHAR(100)
	,@TipoVaga CHAR(1)
	,@ReservadaAluguel BIT
	,@EstacionamentoID INT
	,@Excluido BIT = 0
)
AS
BEGIN

	IF @VagaEstacionamentoID = 0
	BEGIN
		IF NOT EXISTS(SELECT * FROM dbo.TB_VAGA_ESTACIONAMENTO WHERE NumeroVaga = @NumeroVaga AND EstacionamentoID = @EstacionamentoID)
		BEGIN
			INSERT INTO TB_VAGA_ESTACIONAMENTO
			(
				 NumeroVaga
				,TipoVaga
				,ReservadaAluguel
				,EstacionamentoID
				,Excluido
			)SELECT
				 @NumeroVaga
				,@TipoVaga
				,@ReservadaAluguel
				,@EstacionamentoID
				,@Excluido

			SET @VagaEstacionamentoID = @@IDENTITY
		END
	END
	ELSE
	BEGIN
		UPDATE TB_VAGA_ESTACIONAMENTO SET
			 NumeroVaga = @NumeroVaga
			,TipoVaga = @TipoVaga
			,ReservadaAluguel = @ReservadaAluguel
			,EstacionamentoID = @EstacionamentoID
			,Excluido = @Excluido
		WHERE
			VagaEstacionamentoID = @VagaEstacionamentoID
	END

	SELECT @VagaEstacionamentoID

END

GO
/****** Object:  StoredProcedure [dbo].[USP_VERIFICA_DATA_HORA_RESERVA]    Script Date: 04/12/2017 20:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_VERIFICA_DATA_HORA_RESERVA]
(
	 @HorarioID INT = NULL
	,@AreaID INT = NULL
	,@DataReserva DATE = NULL
)
AS
BEGIN
	SELECT
		HO.Reservado
	FROM
		UVW_RESERVAR_AREA RA
	JOIN
		UVW_HORARIO HO
	ON
		RA.AreaID = HO.AreaID
	WHERE
		RA.AreaID = @AreaID
	AND
		HO.HorarioID = @HorarioID
	AND
		RA.DataReserva = @DataReserva
END

GO
USE [master]
GO
ALTER DATABASE [Construtora] SET  READ_WRITE 
GO
