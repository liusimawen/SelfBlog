USE [master]
GO
/****** Object:  Database [BlogDB]    Script Date: 04/15/2019 21:48:32 ******/
CREATE DATABASE [BlogDB] ON  PRIMARY 
( NAME = N'BlogDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\BlogDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BlogDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\BlogDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BlogDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BlogDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BlogDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BlogDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BlogDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BlogDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BlogDB] SET ARITHABORT OFF
GO
ALTER DATABASE [BlogDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [BlogDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BlogDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BlogDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BlogDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BlogDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BlogDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BlogDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BlogDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BlogDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BlogDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [BlogDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BlogDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BlogDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BlogDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BlogDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BlogDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BlogDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BlogDB] SET  READ_WRITE
GO
ALTER DATABASE [BlogDB] SET RECOVERY FULL
GO
ALTER DATABASE [BlogDB] SET  MULTI_USER
GO
ALTER DATABASE [BlogDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BlogDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'BlogDB', N'ON'
GO
USE [BlogDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 04/15/2019 21:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Pwd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON
INSERT [dbo].[Account] ([Id], [CreateTime], [Account], [Name], [Pwd]) VALUES (1, CAST(0x0000AA2F00000000 AS DateTime), N'liusimawen', N'刘文', N'123456')
SET IDENTITY_INSERT [dbo].[Account] OFF
/****** Object:  Table [dbo].[Category]    Script Date: 04/15/2019 21:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](50) NULL,
	[Sequence] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON
INSERT [dbo].[Category] ([Id], [CreateTime], [Title], [Desc], [Sequence]) VALUES (2, CAST(0x0000AA3001607E65 AS DateTime), N'.Net Core介绍', N'.Net Core相关', 1)
INSERT [dbo].[Category] ([Id], [CreateTime], [Title], [Desc], [Sequence]) VALUES (3, CAST(0x0000AA2E008611E0 AS DateTime), N'Go', N'go语言相关', 2)
SET IDENTITY_INSERT [dbo].[Category] OFF
/****** Object:  Table [dbo].[Article]    Script Date: 04/15/2019 21:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[AccountId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Article] ON
INSERT [dbo].[Article] ([Id], [CreateTime], [AccountId], [CategoryId], [Title], [Content]) VALUES (6, CAST(0x0000AA30014E305D AS DateTime), 1, 3, N'Go语言介绍', N'<p style="color:#222222;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
	<b>Go</b>&nbsp;(often referred to as&nbsp;<b>Golang</b><sup id="cite_ref-14" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-14">[14]</a></sup>) is a&nbsp;<a href="https://en.wikipedia.org/wiki/Static_typing" class="mw-redirect">statically typed</a>,&nbsp;<a href="https://en.wikipedia.org/wiki/Compiled_language">compiled</a>&nbsp;<a href="https://en.wikipedia.org/wiki/Programming_language">programming language</a>&nbsp;designed at&nbsp;<a href="https://en.wikipedia.org/wiki/Google">Google</a><sup id="cite_ref-techcrunch_15-0" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-techcrunch-15">[15]</a></sup>&nbsp;by Robert Griesemer,&nbsp;<a href="https://en.wikipedia.org/wiki/Rob_Pike">Rob Pike</a>, and&nbsp;<a href="https://en.wikipedia.org/wiki/Ken_Thompson">Ken Thompson</a>.<sup id="cite_ref-langfaq_12-1" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-langfaq-12">[12]</a></sup>&nbsp;Go is&nbsp;<a href="https://en.wikipedia.org/wiki/Syntax_(programming_languages)">syntactically</a>&nbsp;similar to&nbsp;<a href="https://en.wikipedia.org/wiki/C_(programming_language)">C</a>, but with&nbsp;<a href="https://en.wikipedia.org/wiki/Memory_safety">memory safety</a>,&nbsp;<a href="https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)">garbage collection</a>,&nbsp;<a href="https://en.wikipedia.org/wiki/Structural_type_system">structural typing</a>,<sup id="cite_ref-structural_typing_6-1" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-structural_typing-6">[6]</a></sup>&nbsp;and&nbsp;<a href="https://en.wikipedia.org/wiki/Communicating_sequential_processes">CSP</a>-style&nbsp;<a href="https://en.wikipedia.org/wiki/Concurrency_(computer_science)">concurrency</a>.<sup id="cite_ref-boldly_16-0" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-boldly-16">[16]</a></sup>
</p>
<p style="color:#222222;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
	There are two major implementations:
</p>
<ul style="color:#222222;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
	<li>
		Google''s&nbsp;<a href="https://en.wikipedia.org/wiki/Self-hosting">self-hosting</a><sup id="cite_ref-17" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-17">[17]</a></sup>&nbsp;<a href="https://en.wikipedia.org/wiki/Compiler">compiler</a>&nbsp;<a href="https://en.wikipedia.org/wiki/Toolchain">toolchain</a>&nbsp;targeting multiple&nbsp;<a href="https://en.wikipedia.org/wiki/Operating_system">operating systems</a>, mobile devices,<sup id="cite_ref-18" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-18">[18]</a></sup>&nbsp;and&nbsp;<a href="https://en.wikipedia.org/wiki/WebAssembly">WebAssembly</a>.<sup id="cite_ref-19" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-19">[19]</a></sup>
	</li>
	<li>
		gccgo, a&nbsp;<a href="https://en.wikipedia.org/wiki/GNU_Compiler_Collection">GCC</a>&nbsp;<a href="https://en.wikipedia.org/wiki/Compiler#Front_end">frontend</a>.<sup id="cite_ref-20" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-20">[20]</a></sup><sup id="cite_ref-21" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-21">[21]</a></sup>
	</li>
</ul>
<p style="color:#222222;font-family:sans-serif;font-size:14px;background-color:#FFFFFF;">
	A third compiler, GopherJS,<sup id="cite_ref-22" class="reference"><a href="https://en.wikipedia.org/wiki/Go_(programming_language)#cite_note-22">[22]</a></sup>&nbsp;compiles Go to&nbsp;<a href="https://en.wikipedia.org/wiki/JavaScript">JavaScript</a>&nbsp;for&nbsp;<a href="https://en.wikipedia.org/wiki/Front-end_web_development">front-end web development</a>.
</p>')
INSERT [dbo].[Article] ([Id], [CreateTime], [AccountId], [CategoryId], [Title], [Content]) VALUES (16, CAST(0x0000AA30015F554F AS DateTime), 1, 2, N'.Net Core介绍', N'<p style="color:#E3E3E3;font-family:&quot;font-size:16px;background-color:#171717;">
	<span><span style="color:#000000;">ASP.NET Core 是一个跨平台的高性能</span><a href="https://github.com/aspnet/home"><span style="color:#000000;">开源</span></a><span style="color:#000000;">框架，用于生成基于云且连接 Internet 的新式应用程序。</span></span><span style="color:#000000;">&nbsp;</span><span style="color:#000000;">使用 ASP.NET Core，您可以：</span>
</p>
<ul style="color:#E3E3E3;font-family:&quot;font-size:16px;background-color:#171717;">
	<li>
		<span><span style="color:#000000;">创建 Web 应用程序和服务、</span><a href="https://www.microsoft.com/internet-of-things/"><span style="color:#000000;">IoT</span></a><span style="color:#000000;">&nbsp;应用和移动后端。</span></span>
	</li>
	<li>
		<span style="color:#000000;">在 Windows、macOS 和 Linux 上使用喜爱的开发工具。</span>
	</li>
	<li>
		<span style="color:#000000;">部署到云或本地。</span>
	</li>
	<li>
		<span><span style="color:#000000;">在&nbsp;</span><a href="https://docs.microsoft.com/zh-cn/dotnet/articles/standard/choosing-core-framework-server"><span style="color:#000000;">.NET Core 或 .NET Framework</span></a><span style="color:#000000;">&nbsp;上运行。</span></span>
	</li>
</ul>')
SET IDENTITY_INSERT [dbo].[Article] OFF
/****** Object:  ForeignKey [FK_Article_Account]    Script Date: 04/15/2019 21:48:32 ******/
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_Account]
GO
/****** Object:  ForeignKey [FK_Article_Category]    Script Date: 04/15/2019 21:48:32 ******/
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_Category]
GO
