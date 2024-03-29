USE [master]
GO
/****** Object:  Database [BDHistorial]    Script Date: 8/11/2019 6:40:58 PM ******/
CREATE DATABASE [BDHistorial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDHistorial', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDHistorial.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDHistorial_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BDHistorial_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDHistorial] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDHistorial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDHistorial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDHistorial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDHistorial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDHistorial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDHistorial] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDHistorial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDHistorial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDHistorial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDHistorial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDHistorial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDHistorial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDHistorial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDHistorial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDHistorial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDHistorial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDHistorial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDHistorial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDHistorial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDHistorial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDHistorial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDHistorial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDHistorial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDHistorial] SET RECOVERY FULL 
GO
ALTER DATABASE [BDHistorial] SET  MULTI_USER 
GO
ALTER DATABASE [BDHistorial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDHistorial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDHistorial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDHistorial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDHistorial] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDHistorial', N'ON'
GO
ALTER DATABASE [BDHistorial] SET QUERY_STORE = OFF
GO
USE [BDHistorial]
GO
/****** Object:  Table [dbo].[Busquedas]    Script Date: 8/11/2019 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Busquedas](
	[URL] [nvarchar](500) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[PRABuscarHistorial]    Script Date: 8/11/2019 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRABuscarHistorial]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Busquedas;
END
GO
/****** Object:  StoredProcedure [dbo].[PRAInsertarBusqueda]    Script Date: 8/11/2019 6:40:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PRAInsertarBusqueda]
	@URL nvarchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Busquedas (URL) values (@URL);
END
GO
USE [master]
GO
ALTER DATABASE [BDHistorial] SET  READ_WRITE 
GO
