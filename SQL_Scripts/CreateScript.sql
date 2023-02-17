USE [ChallengeTaskv2]
GO

/****** Object:  Table [dbo].[collateral_Agreements]    Script Date: 17-02-2023 11:35:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[collateral_Agreements](
	[CollateralAgreementID] [int] IDENTITY(1,1) NOT NULL,
	[CAName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_collateral_Agreements] PRIMARY KEY CLUSTERED 
(
	[CollateralAgreementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[contract_s]    Script Date: 17-02-2023 11:36:13 ******/
CREATE TABLE [dbo].[contract_s](
	[ContractFrequenciesID] [int] IDENTITY(1,1) NOT NULL,
	[CFName] [nvarchar](max) NOT NULL,
	[Collateral_Agreements_IDCollateralAgreementID] [int] NOT NULL,
 CONSTRAINT [PK_contract_s] PRIMARY KEY CLUSTERED 
(
	[ContractFrequenciesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[contract_s]  WITH CHECK ADD  CONSTRAINT [FK_contract_s_collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID] FOREIGN KEY([Collateral_Agreements_IDCollateralAgreementID])
REFERENCES [dbo].[collateral_Agreements] ([CollateralAgreementID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[contract_s] CHECK CONSTRAINT [FK_contract_s_collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID]
GO

/****** Object:  Table [dbo].[frequencies]    Script Date: 17-02-2023 11:36:18 ******/
CREATE TABLE [dbo].[frequencies](
	[InterestFrequencyID] [int] IDENTITY(1,1) NOT NULL,
	[IFName] [nvarchar](max) NOT NULL,
	[Contract_Frequencies_IDContractFrequenciesID] [int] NOT NULL,
 CONSTRAINT [PK_frequencies] PRIMARY KEY CLUSTERED 
(
	[InterestFrequencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[frequencies]  WITH CHECK ADD  CONSTRAINT [FK_frequencies_contract_s_Contract_Frequencies_IDContractFrequenciesID] FOREIGN KEY([Contract_Frequencies_IDContractFrequenciesID])
REFERENCES [dbo].[contract_s] ([ContractFrequenciesID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[frequencies] CHECK CONSTRAINT [FK_frequencies_contract_s_Contract_Frequencies_IDContractFrequenciesID]
GO