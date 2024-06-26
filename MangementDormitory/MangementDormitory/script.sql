create database [MangementDormitory]
go
USE [MangementDormitory]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contract]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contract](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studentCode] [varchar](21) NULL,
	[roomId] [int] NULL,
	[dateStart] [date] NULL,
	[dateEnd] [date] NULL,
	[deposit] [float] NULL,
	[priceActual] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rent]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contractId] [int] NULL,
	[monthYear] [varchar](20) NULL,
	[price] [float] NULL,
	[dateOfPayment] [date] NULL,
	[staffId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[area] [int] NULL,
	[numberOfBeds] [int] NULL,
	[price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[phone] [varchar](11) NULL,
	[note] [varchar](max) NULL,
	[roleId] [int] NULL,
	[username] [varchar](21) NULL,
	[password] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 10/04/2023 16:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[studentCode] [varchar](21) NOT NULL,
	[name] [nvarchar](100) NULL,
	[phone] [varchar](11) NULL,
	[classId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[studentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([id], [name]) VALUES (1, N'10DHTH3')
INSERT [dbo].[Class] ([id], [name]) VALUES (2, N'10DHTH7')
SET IDENTITY_INSERT [dbo].[Class] OFF
SET IDENTITY_INSERT [dbo].[Contract] ON 

INSERT [dbo].[Contract] ([id], [studentCode], [roomId], [dateStart], [dateEnd], [deposit], [priceActual]) VALUES (9, N'2001191201', 2, CAST(N'2023-04-04' AS Date), CAST(N'2023-04-14' AS Date), 1, 88888)
INSERT [dbo].[Contract] ([id], [studentCode], [roomId], [dateStart], [dateEnd], [deposit], [priceActual]) VALUES (10, N'2001191210', 4, CAST(N'2023-04-02' AS Date), CAST(N'2023-04-04' AS Date), 1, 50000)
SET IDENTITY_INSERT [dbo].[Contract] OFF
SET IDENTITY_INSERT [dbo].[Rent] ON 

INSERT [dbo].[Rent] ([id], [contractId], [monthYear], [price], [dateOfPayment], [staffId]) VALUES (9, 9, N'4/2023', 88888, CAST(N'2023-04-10' AS Date), 11)
INSERT [dbo].[Rent] ([id], [contractId], [monthYear], [price], [dateOfPayment], [staffId]) VALUES (10, 10, N'4/2023', 50000, CAST(N'2023-04-10' AS Date), 11)
SET IDENTITY_INSERT [dbo].[Rent] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id], [name]) VALUES (1, N'admin')
INSERT [dbo].[Role] ([id], [name]) VALUES (2, N'user')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([id], [name], [area], [numberOfBeds], [price]) VALUES (2, N'Phòng 2', 13, 2, 88888)
INSERT [dbo].[Room] ([id], [name], [area], [numberOfBeds], [price]) VALUES (4, N'Phòng 3', 5, 3, 50000)
INSERT [dbo].[Room] ([id], [name], [area], [numberOfBeds], [price]) VALUES (5, N'Phòng 1', 12, 1, 30000)
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([id], [name], [phone], [note], [roleId], [username], [password]) VALUES (8, N'Dương Đông Duy', N'0376880903', N'', 1, N'dongduy', N'827ccb0eea8a706c4c34a16891f84e7b')
INSERT [dbo].[Staff] ([id], [name], [phone], [note], [roleId], [username], [password]) VALUES (10, N'Lưu Thị Dung', N'0988922780', N'', 2, N'luudung', N'827ccb0eea8a706c4c34a16891f84e7b')
INSERT [dbo].[Staff] ([id], [name], [phone], [note], [roleId], [username], [password]) VALUES (11, N'admin', N'0376880903', N'admin', 1, N'admin', N'827ccb0eea8a706c4c34a16891f84e7b')
SET IDENTITY_INSERT [dbo].[Staff] OFF
INSERT [dbo].[Student] ([studentCode], [name], [phone], [classId]) VALUES (N'2001191201', N'Nguyễn Tuấn Kiệt', N'03428932', 2)
INSERT [dbo].[Student] ([studentCode], [name], [phone], [classId]) VALUES (N'2001191210', N'Dương Duy Nghĩa', N'03247827', 2)
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [fk_Contract_Room] FOREIGN KEY([roomId])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [fk_Contract_Room]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [fk_Contract_Student] FOREIGN KEY([studentCode])
REFERENCES [dbo].[Student] ([studentCode])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [fk_Contract_Student]
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [fk_Rent_Contract] FOREIGN KEY([contractId])
REFERENCES [dbo].[Contract] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [fk_Rent_Contract]
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [fk_Rent_Staff] FOREIGN KEY([staffId])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [fk_Rent_Staff]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [fk_Staff_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[Role] ([id])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [fk_Staff_Role]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [fk_Student_Classes] FOREIGN KEY([classId])
REFERENCES [dbo].[Class] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [fk_Student_Classes]
GO
