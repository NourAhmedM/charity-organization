USE [charities]
GO
/****** Object:  Table [dbo].[Donor]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donor](
	[SSN] [int] NOT NULL,
	[Fname] [varchar](20) NULL,
	[Lname] [varchar](20) NULL,
	[d_address] [varchar](40) NULL,
	[email] [varchar](40) NULL,
	[dateOfBirth] [date] NULL,
	[ph_num] [int] NULL,
	[job] [varchar](20) NULL,
	[marriage_status] [varchar](10) NULL,
	[study_stage] [varchar](20) NULL,
	[gender] [char](1) NULL,
	[user_name] [varchar](20) NULL,
	[age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[charity_org]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[charity_org](
	[CH_ID] [int] NOT NULL,
	[founderName] [varchar](20) NULL,
	[CH_NAME] [varchar](20) NULL,
	[yearOfFound] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CH_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userBasic]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userBasic](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](50) NULL,
	[priv] [int] NULL,
 CONSTRAINT [PK_userBasic] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sponsor]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sponsor](
	[SSN] [int] NOT NULL,
	[org_name] [varchar](20) NULL,
	[logocode] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Volunteer]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Volunteer](
	[SSN] [int] NOT NULL,
	[starting_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BRANCH]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BRANCH](
	[BRANCH_NO] [int] NOT NULL,
	[CH_ID] [int] NOT NULL,
	[ADRESS] [varchar](40) NULL,
	[EMAIL] [varchar](20) NULL,
	[PHONE] [int] NULL,
	[BRANCH_NAME] [varchar](20) NULL,
 CONSTRAINT [PK__BRANCH__2D126DCE97C30012] PRIMARY KEY CLUSTERED 
(
	[BRANCH_NO] ASC,
	[CH_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[donations]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[donations](
	[D_SSN] [int] NOT NULL,
	[Donation_id] [int] NOT NULL,
	[date_of_donation] [datetime] NULL,
	[receipt_no] [int] NULL,
	[branch_no] [int] NULL,
	[charity_id] [int] NULL,
	[accepted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[D_SSN] ASC,
	[Donation_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cases]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cases](
	[SSN] [int] NOT NULL,
	[Fname] [varchar](20) NULL,
	[Lname] [varchar](20) NULL,
	[C_address] [varchar](40) NULL,
	[age] [int] NULL,
	[ph_num] [int] NULL,
	[job] [varchar](20) NULL,
	[marriage_status] [varchar](10) NULL,
	[study_stage] [varchar](20) NULL,
	[gender] [char](1) NULL,
	[branch_no] [int] NULL,
	[charity_id] [int] NULL,
	[dupication] [bit] NULL,
	[C_describtion] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[volunteersInBranch]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[volunteersInBranch](
	[vol_ssn] [int] NOT NULL,
	[branch_no] [int] NOT NULL,
	[charity_id] [int] NOT NULL,
	[category] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[vol_ssn] ASC,
	[branch_no] ASC,
	[charity_id] ASC,
	[category] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stock]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stock](
	[branch_no] [int] NOT NULL,
	[charity_id] [int] NOT NULL,
	[typee] [varchar](20) NOT NULL,
	[subtype] [varchar](20) NOT NULL,
	[qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[branch_no] ASC,
	[charity_id] ASC,
	[typee] ASC,
	[subtype] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[campaign]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[campaign](
	[campaign_id] [int] NOT NULL,
	[branch_no] [int] NOT NULL,
	[charity_id] [int] NOT NULL,
	[location] [varchar](30) NULL,
	[campaign_name] [varchar](40) NULL,
	[campaign_desc] [varchar](100) NULL,
	[starting_date] [datetime] NULL,
	[ending_date] [datetime] NULL,
 CONSTRAINT [PK__campaign__2DEED11EDDFE253B] PRIMARY KEY CLUSTERED 
(
	[campaign_id] ASC,
	[branch_no] ASC,
	[charity_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KIND_OF_DON]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KIND_OF_DON](
	[D_SSN] [int] NOT NULL,
	[Donation_id] [int] NOT NULL,
	[type_] [varchar](20) NULL,
	[subtype] [varchar](20) NULL,
	[qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[D_SSN] ASC,
	[Donation_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[branchInvitations]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branchInvitations](
	[donor_ssn] [int] NOT NULL,
	[campaign_id] [int] NOT NULL,
	[branch_no] [int] NOT NULL,
	[charity_id] [int] NOT NULL,
	[accept] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[donor_ssn] ASC,
	[campaign_id] ASC,
	[branch_no] ASC,
	[charity_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[caseDonation]    Script Date: 12/23/2018 23:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[caseDonation](
	[donor_ssn] [int] NOT NULL,
	[case_ssn] [int] NOT NULL,
	[accepted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[donor_ssn] ASC,
	[case_ssn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_branchInvitations_accept]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[branchInvitations] ADD  CONSTRAINT [DF_branchInvitations_accept]  DEFAULT ((0)) FOR [accept]
GO
/****** Object:  Default [DF__caseDonat__accep__2F10007B]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[caseDonation] ADD  DEFAULT ((0)) FOR [accepted]
GO
/****** Object:  Default [DF_donations_Donation_id]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[donations] ADD  CONSTRAINT [DF_donations_Donation_id]  DEFAULT ((0)) FOR [Donation_id]
GO
/****** Object:  Default [DF__Volunteer__start__29572725]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[Volunteer] ADD  DEFAULT (getdate()) FOR [starting_date]
GO
/****** Object:  ForeignKey [FK__BRANCH__CH_ID__20C1E124]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[BRANCH]  WITH CHECK ADD  CONSTRAINT [FK__BRANCH__CH_ID__20C1E124] FOREIGN KEY([CH_ID])
REFERENCES [dbo].[charity_org] ([CH_ID])
GO
ALTER TABLE [dbo].[BRANCH] CHECK CONSTRAINT [FK__BRANCH__CH_ID__20C1E124]
GO
/****** Object:  ForeignKey [FK__branchInv__donor__31EC6D26]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[branchInvitations]  WITH CHECK ADD FOREIGN KEY([donor_ssn])
REFERENCES [dbo].[Donor] ([SSN])
GO
/****** Object:  ForeignKey [FK__branchInvitation__300424B4]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[branchInvitations]  WITH CHECK ADD  CONSTRAINT [FK__branchInvitation__300424B4] FOREIGN KEY([campaign_id], [branch_no], [charity_id])
REFERENCES [dbo].[campaign] ([campaign_id], [branch_no], [charity_id])
GO
ALTER TABLE [dbo].[branchInvitations] CHECK CONSTRAINT [FK__branchInvitation__300424B4]
GO
/****** Object:  ForeignKey [FK__campaign__29572725]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[campaign]  WITH CHECK ADD  CONSTRAINT [FK__campaign__29572725] FOREIGN KEY([branch_no], [charity_id])
REFERENCES [dbo].[BRANCH] ([BRANCH_NO], [CH_ID])
GO
ALTER TABLE [dbo].[campaign] CHECK CONSTRAINT [FK__campaign__29572725]
GO
/****** Object:  ForeignKey [FK__caseDonat__case___34C8D9D1]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[caseDonation]  WITH CHECK ADD FOREIGN KEY([case_ssn])
REFERENCES [dbo].[cases] ([SSN])
GO
/****** Object:  ForeignKey [FK__caseDonat__donor__35BCFE0A]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[caseDonation]  WITH CHECK ADD FOREIGN KEY([donor_ssn])
REFERENCES [dbo].[Donor] ([SSN])
GO
/****** Object:  ForeignKey [FK__cases__267ABA7A]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[cases]  WITH CHECK ADD  CONSTRAINT [FK__cases__267ABA7A] FOREIGN KEY([branch_no], [charity_id])
REFERENCES [dbo].[BRANCH] ([BRANCH_NO], [CH_ID])
GO
ALTER TABLE [dbo].[cases] CHECK CONSTRAINT [FK__cases__267ABA7A]
GO
/****** Object:  ForeignKey [FK__donations__30F848ED]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[donations]  WITH CHECK ADD  CONSTRAINT [FK__donations__30F848ED] FOREIGN KEY([branch_no], [charity_id])
REFERENCES [dbo].[BRANCH] ([BRANCH_NO], [CH_ID])
GO
ALTER TABLE [dbo].[donations] CHECK CONSTRAINT [FK__donations__30F848ED]
GO
/****** Object:  ForeignKey [FK__donations__D_SSN__38996AB5]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[donations]  WITH CHECK ADD FOREIGN KEY([D_SSN])
REFERENCES [dbo].[Donor] ([SSN])
GO
/****** Object:  ForeignKey [FK__KIND_OF_DON__398D8EEE]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[KIND_OF_DON]  WITH CHECK ADD FOREIGN KEY([D_SSN], [Donation_id])
REFERENCES [dbo].[donations] ([D_SSN], [Donation_id])
GO
/****** Object:  ForeignKey [FK__sponsor__SSN__3A81B327]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[sponsor]  WITH CHECK ADD FOREIGN KEY([SSN])
REFERENCES [dbo].[Donor] ([SSN])
GO
/****** Object:  ForeignKey [FK__stock__239E4DCF]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[stock]  WITH CHECK ADD  CONSTRAINT [FK__stock__239E4DCF] FOREIGN KEY([branch_no], [charity_id])
REFERENCES [dbo].[BRANCH] ([BRANCH_NO], [CH_ID])
GO
ALTER TABLE [dbo].[stock] CHECK CONSTRAINT [FK__stock__239E4DCF]
GO
/****** Object:  ForeignKey [FK__Volunteer__SSN__3C69FB99]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[Volunteer]  WITH CHECK ADD FOREIGN KEY([SSN])
REFERENCES [dbo].[Donor] ([SSN])
GO
/****** Object:  ForeignKey [FK__volunteersInBran__2C3393D0]    Script Date: 12/23/2018 23:03:18 ******/
ALTER TABLE [dbo].[volunteersInBranch]  WITH CHECK ADD  CONSTRAINT [FK__volunteersInBran__2C3393D0] FOREIGN KEY([branch_no], [charity_id])
REFERENCES [dbo].[BRANCH] ([BRANCH_NO], [CH_ID])
GO
ALTER TABLE [dbo].[volunteersInBranch] CHECK CONSTRAINT [FK__volunteersInBran__2C3393D0]
GO
