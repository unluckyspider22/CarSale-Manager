USE [master]
GO
/****** Object:  Database [CarManager]    Script Date: 12/16/2019 11:47:17 AM ******/
CREATE DATABASE [CarManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Account_', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Account_.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Account__log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Account__log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CarManager] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarManager] SET  MULTI_USER 
GO
ALTER DATABASE [CarManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CarManager] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CarManager]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[username_] [varchar](50) NOT NULL,
	[password_] [varchar](20) NOT NULL,
	[fullname_] [nvarchar](50) NOT NULL,
	[gender_] [varchar](6) NOT NULL,
	[address_] [nvarchar](500) NOT NULL,
	[age_] [int] NOT NULL,
	[phone_] [decimal](18, 0) NOT NULL,
	[email_] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[username_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Car_Categories]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Car_Categories](
	[category_Code_] [varchar](20) NOT NULL,
	[category_Name_] [varchar](50) NOT NULL,
	[description_] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[category_Code_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Car_Manufacturers]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Car_Manufacturers](
	[manufacturer_Code_] [varchar](20) NOT NULL,
	[manufacturer_Name_] [varchar](50) NOT NULL,
	[description_] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[manufacturer_Code_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cars_for_Sale]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cars_for_Sale](
	[car_for_Sale_ID_] [varchar](20) NOT NULL,
	[model_Name_] [varchar](50) NOT NULL,
	[manufacturer_Code_] [varchar](20) NULL,
	[category_Code_] [varchar](20) NULL,
	[price_] [float] NOT NULL,
	[speed_] [float] NOT NULL,
	[date_Accquired_] [date] NOT NULL,
	[registration_Year_] [int] NOT NULL,
	[description_] [varchar](1000) NULL,
	[status_] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[car_for_Sale_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer_Payments]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer_Payments](
	[payment_ID_] [varchar](20) NOT NULL,
	[type_] [varchar](20) NOT NULL,
	[description_] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[payment_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[customer_ID_] [varchar](20) NOT NULL,
	[fullname_] [nvarchar](50) NOT NULL,
	[gender_] [char](6) NOT NULL,
	[age_] [int] NOT NULL,
	[address_] [nvarchar](500) NOT NULL,
	[phone_] [decimal](18, 0) NOT NULL,
	[email_] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Insurance_Companies]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Insurance_Companies](
	[insurance_Company_ID_] [varchar](20) NOT NULL,
	[insurance_Company_Name_] [varchar](50) NOT NULL,
	[description_] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[insurance_Company_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order_Details]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order_Details](
	[order_ID_] [varchar](20) NOT NULL,
	[car_for_Sale_ID_] [varchar](20) NOT NULL,
	[unit_price_] [money] NOT NULL,
	[quantity_] [int] NOT NULL,
	[discount_] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_ID_] ASC,
	[car_for_Sale_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[order_ID_] [varchar](20) NOT NULL,
	[customer_ID_] [varchar](20) NULL,
	[payment_ID_] [varchar](20) NULL,
	[insurance_Company_ID_] [varchar](20) NULL,
	[total_money_] [float] NOT NULL,
	[date_order_] [date] NOT NULL,
	[description_] [varchar](1000) NULL,
	[status_] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 12/16/2019 11:47:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staffs](
	[staff_ID_] [nvarchar](20) NOT NULL,
	[fullname_] [nvarchar](50) NOT NULL,
	[gender_] [char](6) NOT NULL,
	[age_] [int] NOT NULL,
	[address_] [nvarchar](500) NOT NULL,
	[phone_] [decimal](18, 0) NOT NULL,
	[email_] [varchar](50) NULL,
	[position_] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[staff_ID_] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Accounts] ([username_], [password_], [fullname_], [gender_], [address_], [age_], [phone_], [email_]) VALUES (N'dongnguyen', N'admin123', N'Đông Nguyên', N'male', N'Q12, HCM', 21, CAST(84123456789 AS Decimal(18, 0)), N'nguyen@gmail.com')
