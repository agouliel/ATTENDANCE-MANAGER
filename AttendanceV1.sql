USE [AttendanceV1]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[AnswerId] [int] NOT NULL,
	[Answer] [nchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BCCreationHistory]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BCCreationHistory](
	[strFileName] [varchar](1024) NOT NULL,
	[dtRegistrationDate] [datetime] NOT NULL,
	[strUserName] [varchar](1024) NULL,
	[strComments] [varchar](max) NULL,
	[strQuestionnaire] [varchar](max) NULL,
	[guiFileId] [uniqueidentifier] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BriefcaseTemplate]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BriefcaseTemplate](
	[intTemplateId] [int] IDENTITY(1,1) NOT NULL,
	[strName] [varchar](256) NOT NULL,
	[dtCreationDate] [datetime] NOT NULL,
	[strComments] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BriefcaseTemplateVIQ]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BriefcaseTemplateVIQ](
	[intTemplateID] [int] NOT NULL,
	[intQID] [int] NOT NULL,
	[intOrder] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryCode] [varchar](16) NOT NULL,
	[CategoryDescription] [varchar](128) NOT NULL,
	[CategoryDisplayCode] [varchar](16) NULL,
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryDisplayIndex] [int] NULL,
	[CategoryNewID] [uniqueidentifier] NULL,
	[Comments] [varchar](max) NULL,
	[CategoryLevelIndex] [int] NULL,
	[DisplayOrder] [int] NULL,
	[Children] [int] NULL,
	[strInternalGroupCode] [varchar](64) NULL,
	[strOrigin] [varchar](64) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ConceptualLinkParts]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConceptualLinkParts](
	[questionId] [uniqueidentifier] NOT NULL,
	[LinkId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ConceptualLinks]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConceptualLinks](
	[LinkId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Demo]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demo](
	[ANAme] [nvarchar](max) NOT NULL,
	[ADAte] [datetime] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Purpose] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InspectionSource]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionSource](
	[InspectionSourceId] [int] NOT NULL,
	[MajorOCIMFId] [int] NULL,
	[SourceName] [varchar](256) NOT NULL,
	[SourceCode] [varchar](64) NULL,
	[CountryCode] [varchar](64) NULL,
	[UsedId] [int] NULL,
	[TypeCode] [varchar](2) NULL,
	[PrintCode] [varchar](10) NULL,
 CONSTRAINT [PK__InspectionSource__5DCAEF64] PRIMARY KEY NONCLUSTERED 
(
	[InspectionSourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InspectionTypes]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InspectionTypes](
	[InspectionTypeId] [int] IDENTITY(1,1) NOT NULL,
	[InspectionType] [nvarchar](64) NOT NULL,
	[InspectionCode] [varchar](50) NULL,
	[bitReport] [bit] NULL,
 CONSTRAINT [PK_InspectionTypes] PRIMARY KEY CLUSTERED 
(
	[InspectionTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Majors]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Majors](
	[MajorId] [int] NOT NULL,
	[MajorName] [varchar](64) NOT NULL,
	[MajorCode] [varchar](16) NULL,
	[bitIsCompany] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ObjectTree]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectTree](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[strTreeName] [varchar](256) NOT NULL,
 CONSTRAINT [PK_ObjectTree] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ObjectTreeNode]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectTreeNode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[intTreeId] [int] NOT NULL,
	[intParentId] [int] NOT NULL,
	[intNextSiblingId] [int] NOT NULL,
	[GID] [uniqueidentifier] NOT NULL,
	[intLevelInTree] [int] NOT NULL,
	[intLevelInBranch] [int] NOT NULL,
	[ObjectId] [int] NULL,
	[strTitle] [varchar](256) NULL,
	[intFirstChildId] [int] NOT NULL,
 CONSTRAINT [PK_ObjectTreeNode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[question_company_ref_viq]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[question_company_ref_viq](
	[vetid] [int] NOT NULL,
	[questionid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[questioncode] [varchar](64) NULL,
	[question] [varchar](2000) NULL,
	[company_ref] [varchar](2000) NULL,
PRIMARY KEY CLUSTERED 
(
	[vetid] ASC,
	[questionid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuestionContext]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionContext](
	[QuestionID] [uniqueidentifier] NOT NULL,
	[CategoryID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuestionnaireObjects]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionnaireObjects](
	[ObjectId] [uniqueidentifier] NOT NULL,
	[ObjectNo] [int] IDENTITY(1,1) NOT NULL,
	[ObjectDescription] [varchar](256) NOT NULL,
	[ObjectCode] [varchar](64) NULL,
	[ObjectType] [int] NOT NULL,
	[OriginId] [uniqueidentifier] NOT NULL,
	[ObjectComments] [varchar](max) NULL,
	[ParentId] [uniqueidentifier] NULL,
	[GlobalDisplayIndex] [int] NULL,
	[Children] [int] NOT NULL,
 CONSTRAINT [PK_QuestionnaireObjects] PRIMARY KEY CLUSTERED 
(
	[ObjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuestionnaireOrigin]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionnaireOrigin](
	[OriginId] [uniqueidentifier] NOT NULL,
	[OriginTitle] [varchar](512) NOT NULL,
	[OriginNo] [int] IDENTITY(1,1) NOT NULL,
	[RegDate] [datetime] NULL,
	[OriginCode] [varchar](64) NOT NULL,
 CONSTRAINT [PK_QuestionnaireOrigin] PRIMARY KEY CLUSTERED 
(
	[OriginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuestionPoolNew]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionPoolNew](
	[questionid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[questioncode] [varchar](64) NOT NULL,
	[question] [varchar](2000) NOT NULL,
	[comment] [nvarchar](max) NULL,
	[CategoryID] [int] NULL,
	[CategoryCode] [varchar](64) NULL,
	[Origin] [int] NULL,
	[OriginCode] [varchar](64) NULL,
	[CategoryNewID] [uniqueidentifier] NULL,
	[DefaultDisplayIndex] [int] NULL,
	[CreationInfo] [varchar](max) NULL,
	[ConceptualLink] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SearchTMP]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SearchTMP](
	[CategoryCode] [varchar](16) NOT NULL,
	[CategoryDescription] [varchar](128) NOT NULL,
	[CategoryDisplayCode] [varchar](16) NULL,
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryDisplayIndex] [int] NULL,
	[CategoryNewID] [uniqueidentifier] NULL,
	[Comments] [varchar](max) NULL,
	[CategoryLevelIndex] [int] NULL,
	[DisplayOrder] [int] NULL,
	[Children] [int] NULL,
	[strInternalGroupCode] [varchar](64) NULL,
	[strOrigin] [varchar](64) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Significance]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Significance](
	[SignificanceId] [int] NOT NULL,
	[Significance] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableDemo]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableDemo](
	[strName] [varchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblAppraisal]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAppraisal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[intEmployeeId] [int] NOT NULL,
	[intAppraisalValue] [int] NOT NULL,
	[strAppraisalCode] [varchar](5) NOT NULL,
	[dtAppraisalDate] [datetime] NOT NULL,
	[dtRegistrationDate] [datetime] NOT NULL,
	[strComments] [varchar](max) NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[intObjectId] [int] NOT NULL,
	[intObjectType] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblAssignedFrom]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAssignedFrom](
	[GID] [uniqueidentifier] NOT NULL,
	[JobListGID] [uniqueidentifier] NULL,
	[intAssignorTypeId] [int] NULL,
	[strJobTitle] [varchar](256) NULL,
	[strAssignorName] [varchar](256) NULL,
	[bitHasRegistrationId] [bit] NOT NULL,
	[intRegistrationId] [int] NOT NULL,
 CONSTRAINT [PK_tblAssignedFrom] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblAssignedTo]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAssignedTo](
	[GID] [uniqueidentifier] NOT NULL,
	[JobListGID] [uniqueidentifier] NULL,
	[AssigneeGID] [uniqueidentifier] NULL,
	[bitHasAssigneeId] [bit] NULL,
	[strAssigneeName] [varchar](256) NULL,
	[JobOrderGID] [uniqueidentifier] NULL,
	[bitAssignedToJobOrderLevel] [bit] NULL,
	[bitHasRank] [bit] NULL,
	[intAssigneeTypeId] [int] NULL,
	[intRankId] [int] NULL,
	[strJobTitle] [varchar](256) NULL,
 CONSTRAINT [PK_tblAssignedTo] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCustomQuery]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomQuery](
	[strQueryCode] [varchar](512) NOT NULL,
	[strQuery] [varchar](max) NOT NULL,
	[dtRegDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tblCustomQuery] PRIMARY KEY CLUSTERED 
(
	[strQueryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblFleet]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFleet](
	[strFleetName] [varchar](128) NULL,
	[intFleetId] [int] NULL,
	[strFleetCode] [varchar](128) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblJobList]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJobList](
	[GID] [uniqueidentifier] NOT NULL,
	[InspectionGID] [uniqueidentifier] NOT NULL,
	[dtAssignedDate] [datetime] NOT NULL,
	[strPurpose] [varchar](max) NOT NULL,
	[dtEstimatedCompletionDate] [datetime] NULL,
	[intOriginCode] [int] NOT NULL,
 CONSTRAINT [PK_tblJobList] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblJobOrder]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJobOrder](
	[GID] [uniqueidentifier] NOT NULL,
	[JobListGID] [uniqueidentifier] NOT NULL,
	[strJobDescription] [varchar](max) NOT NULL,
	[dtHisEstimatedCompletionDate] [datetime] NULL,
	[dtAssignorEstimatedCompletionDate] [datetime] NULL,
	[dtCompletionDate] [datetime] NULL,
	[bitCompleted] [bit] NOT NULL,
	[dtCommenceDate] [datetime] NULL,
	[bitIsJobGroup] [bit] NOT NULL,
	[intLevelInTree] [int] NOT NULL,
	[intLevelInBranch] [int] NULL,
	[ParentJobGID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tblJobOrder] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblRelJobToObject]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRelJobToObject](
	[GID] [uniqueidentifier] NOT NULL,
	[JobListGID] [uniqueidentifier] NOT NULL,
	[objectGID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tblRelJobToObject] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_Roles]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Roles](
	[RoleDescription] [varchar](64) NOT NULL,
	[RoleId] [int] NOT NULL,
	[SystemRole] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](64) NOT NULL,
	[UserPassword] [varchar](64) NOT NULL,
	[UserRoleId] [int] NOT NULL,
	[UserId] [int] NULL,
	[SignOff] [bit] NULL,
	[SignOffDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USRTRC]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USRTRC](
	[intUsrTrcId] [int] IDENTITY(1,1) NOT NULL,
	[strUserName] [varchar](256) NULL,
	[strUserIp] [varchar](128) NOT NULL,
	[dtEventDate] [datetime] NOT NULL,
	[strContext] [varchar](256) NULL,
	[strComments] [varchar](512) NULL,
	[dtRegDate] [datetime] NOT NULL,
 CONSTRAINT [PK_USRTRC] PRIMARY KEY CLUSTERED 
(
	[intUsrTrcId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USRTRC_CONF]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USRTRC_CONF](
	[bitStartRec] [bit] NOT NULL,
	[bitIpRecOverwrite] [bit] NOT NULL,
	[bitExcludeOn] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USRTRC_EXCL]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USRTRC_EXCL](
	[intTRCEXCLId] [int] IDENTITY(1,1) NOT NULL,
	[strURI] [varchar](64) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usrxyz]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usrxyz](
	[usrblkid] [int] IDENTITY(1,1) NOT NULL,
	[strxyz] [varchar](64) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vessel]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vessel](
	[VesselName] [nchar](64) NOT NULL,
	[VesselId] [int] IDENTITY(1,1) NOT NULL,
	[IMO] [nvarchar](32) NULL,
	[FLAG] [nvarchar](64) NULL,
	[DeliveryDate] [datetime] NULL,
	[GrossTonage] [float] NULL,
	[DeadWeight] [float] NULL,
	[Locked] [int] NULL,
	[FleetId] [int] NULL,
	[VesselCode] [varchar](64) NULL,
 CONSTRAINT [PK_Vessel] PRIMARY KEY CLUSTERED 
(
	[VesselId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vetting]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vetting](
	[VETId] [int] NOT NULL,
	[ObjectId] [uniqueidentifier] NOT NULL,
	[answer] [varchar](5) NULL,
	[significance] [int] NULL,
	[comments] [varchar](max) NULL,
 CONSTRAINT [PK_Vetting] PRIMARY KEY CLUSTERED 
(
	[VETId] ASC,
	[ObjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VettingBak]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VettingBak](
	[VETId] [int] NULL,
	[ObjectId] [uniqueidentifier] NULL,
	[answer] [varchar](5) NULL,
	[significance] [int] NULL,
	[comments] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VettingInfo]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VettingInfo](
	[InspectorName] [varchar](50) NULL,
	[InspectorSirName] [varchar](50) NULL,
	[Port] [varchar](64) NULL,
	[Country] [varchar](64) NULL,
	[VetDate] [datetime] NULL,
	[VetTime] [datetime] NULL,
	[Password] [varchar](128) NULL,
	[Comments] [varchar](max) NULL,
	[VesselName] [varchar](64) NULL,
	[VettingCode] [varchar](64) NULL,
	[VetId] [int] IDENTITY(1,1) NOT NULL,
	[QId] [int] NOT NULL,
	[VetGUI] [uniqueidentifier] NOT NULL,
	[InspectionTypeId] [int] NOT NULL,
	[VesselId] [int] NULL,
	[CountryId] [int] NULL,
	[PortId] [int] NULL,
	[CompanyRepresentativeName] [varchar](64) NOT NULL,
	[RegistrationDate] [datetime] NULL,
	[MajorId] [int] NULL,
	[RegisterName] [varchar](64) NULL,
	[Answered] [int] NULL,
	[Negative] [int] NULL,
	[Positive] [int] NULL,
	[SourceId] [int] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_VettingInfo] PRIMARY KEY CLUSTERED 
(
	[VetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_VettingInfo_VetGUI] UNIQUE NONCLUSTERED 
(
	[VetGUI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VIQ]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIQ](
	[QId] [int] NOT NULL,
	[ObjectType] [int] NULL,
	[CategoryId] [int] NULL,
	[QuestionId] [uniqueidentifier] NULL,
	[CommentId] [uniqueidentifier] NULL,
	[ParentId] [uniqueidentifier] NULL,
	[ParentType] [int] NULL,
	[DisplayIndex] [int] NULL,
	[DisplayLevel] [int] NULL,
	[ObjectId] [uniqueidentifier] NULL,
	[ParentCategory] [uniqueidentifier] NULL,
	[GlobalDisplayIndex] [int] NULL,
	[Children] [int] NULL,
	[DisplayCode] [nvarchar](64) NULL,
	[InternalDisplayCode] [nvarchar](64) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VIQbak]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIQbak](
	[QId] [int] NOT NULL,
	[ObjectType] [int] NULL,
	[CategoryId] [int] NULL,
	[QuestionId] [uniqueidentifier] NULL,
	[CommentId] [uniqueidentifier] NULL,
	[ParentId] [uniqueidentifier] NULL,
	[ParentType] [int] NULL,
	[DisplayIndex] [int] NULL,
	[DisplayLevel] [int] NULL,
	[ObjectId] [uniqueidentifier] NULL,
	[ParentCategory] [uniqueidentifier] NULL,
	[GlobalDisplayIndex] [int] NULL,
	[Children] [int] NULL,
	[DisplayCode] [nvarchar](64) NULL,
	[InternalDisplayCode] [nvarchar](64) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VIQHelp]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIQHelp](
	[QId] [int] NOT NULL,
	[ObjectType] [int] NULL,
	[CategoryId] [int] NULL,
	[QuestionId] [uniqueidentifier] NULL,
	[CommentId] [uniqueidentifier] NULL,
	[ParentId] [uniqueidentifier] NULL,
	[ParentType] [int] NULL,
	[DisplayIndex] [int] NULL,
	[DisplayLevel] [int] NULL,
	[ObjectId] [uniqueidentifier] NULL,
	[ParentCategory] [uniqueidentifier] NULL,
	[GlobalDisplayIndex] [int] NULL,
	[Children] [int] NULL,
	[DisplayCode] [nvarchar](64) NULL,
	[InternalDisplayCode] [nvarchar](64) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VIQInfo]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIQInfo](
	[QId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](128) NOT NULL,
	[Comments] [varchar](max) NULL,
	[Author] [varchar](256) NULL,
	[Finalized] [tinyint] NULL,
	[RegistrationDate] [datetime] NULL,
	[NumOfQuestions] [int] NULL,
	[VIQGUI] [uniqueidentifier] NULL,
	[EffectiveDate] [datetime] NULL,
	[version] [varchar](64) NULL,
	[SecurityColumn] [int] NULL,
	[Visible] [bit] NULL,
 CONSTRAINT [PK_VIQInfo] PRIMARY KEY CLUSTERED 
(
	[QId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[ObjectTreeNode] ADD  CONSTRAINT [DF_ObjectTreeNode_intParentId]  DEFAULT ((-1)) FOR [intParentId]
GO
ALTER TABLE [dbo].[ObjectTreeNode] ADD  CONSTRAINT [DF_ObjectTreeNode_intNextSiblingId]  DEFAULT ((-1)) FOR [intNextSiblingId]
GO
ALTER TABLE [dbo].[ObjectTreeNode] ADD  CONSTRAINT [DF_ObjectTreeNode_intLevelInTree]  DEFAULT ((-1)) FOR [intLevelInTree]
GO
ALTER TABLE [dbo].[ObjectTreeNode] ADD  CONSTRAINT [DF_ObjectTreeNode_intLevelInBranch]  DEFAULT ((-1)) FOR [intLevelInBranch]
GO
ALTER TABLE [dbo].[ObjectTreeNode] ADD  CONSTRAINT [DF_ObjectTreeNode_intFirstChildId]  DEFAULT ((-1)) FOR [intFirstChildId]
GO
ALTER TABLE [dbo].[QuestionPoolNew] ADD  CONSTRAINT [DF_QuestionPoolNew_questionid]  DEFAULT (newid()) FOR [questionid]
GO
ALTER TABLE [dbo].[tblAssignedFrom] ADD  CONSTRAINT [DF_tblAssingedFrom_bitHasRegistrationId]  DEFAULT ((0)) FOR [bitHasRegistrationId]
GO
ALTER TABLE [dbo].[tblAssignedFrom] ADD  CONSTRAINT [DF_tblAssingedFrom_intRegistrationId]  DEFAULT ((-1)) FOR [intRegistrationId]
GO
ALTER TABLE [dbo].[tblCustomQuery] ADD  CONSTRAINT [DF_tblCustomQuery_dtRegDate]  DEFAULT (getdate()) FOR [dtRegDate]
GO
ALTER TABLE [dbo].[tblJobList] ADD  CONSTRAINT [DF_tblJobList_intOriginCode]  DEFAULT ((-1)) FOR [intOriginCode]
GO
ALTER TABLE [dbo].[tblJobOrder] ADD  CONSTRAINT [DF_tblJobOrder_bitCompleted]  DEFAULT ((0)) FOR [bitCompleted]
GO
ALTER TABLE [dbo].[tblJobOrder] ADD  CONSTRAINT [DF_tblJobOrder_bitIsJobGroup]  DEFAULT ((0)) FOR [bitIsJobGroup]
GO
ALTER TABLE [dbo].[USRTRC] ADD  CONSTRAINT [DF_USRTRC_dtRegDate]  DEFAULT (getdate()) FOR [dtRegDate]
GO
ALTER TABLE [dbo].[QuestionnaireObjects]  WITH CHECK ADD  CONSTRAINT [FK_QuestionnaireObjects_QuestionnaireObjects] FOREIGN KEY([OriginId])
REFERENCES [dbo].[QuestionnaireOrigin] ([OriginId])
GO
ALTER TABLE [dbo].[QuestionnaireObjects] CHECK CONSTRAINT [FK_QuestionnaireObjects_QuestionnaireObjects]
GO
ALTER TABLE [dbo].[Vetting]  WITH NOCHECK ADD  CONSTRAINT [FK_Vetting_VettingInfo] FOREIGN KEY([VETId])
REFERENCES [dbo].[VettingInfo] ([VetId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vetting] CHECK CONSTRAINT [FK_Vetting_VettingInfo]
GO
ALTER TABLE [dbo].[VettingInfo]  WITH CHECK ADD  CONSTRAINT [FK_VettingInfo_InspectionTypes] FOREIGN KEY([InspectionTypeId])
REFERENCES [dbo].[InspectionTypes] ([InspectionTypeId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VettingInfo] CHECK CONSTRAINT [FK_VettingInfo_InspectionTypes]
GO
/****** Object:  StoredProcedure [dbo].[CategoryUpdate]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CategoryUpdate]
	
	(
	@catnewid uniqueidentifier,
	@catcode nvarchar ,
	@catdescr nvarchar
	
	)
	
AS
	--declare int @pcount
	--select @pcount=count(*) from  VIQ  A JOIN VETTINGINFO B ON A.QID=B.QID LEFT JOIN VETTING C ON B.VETID=C.VETID WHERE C.OBJECTID=@catnewid;
	--if @pcount=0 then
	
	--end if 
	UPDATE CATEGORY SET CATEGORYDESCRIPTION=@catdescr,categorycode=@catcode where categorynewid=@catnewid;
	
	
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[Conceptual_Relate]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Conceptual_Relate]
	-- Add the parameters for the stored procedure here
	@sourceid uniqueidentifier,
	@targetid uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
declare @linkid1 int
declare @linkid2 int
select @linkid1=linkid from ConceptualLinkParts where
questionid=@sourceid
select @linkid2=linkid from ConceptualLinkParts where
questionid=@targetid

if @linkid1 is null
begin
  if @linkid2 is null
   begin
     exec dbo.ConceptualLink_Insert @sourceid, @linkid2 out
     exec dbo.ConceptualLink_Insert @targetid,@linkid2
   end
  else
  begin
         exec dbo.ConceptualLink_Insert @sourceid,@linkid2
  end

end
else
begin
    if @linkid2 is null
    begin
	     exec dbo.ConceptualLink_Insert @targetid,@linkid1 out
	end
	else
	begin
        raiserror('Cannot link questions questions are already linked',16,1)
	end
end

    
END

GO
/****** Object:  StoredProcedure [dbo].[ConceptualLink_Insert]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ConceptualLink_Insert]
	@questionid uniqueidentifier,
	@linkid int out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

 if not exists(select LinkId from ConceptualLinkParts where questionid=@questionid)

 begin
    if @linkid is null
    begin
    select @linkid=isnull(max(linkid),0)+1 from ConceptualLinks with (tablock)
     if @@rowcount=0 
     begin
      raiserror('Link cannot be retreived',16,1)
	  return
     end 
    end
   Insert into ConceptualLink (questionid,linkid) values(@questionid,@linkid)
   if @@rowcount=1
   begin
      set @linkid=-1
      raiserror('Link insertion failed',16,1)
      return
	end
 end
 else
 begin
    raiserror('Link already exists',16,1)
    return
 end  
END

GO
/****** Object:  StoredProcedure [dbo].[FixCategoryForQuestions]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FixCategoryForQuestions] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
   declare @qid uniqueidentifier
   declare @catid uniqueidentifier
	declare @categoryid int
    declare cur cursor for select questionid,categorynEWiD from QuestionPoolNew

    open cur
 
    while (@@fetch_status=0)
	begin
      
     select @categoryid=categoryid from Category where categorynewid=@catid
     update QuestionPoolNew set categoryid=@categoryid where questionid=@qid
        fetch next from cur into @qid,@catid
    end

    close cur
END

GO
/****** Object:  StoredProcedure [dbo].[FixNotNullEmptyComments]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FixNotNullEmptyComments]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update Vetting set comments=null where len(comments)=0 and comments is not null
END

GO
/****** Object:  StoredProcedure [dbo].[FixQuestionCode]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FixQuestionCode] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
declare cur cursor for select questionid,questioncode from QuestionPoolNew
where questioncode like '{%'
declare @qcode varchar(64)
declare @qid uniqueidentifier
open cur
fetch next from cur into @qid,@qcode
while (@@fetch_status=0)
	begin
      
     
     update QuestionPoolNew set questioncode =substring(@qcode,5,60)+' '+substring(@qcode,2,1) where questionid=@qid
        fetch next from cur into @qid,@qcode
    end
close cur


    -- Insert statements for procedure 
END

GO
/****** Object:  StoredProcedure [dbo].[OriginInsert]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[OriginInsert]
	@originid uniqueidentifier out,
	@originno int out,
	@origintitle varchar(256),
	@origincode varchar(64),
	@regdate datetime out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    set @originid=newid();
    insert into QuestionnaireOrigin
	(originid,origintitle,origincode,regdate)
	values(@originid,@origintitle,@origincode,getdate()) set @originno=scope_identity()
END

GO
/****** Object:  StoredProcedure [dbo].[QUESTIONNAIRE_GET]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QUESTIONNAIRE_GET] 
	-- Add the parameters for the stored procedure here
      @p1 int ,
      @p2 varchar(256) output,
      @p3 varchar(256) output,
      @p4 varchar(2048) output,
      @p5 datetime output,
      @p6 int output
      


AS
BEGIN
--    'SET @questionnaires = CURSOR
 --   'FORWARD_ONLY STATIC FOR
 --   '  SELECT  * 
 --   '  FROM Attendance.VIQ;
    
 --   'OPEN @QUESTIONNAIRES;
 --	'SET NOCOUNT ON;
--select GlobalDisplayIndex,'object type' =case c.objecttype
--        when 0 then 'question'
--        when 1 then 'comment'
--        when 2 then 'category'
--       end         

select @p2 = title from viqinfo where qid=@p1;
select @p3 = author from viqinfo where qid=@p1;
select @p4 = comments from viqinfo where qid=@p1;
select @p5 = registrationdate from viqinfo where qid=@p1;

select @p6 =count(*) from viq where qid=@p1 and ObjectType=2;

select
  InternalDisplayCode,null 'Categoryid',c.DisplayCode,c.ParentCategory 'ParentCategoryId',c.ObjectComments,c.Defaultcode,c.ObjectId,c.ObjectType,c.ObjectDescription,c.CHildren,c.GlobalDisplayIndex,c.DisplayLevel,c.ParentId
 from
(
  select a.*,b.comment 'ObjectComments' ,b.questioncode 'DefaultCode',rtrim(b.question) 'ObjectDescription' from viq a ,QuestionPoolNew b
where a.objectid=b.questionid and a.objecttype=0 and a.qid=@p1
union all
   select a.*,Comments 'ObjectComments',b.categorycode 'DefaultVode',rtrim(b.CategoryDescription) 'ObjectDescription' from viq a ,Category b
where a.objectid=b.categorynewid and a.objecttype=2 and a.qid=@p1
) c

order by globaldisplayindex



END












GO
/****** Object:  StoredProcedure [dbo].[QuestionPoolSelect]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QuestionPoolSelect]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select a.questionid,a.questioncode,
           a.question,a.comment,a.categoryid,
                   a.categorycode,a.origin,b.origincode,a.categorynewid,
                   a.defaultdisplayindex,a.creationinfo from
   questionpoolnew a left outer join 
           questionnaireorigin b on a.origin=b.originno order by a.categorycode,a.questioncode
END

GO
/****** Object:  StoredProcedure [dbo].[RetrieveQuiz]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RetrieveQuiz] 
 @qid  INT
,@vetid INT 

AS 
 
/* 
    Parameters and usage 
 
    @Tablenames        -- Provide a single table name or multiple table name with comma seperated.  
                        If left blank , it will check for all the tables in the database 
    @SearchStr        -- Provide the search string. Use the '%' to coin the search.  
                        EX : X%--- will give data staring with X 
                             %X--- will give data ending with X 
                             %X%--- will give data containig  X 
    @GenerateSQLOnly -- Provide 1 if you only want to generate the SQL statements without seraching the database.  
                        By default it is 0 and it will search. 
 
    Samples : 
 
    1. To search data in a table 
 
        EXEC RetrieveQuiz @qid = '137' 
                         ,@vetid = '473' 
 */
 
    SET NOCOUNT ON 
 

    BEGIN 
 
select  a.*, cast (b.answer as int) Answer , b.significance, b.comments AS Remarks from 

( 

Select a1.InternalDisplayCode,a1.DisplayCode,a1.ParentId,a1.displaylevel,a1.qid,a1.globaldisplayindex,
        a1.ObjectId,a1.ObjectType,a1.children ,a2.CategoryDescription AS Question,null QuestionDetails ,a2.categorycode as defaultcode from 
VIQ a1  
 join 
Category  as a2 on a1.objectid=a2.categorynewid  where a1.qid=@qid 


UNION ALL 

Select a1.InternalDisplayCode,a1.DisplayCode,a1.ParentId,a1.displaylevel,a1.qid,a1.globaldisplayindex,
        a1.ObjectId,a1.ObjectType,a1.children ,a2.question Question, a2.comment QuestionDetails, a2.questioncode as defaultcode from 
VIQ a1 
join 
QuestionPoolnew as  a2 on a1.objectid=a2.questionid  where a1.qid=@qid  

) A  
LEFT JOIN VETTING B ON A.OBJECTID=B.OBJECTID WHERE B.VETID=@vetid ORDER BY A.GLOBALDISPLAYINDEX 
 
    END 
 
   
     
    SET NOCOUNT OFF 
 

GO
/****** Object:  StoredProcedure [dbo].[SP_SearchTables]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SearchTables] 
 @Tablenames VARCHAR(500) 
,@SearchStr NVARCHAR(60) 
,@GenerateSQLOnly Bit = 0 
AS 
 
/* 
    Parameters and usage 
 
    @Tablenames        -- Provide a single table name or multiple table name with comma seperated.  
                        If left blank , it will check for all the tables in the database 
    @SearchStr        -- Provide the search string. Use the '%' to coin the search.  
                        EX : X%--- will give data staring with X 
                             %X--- will give data ending with X 
                             %X%--- will give data containig  X 
    @GenerateSQLOnly -- Provide 1 if you only want to generate the SQL statements without seraching the database.  
                        By default it is 0 and it will search. 
 
    Samples : 
 
    1. To search data in a table 
 
        EXEC SP_SearchTables @Tablenames = 'T1' 
                         ,@SearchStr  = '%TEST%' 
 
        The above sample searches in table T1 with string containing TEST. 
 
    2. To search in a multiple table 
 
        EXEC SP_SearchTables @Tablenames = 'T2' 
                         ,@SearchStr  = '%TEST%' 
 
        The above sample searches in tables T1 & T2 with string containing TEST. 
     
    3. To search in a all table 
 
        EXEC SP_SearchTables @Tablenames = '%' 
                         ,@SearchStr  = '%Caltex%' 
 
        The above sample searches in all table with string containing TEST. 
 
    4. Generate the SQL for the Select statements 
 
        EXEC SP_SearchTables @Tablenames        = 'T1' 
                         ,@SearchStr        = '%TEST%' 
                         ,@GenerateSQLOnly    = 1 
 
*/ 
 
    SET NOCOUNT ON 
 
    DECLARE @MatchFound BIT 
 
    SELECT @MatchFound = 0 
 
    DECLARE @CheckTableNames Table 
    ( 
    Tablename sysname 
    ) 
 
    DECLARE @SQLTbl TABLE 
    ( 
     Tablename        SYSNAME 
    ,WHEREClause    VARCHAR(MAX) 
    ,SQLStatement   VARCHAR(MAX) 
    ,Execstatus        BIT  
    ) 
 
    DECLARE @SQL VARCHAR(MAX) 
    DECLARE @tmpTblname sysname 
    DECLARE @ErrMsg VARCHAR(100) 
 
    IF LTRIM(RTRIM(@Tablenames)) IN ('' ,'%') 
    BEGIN 
 
        INSERT INTO @CheckTableNames 
        SELECT Name 
          FROM sys.tables 
    END 
    ELSE 
    BEGIN 
 
        SELECT @SQL = 'SELECT ''' + REPLACE(@Tablenames,',',''' UNION SELECT ''') + '''' 
 
        INSERT INTO @CheckTableNames 
        EXEC(@SQL) 
 
    END 
 
    IF NOT EXISTS(SELECT 1 FROM @CheckTableNames) 
    BEGIN 
         
        SELECT @ErrMsg = 'No tables are found in this database ' + DB_NAME() + ' for the specified filter' 
        PRINT @ErrMsg 
        RETURN 
 
    END 
     
    INSERT INTO @SQLTbl 
    ( Tablename,WHEREClause) 
    SELECT QUOTENAME(SCh.name) + '.' + QUOTENAME(ST.NAME), 
            ( 
                SELECT '[' + SC.Name + ']' + ' LIKE ''' + @SearchStr + ''' OR ' + CHAR(10) 
                  FROM SYS.columns SC 
                  JOIN SYS.types STy 
                    ON STy.system_type_id = SC.system_type_id 
                   AND STy.user_type_id =SC.user_type_id 
                 WHERE STY.name in ('varchar','char','nvarchar','nchar','text') 
                   AND SC.object_id = ST.object_id 
                 ORDER BY SC.name 
                FOR XML PATH('') 
            ) 
      FROM  SYS.tables ST 
      JOIN @CheckTableNames chktbls 
                ON chktbls.Tablename = ST.name  
      JOIN SYS.schemas SCh 
        ON ST.schema_id = SCh.schema_id 
     WHERE ST.name <> 'SearchTMP' 
      GROUP BY ST.object_id, QUOTENAME(SCh.name) + '.' +  QUOTENAME(ST.NAME) ; 
     
 
      UPDATE @SQLTbl 
         SET SQLStatement = 'SELECT * INTO SearchTMP FROM ' + Tablename + ' WHERE ' + substring(WHEREClause,1,len(WHEREClause)-5) 
 
      DELETE FROM @SQLTbl 
       WHERE WHEREClause IS NULL 
     
    WHILE EXISTS (SELECT 1 FROM @SQLTbl WHERE ISNULL(Execstatus ,0) = 0) 
    BEGIN 
 
        SELECT TOP 1 @tmpTblname = Tablename , @SQL = SQLStatement 
          FROM @SQLTbl  
         WHERE ISNULL(Execstatus ,0) = 0 
 
         IF @GenerateSQLOnly = 0 
         BEGIN 
 
            IF OBJECT_ID('SearchTMP','U') IS NOT NULL 
                DROP TABLE SearchTMP 
                 
            EXEC (@SQL) 
 
            IF EXISTS(SELECT 1 FROM SearchTMP) 
            BEGIN 
                SELECT Tablename=@tmpTblname,* FROM SearchTMP 
                SELECT @MatchFound = 1 
            END 
 
         END 
         ELSE 
         BEGIN 
             PRINT REPLICATE('-',100) 
             PRINT @tmpTblname 
             PRINT REPLICATE('-',100) 
             PRINT replace(@SQL,'INTO SearchTMP','') 
         END 
 
         UPDATE @SQLTbl 
            SET Execstatus = 1 
          WHERE Tablename = @tmpTblname 
 
    END 
 
    IF @MatchFound = 0  
    BEGIN 
        SELECT @ErrMsg = 'No Matches are found in this database ' + DB_NAME() + ' for the specified filter' 
        PRINT @ErrMsg 
        RETURN 
    END 
     
    SET NOCOUNT OFF 
 

GO
/****** Object:  StoredProcedure [dbo].[UpdateCompanyRef]    Script Date: 8/5/2020 15:08:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCompanyRef]
AS
BEGIN
      SET NOCOUNT ON;
 
      DECLARE @VetId INT
 
      DECLARE VetCur CURSOR READ_ONLY
      FOR
		select distinct vetid
		from Vetting
		where vetid not in (select distinct vetid from question_company_ref_viq)
 
      OPEN VetCur
 
      FETCH NEXT FROM VetCur INTO @VetId
 
      WHILE @@FETCH_STATUS = 0
      BEGIN
			insert into question_company_ref_viq(vetid,[questionid],[questioncode],[question])
			select v.VETId, q.questionid, q.questioncode, q.question--, a.Answer
			from Vetting v, QuestionPoolNew q--, Answer a
			where v.ObjectId = q.questionid
			and v.VETId = @VetId
 
			FETCH NEXT FROM VetCur INTO @VetId
      END
 
      CLOSE VetCur
      DEALLOCATE VetCur
END

GO
