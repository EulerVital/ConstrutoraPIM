USE [master]
GO
/****** Object:  Database [Construtora]    Script Date: 15/10/2017 13:38:42 ******/
CREATE DATABASE [Construtora]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Construtora', FILENAME = N'E:\Projetos\Bancos\Construtora_\Construtora.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Construtora_log', FILENAME = N'E:\Projetos\Bancos\Construtora_\Construtora_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Construtora] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Construtora].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Construtora] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Construtora] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Construtora] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Construtora] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Construtora] SET ARITHABORT OFF 
GO
ALTER DATABASE [Construtora] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Construtora] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Construtora] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Construtora] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Construtora] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Construtora] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Construtora] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Construtora] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Construtora] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Construtora] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Construtora] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Construtora] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Construtora] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Construtora] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Construtora] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Construtora] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Construtora] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Construtora] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Construtora] SET  MULTI_USER 
GO
ALTER DATABASE [Construtora] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Construtora] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Construtora] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Construtora] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Construtora] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Construtora] SET QUERY_STORE = OFF
GO
USE [Construtora]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Construtora]
GO
/****** Object:  Table [dbo].[TB_ESTADO]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  View [dbo].[UVW_ESTADO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_CIDADE]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_CIDADE]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_TIPOESTADIA]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_TIPOESTADIA]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_PROFISSAO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_PROFISSAO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_APARTAMENTO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_PREDIO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_BLOCO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_CONDOMINIO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_CONDOMINIO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_BLOCO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_PREDIO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  View [dbo].[UVW_APARTAMENTO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_ESTACIONAMENTO]    Script Date: 15/10/2017 13:38:42 ******/
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
PRIMARY KEY CLUSTERED 
(
	[EstacionamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[UVW_ESTACIONAMENTO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_AREA]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AREA](
	[AreaID] [int] IDENTITY(1,1) NOT NULL,
	[NomeArea] [varchar](100) NOT NULL,
	[TipoArea] [varchar](50) NOT NULL,
	[ModoUso] [char](1) NOT NULL,
	[IsAreaPaga] [bit] NOT NULL,
	[ValorArea] [decimal](18, 0) NULL,
	[StatusAtivo] [bit] NOT NULL,
	[CondominioID] [int] NULL,
	[HorarioID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_CORRESPONDENCIA]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_FUNCIONALIDADE]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_FUNCIONALIDADE](
	[FuncionalidadeID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[AreaFuncionalidade] [varchar](50) NOT NULL,
	[Excluido] [bit] NOT NULL,
	[UsuarioID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FuncionalidadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_FUNCIONARIO]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_HORARIO]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_HORARIO](
	[HorarioID] [int] IDENTITY(1,1) NOT NULL,
	[HoraInicio] [varchar](50) NOT NULL,
	[HoraFim] [varchar](50) NULL,
	[Excluido] [bit] NOT NULL,
	[AreaID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[HorarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_MORADOR]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_MORADOR](
	[MoradorID] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](100) NOT NULL,
	[RG] [varchar](20) NULL,
	[CPF] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[CaminhoImagem] [varchar](max) NULL,
	[TelefoneID] [int] NULL,
	[VisitanteID] [int] NULL,
	[EstacionamentoID] [int] NULL,
	[ApartamentoID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MoradorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_PAIS]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_RESERVAR_AREA]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_RESERVAR_AREA](
	[ReservaAreaID] [int] IDENTITY(1,1) NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[MoradorID] [int] NOT NULL,
	[AreaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReservaAreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_TELEFONE]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_TIPO_CORRESPONDENCIA]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_TIPO_TELEFONE]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  Table [dbo].[TB_USUARIO]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_USUARIO](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[NomeUser] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[Sexo] [bit] NOT NULL,
	[CondominioID] [int] NULL,
	[TipoUsuario] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_VAGA_ESTACIONAMENTO]    Script Date: 15/10/2017 13:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_VAGA_ESTACIONAMENTO](
	[VagaEstacionamentoID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroVaga] [varchar](100) NOT NULL,
	[TipoVaga] [bit] NOT NULL,
	[ResevadaAluguel] [bit] NULL,
	[EstacionamentoID] [int] NULL,
	[MoradorID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[VagaEstacionamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_VISITANTE]    Script Date: 15/10/2017 13:38:42 ******/
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
ALTER TABLE [dbo].[TB_AREA] ADD  DEFAULT ((1)) FOR [StatusAtivo]
GO
ALTER TABLE [dbo].[TB_BLOCO] ADD  DEFAULT ((1)) FOR [StatusAtivo]
GO
ALTER TABLE [dbo].[TB_CONDOMINIO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_FUNCIONALIDADE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_HORARIO] ADD  DEFAULT ((1)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_PREDIO] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_TELEFONE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_TIPO_TELEFONE] ADD  DEFAULT ((0)) FOR [Excluido]
GO
ALTER TABLE [dbo].[TB_TIPOESTADIA] ADD  DEFAULT ((0)) FOR [Excluido]
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
ALTER TABLE [dbo].[TB_AREA]  WITH CHECK ADD FOREIGN KEY([HorarioID])
REFERENCES [dbo].[TB_HORARIO] ([HorarioID])
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
ALTER TABLE [dbo].[TB_ESTACIONAMENTO]  WITH CHECK ADD FOREIGN KEY([BlocoID])
REFERENCES [dbo].[TB_BLOCO] ([BlocoID])
GO
ALTER TABLE [dbo].[TB_ESTACIONAMENTO]  WITH CHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_ESTADO]  WITH CHECK ADD  CONSTRAINT [FK_TB_ESTADO_TB_PAIS] FOREIGN KEY([IdTB_PAIS])
REFERENCES [dbo].[TB_PAIS] ([Id])
GO
ALTER TABLE [dbo].[TB_ESTADO] CHECK CONSTRAINT [FK_TB_ESTADO_TB_PAIS]
GO
ALTER TABLE [dbo].[TB_FUNCIONALIDADE]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
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
ALTER TABLE [dbo].[TB_MORADOR]  WITH CHECK ADD FOREIGN KEY([EstacionamentoID])
REFERENCES [dbo].[TB_ESTACIONAMENTO] ([EstacionamentoID])
GO
ALTER TABLE [dbo].[TB_MORADOR]  WITH CHECK ADD FOREIGN KEY([TelefoneID])
REFERENCES [dbo].[TB_TELEFONE] ([TelefoneID])
GO
ALTER TABLE [dbo].[TB_MORADOR]  WITH CHECK ADD FOREIGN KEY([VisitanteID])
REFERENCES [dbo].[TB_VISITANTE] ([VisitanteID])
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
ALTER TABLE [dbo].[TB_TELEFONE]  WITH CHECK ADD FOREIGN KEY([TipoTelefoneID])
REFERENCES [dbo].[TB_TIPO_TELEFONE] ([TipoTelefoneID])
GO
ALTER TABLE [dbo].[TB_USUARIO]  WITH CHECK ADD FOREIGN KEY([CondominioID])
REFERENCES [dbo].[TB_CONDOMINIO] ([CondominioID])
GO
ALTER TABLE [dbo].[TB_VAGA_ESTACIONAMENTO]  WITH CHECK ADD FOREIGN KEY([EstacionamentoID])
REFERENCES [dbo].[TB_ESTACIONAMENTO] ([EstacionamentoID])
GO
ALTER TABLE [dbo].[TB_VAGA_ESTACIONAMENTO]  WITH CHECK ADD FOREIGN KEY([MoradorID])
REFERENCES [dbo].[TB_MORADOR] ([MoradorID])
GO
ALTER TABLE [dbo].[TB_VISITANTE]  WITH CHECK ADD FOREIGN KEY([EstacionamentoID])
REFERENCES [dbo].[TB_ESTACIONAMENTO] ([EstacionamentoID])
GO
ALTER TABLE [dbo].[TB_VISITANTE]  WITH CHECK ADD FOREIGN KEY([TelefoneID])
REFERENCES [dbo].[TB_TELEFONE] ([TelefoneID])
GO
/****** Object:  StoredProcedure [dbo].[Qtd]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_APARTAMENTO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
)
AS
BEGIN
	SELECT
		 ApartamentoID
		,NumeroApartamento
		,TipoEstadiaID
		,TipoEstadiaNome
		,ValorFixo
		,IsCadAutomatico
		,TipoEstadiaExcluido
		,AndarPredio
		,ValorApartamento
		,PredioID
		,Nome
		,QtdApartamentos
		,BlocoID
		,NomeBloco
		,Excluido
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
	FROM
		UVW_APARTAMENTO
	WHERE
		 ApartamentoID = COALESCE(@ApartamentoID, ApartamentoID)
	AND
		 PredioID = COALESCE(@PredioID, PredioID)
	AND
		 Nome = COALESCE(@NomePredio, Nome)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_APARTAMENTO_SET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_BLOCO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_BLOCO_SET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_CIDADE_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_CONDOMINIO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_CONDOMINIO_SET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_ESTACIONAMENTO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
	,@Nome VARCHAR(150) = NULL
	,@QtdVagas INT = NULL
	,@TipoEstacionamento CHAR(1) = NULL
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
	--WHERE
	--	 EstacionamentoID = COALESCE(@EstacionamentoID, EstacionamentoID)
	--AND
	--	 Nome = COALESCE(@Nome, Nome)
	--AND
	--	 BlocoID = COALESCE(@BlocoID, BlocoID)
	--AND
	--	 CondominioID = COALESCE(@CondominioID, CondominioID)
	--AND
	--	 TipoEstacionamento = COALESCE(@TipoEstacionamento, TipoEstacionamento)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_ESTADO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_PREDIO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_PREDIO_SET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_PROFISSAO_DEL]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_PROFISSAO_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_PROFISSAO_SET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_TIPOESTADIA_GET]    Script Date: 15/10/2017 13:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[USP_TIPOESTADIA_SET]    Script Date: 15/10/2017 13:38:42 ******/
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
USE [master]
GO
ALTER DATABASE [Construtora] SET  READ_WRITE 
GO