INSERT [dbo].[Accounts] ([username_], [password_], [fullname_], [gender_], [address_], [age_], [phone_], [email_]) VALUES (N'namtran', N'12345678', N'Nam Trần', N'male', N'Q9, HCM', 23, CAST(84919775201 AS Decimal(18, 0)), N'nam@gmail.com')
INSERT [dbo].[Car_Categories] ([category_Code_], [category_Name_], [description_]) VALUES (N'C1', N'Luxury', N'')
INSERT [dbo].[Car_Categories] ([category_Code_], [category_Name_], [description_]) VALUES (N'C2', N'Sport', NULL)
INSERT [dbo].[Car_Categories] ([category_Code_], [category_Name_], [description_]) VALUES (N'C3', N'Family', NULL)
INSERT [dbo].[Car_Categories] ([category_Code_], [category_Name_], [description_]) VALUES (N'C4', N'SUV', NULL)
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M1', N'Toyota', N'Japan Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M2', N'Suzuki', N'Japan Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M3', N'Honda', N'Japan Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M4', N'Ford', N'US Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M5', N'Hyundai-Kia', N'South Korea Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M6', N'General Motors', N'US Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M7', N'VinFast', N'Vietnam Company')
INSERT [dbo].[Car_Manufacturers] ([manufacturer_Code_], [manufacturer_Name_], [description_]) VALUES (N'M8', N'Ferrari', N'Italy Company')
INSERT [dbo].[Cars_for_Sale] ([car_for_Sale_ID_], [model_Name_], [manufacturer_Code_], [category_Code_], [price_], [speed_], [date_Accquired_], [registration_Year_], [description_], [status_]) VALUES (N'CA1', N'TOYOTA CAMRY 2.5 Q', N'M1', N'C1', 55000, 180, CAST(N'2019-01-05' AS Date), 2019, N'- 05 seats / automatic air conditioning 2 zones / 6-speed automatic transmission
- 1,998 cc / Dual VVT-iW - D-4S petrol engine
- D x R x C (mm): 4850 x 1825 x 1470', N'available')
INSERT [dbo].[Cars_for_Sale] ([car_for_Sale_ID_], [model_Name_], [manufacturer_Code_], [category_Code_], [price_], [speed_], [date_Accquired_], [registration_Year_], [description_], [status_]) VALUES (N'CA2', N'2020 RAV4', N'M1', N'C4', 25850, 180, CAST(N'2019-08-07' AS Date), 2019, N'Express your sense of style with a RAV4 Hybrid that fits you best. From a selection of 17- and 18-in. alloy wheels to an available two-tone roof, there''s a RAV4 that will help you stand out. Now with an enhanced 10-year Hybrid Battery Warranty 71 from date of first use, or 150,000 miles, whichever comes first.', N'outStock')
INSERT [dbo].[Cars_for_Sale] ([car_for_Sale_ID_], [model_Name_], [manufacturer_Code_], [category_Code_], [price_], [speed_], [date_Accquired_], [registration_Year_], [description_], [status_]) VALUES (N'CA3', N'Ferrari F8 Tributo', N'M8', N'C2', 280000, 200, CAST(N'2019-10-12' AS Date), 2019, N'The Ferrari F8 Tributo is a mid-engine sports car produced by the Italian automobile manufacturer Ferrari. The car is an update to the 488 with notable exterior and performance changes. It was unveiled at the 2019 Geneva Motor Show.', N'available')
INSERT [dbo].[Cars_for_Sale] ([car_for_Sale_ID_], [model_Name_], [manufacturer_Code_], [category_Code_], [price_], [speed_], [date_Accquired_], [registration_Year_], [description_], [status_]) VALUES (N'CA4', N'Giá xe Toyota Vios 1.5G', N'M1', N'C3', 22000, 170, CAST(N'2018-04-07' AS Date), 2019, N'Unlike other product lines, Vios has a sharp line, a new generation of breakthroughs attracts all eyes with a unique appearance but still no less luxurious, attracting attention on all roads.
Therefore, following the remarkable successes recorded in 2017, Vios car price continues to lead the segment and maintains the best-selling title in Vietnam with 22,260 vehicles. This makes its other rivals and even the adjacent segments influential.', N'available')
INSERT [dbo].[Customer_Payments] ([payment_ID_], [type_], [description_]) VALUES (N'P1', N'Credit Card', N'')
INSERT [dbo].[Customer_Payments] ([payment_ID_], [type_], [description_]) VALUES (N'P2', N'Viettel Pay', N'')
INSERT [dbo].[Customers] ([customer_ID_], [fullname_], [gender_], [age_], [address_], [phone_], [email_]) VALUES (N'Cus1', N'Phan Bùi Trung', N'male  ', 21, N'HCM', CAST(8475197757 AS Decimal(18, 0)), N'trung@fe.edu.vn')
INSERT [dbo].[Customers] ([customer_ID_], [fullname_], [gender_], [age_], [address_], [phone_], [email_]) VALUES (N'Cus2', N'Nguyễn Văn Nam', N'male  ', 32, N'Long An', CAST(8417549283 AS Decimal(18, 0)), N'An@gmail.com')
INSERT [dbo].[Insurance_Companies] ([insurance_Company_ID_], [insurance_Company_Name_], [description_]) VALUES (N'Ins1', N'Polimex', N'')
INSERT [dbo].[Insurance_Companies] ([insurance_Company_ID_], [insurance_Company_Name_], [description_]) VALUES (N'Ins2', N'Becamex', N'')
INSERT [dbo].[Insurance_Companies] ([insurance_Company_ID_], [insurance_Company_Name_], [description_]) VALUES (N'Ins3', N'1231231', N'')
INSERT [dbo].[Order_Details] ([order_ID_], [car_for_Sale_ID_], [unit_price_], [quantity_], [discount_]) VALUES (N'Od1', N'CA1', 55000.0000, 1, 0)
INSERT [dbo].[Order_Details] ([order_ID_], [car_for_Sale_ID_], [unit_price_], [quantity_], [discount_]) VALUES (N'Od2', N'CA3', 280000.0000, 1, 0)
INSERT [dbo].[Orders] ([order_ID_], [customer_ID_], [payment_ID_], [insurance_Company_ID_], [total_money_], [date_order_], [description_], [status_]) VALUES (N'Od1', N'Cus1', N'P1', N'Ins1', 55000, CAST(N'2019-07-02' AS Date), NULL, N'delivered')
INSERT [dbo].[Orders] ([order_ID_], [customer_ID_], [payment_ID_], [insurance_Company_ID_], [total_money_], [date_order_], [description_], [status_]) VALUES (N'Od2', N'Cus2', N'P1', N'Ins2', 280000, CAST(N'2019-12-30' AS Date), NULL, N'delivered')
INSERT [dbo].[Staffs] ([staff_ID_], [fullname_], [gender_], [age_], [address_], [phone_], [email_], [position_]) VALUES (N'S1', N'Nguyễn Minh Mẫn', N'male  ', 21, N'HCM', CAST(84147258369 AS Decimal(18, 0)), N'man@yahoo.com', N'Technical')
INSERT [dbo].[Staffs] ([staff_ID_], [fullname_], [gender_], [age_], [address_], [phone_], [email_], [position_]) VALUES (N'S2', N'Mạc Minh Khôi', N'male  ', 21, N'HCM', CAST(84369258147 AS Decimal(18, 0)), N'khoi@hotmail.com', N'Maketing')
INSERT [dbo].[Staffs] ([staff_ID_], [fullname_], [gender_], [age_], [address_], [phone_], [email_], [position_]) VALUES (N'S3', N'Lê Hiếu', N'male  ', 23, N'HCM', CAST(84159357456 AS Decimal(18, 0)), N'hieu@fpt.edu.vn', N'Trainee')
ALTER TABLE [dbo].[Cars_for_Sale]  WITH CHECK ADD FOREIGN KEY([category_Code_])
REFERENCES [dbo].[Car_Categories] ([category_Code_])
GO
ALTER TABLE [dbo].[Cars_for_Sale]  WITH CHECK ADD FOREIGN KEY([manufacturer_Code_])
REFERENCES [dbo].[Car_Manufacturers] ([manufacturer_Code_])
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD FOREIGN KEY([car_for_Sale_ID_])
REFERENCES [dbo].[Cars_for_Sale] ([car_for_Sale_ID_])
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD FOREIGN KEY([order_ID_])
REFERENCES [dbo].[Orders] ([order_ID_])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([customer_ID_])
REFERENCES [dbo].[Customers] ([customer_ID_])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([insurance_Company_ID_])
REFERENCES [dbo].[Insurance_Companies] ([insurance_Company_ID_])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([payment_ID_])
REFERENCES [dbo].[Customer_Payments] ([payment_ID_])
GO
ALTER TABLE [dbo].[Cars_for_Sale]  WITH CHECK ADD CHECK  (([price_]>(0)))
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD CHECK  (([discount_]>=(0) AND [discount_]<=(1)))
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD CHECK  (([quantity_]>(0)))
GO
ALTER TABLE [dbo].[Order_Details]  WITH CHECK ADD CHECK  (([unit_price_]>=(0)))
GO
USE [master]
GO
ALTER DATABASE [CarManager] SET  READ_WRITE 
GO
