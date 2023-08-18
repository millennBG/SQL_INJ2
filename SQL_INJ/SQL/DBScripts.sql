
USE [db_test]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 2023-08-18 11:59:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


--Create table(s)

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


--Create procedure(s)

create procedure dbo.CheckUser
(
	@UserName nvarchar(128),
	@Password nvarchar(128)
)
AS

BEGIN

select 
	UserName 
from 
	Users 
where 
	UserName=@UserName 
	and Password=@Password

END
go


--Insert data

INSERT INTO [dbo].[Users] ([UserName], [Password]) select 'gogo', 'ggg'
INSERT INTO [dbo].[Users] ([UserName], [Password]) select 'tosho', 'ttt'
go

