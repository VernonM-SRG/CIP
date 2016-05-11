-- Database Connection String
-- "Data Source=LAPTOP-ISSE06\SQLEXPRESS;Initial Catalog=CIS;Persist Security Info=True;User ID=sa;Password=***********;Pooling=False"
/*
	string connString = @"Data Source=LAPTOP-ISSE06\SQLEXPRESS;Initial Catalog=figjam;Persist Security Info=True;User ID=sa;Password=***********;Pooling=False";

	string command = "Select * from People";
	using (SqlConnection conn = new SqlConnection(connString)) 
	{
		try
		{
			conn.Open();
			SqlCommand sqlComm = new SqlCommand(commandText, conn);
			using (SqldataReader reader = sqlComm.ExecuteReader())
			{
				while(reader.Read()) {
					sampLabel.Text += $"<br{reader[0]}, {reader[1]}, {reader[2]:d}";
				}
			}
		}
		catch(Exception ex)
		{
		}
	}
*/

USE [master]
GO

DROP DATABASE [CIS];
GO

/****** Object:  Database [CIS]    Script Date: 10/11/2013 16:55:39 ******/
CREATE DATABASE [CIS]  

GO

ALTER DATABASE [CIS] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CIS] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CIS] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CIS] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CIS] SET ARITHABORT OFF 
GO

ALTER DATABASE [CIS] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CIS] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [CIS] SET AUTO_SHRINK ON
GO

ALTER DATABASE [CIS] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CIS] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CIS] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CIS] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CIS] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CIS] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CIS] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CIS] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CIS] SET  READ_WRITE 
GO

ALTER DATABASE [CIS] SET RECOVERY FULL 
GO

ALTER DATABASE [CIS] SET  MULTI_USER 
GO

ALTER DATABASE [CIS] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CIS] SET DB_CHAINING OFF 
GO

USE [CIS]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE TABLE RecordStatusCode(
	RecordStatusCodeID int IDENTITY(1,1) NOT NULL,
	Description varchar(200) NOT NULL,
	Name varchar(20) NOT NULL,
	MyRecordStatusID int NOT NULL DEFAULT 1,
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL  DEFAULT GETDATE(),
	PRIMARY KEY (RecordStatusCodeID),
) ON [PRIMARY]

CREATE INDEX idxRecordStatusCodeName ON RecordStatusCode(Name)
CREATE INDEX idxRecordStatusCodeDescription ON RecordStatusCode(Description)

SET IDENTITY_INSERT RecordStatusCode ON

INSERT INTO RecordStatusCode (RecordStatusCodeID, Name, Description) VALUES (1,'New', 'New')
INSERT INTO RecordStatusCode (RecordStatusCodeID, Name, Description) VALUES (2,'Undeleted', 'Undeleted')
INSERT INTO RecordStatusCode (RecordStatusCodeID, Name, Description) VALUES (3,'Deleted', 'Deleted')

SET IDENTITY_INSERT RecordStatusCode OFF

CREATE TABLE QuoteStatusCode(
	QuoteStatusCodeID int IDENTITY(1,1) NOT NULL,
	Description varchar(200) NOT NULL,
	Name varchar(20) NOT NULL,
	RecordStatusCodeID int NOT NULL DEFAULT 1,
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL  DEFAULT GETDATE(),
	PRIMARY KEY (QuoteStatusCodeID),
	FOREIGN KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
) ON [PRIMARY]

SET IDENTITY_INSERT QuoteStatusCode ON

INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (1,'New', 'New')
-- INSERT INTO QuoteStatus (QuoteStatusID, Name, Description) VALUES (2,'Deleted', 'Deleted')
-- INSERT INTO QuoteStatus (QuoteStatusID, Name, Description) VALUES (3,'UnDeleted', 'UnDeleted')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (4,'ToStore', 'Sent to Store')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (5,'StoreUpdating', 'Store Updating')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (6,'StoreReturned', 'Returned from Store')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (7,'InsurerSent', 'Sent to Insurer')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (8,'QuoteApproved', 'Approved with Quote')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (9,'PreApproved', 'Approved without Quote')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (10,'InsApproved', 'Insurer Approved with Quote')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (11,'InsPreApproved', 'Insurer Approved without Quote')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (12,'StoreRejected', 'Store Rejected')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (13,'InsRejected', 'Insurer Rejected')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (14,'InsPreRejected', 'Insurer Rejected without Quote')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (15,'DelComplete', 'Delivered Completed')
INSERT INTO QuoteStatusCode (QuoteStatusCodeID, Name, Description) VALUES (16,'NotDelComplete', 'Completed Without Delivery')

SET IDENTITY_INSERT QuoteStatusCode OFF

CREATE TABLE QuoteStatusMap(
	QuoteStatusMapID int IDENTITY(1,1) NOT NULL,
	QuoteStatusCodeID int NOT NULL,
	NextQuoteStatusCodeID int NOT NULL,
	RecordStatusCodeID int NOT NULL DEFAULT 1,
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL  DEFAULT GETDATE(),
	PRIMARY KEY (QuoteStatusMapID),
	FOREIGN KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
	FOREIGN KEY (QuoteStatusCodeID) REFERENCES QuoteStatusCode(QuoteStatusCodeID),
) ON [PRIMARY]
CREATE INDEX idxQuoteStatusMapQuoteStatusID ON QuoteStatusMap(QuoteStatusCodeID)
CREATE INDEX idxQuoteStatusMapNextQuoteStatusID ON QuoteStatusMap(NextQuoteStatusCodeID)

-- SET IDENTITY_INSERT QuoteStatusMap ON

-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (1, 2)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (1, 3)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (1, 4)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (2, 3)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (4, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (4, 5)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (4, 6)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (4, 12)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (5, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (5, 6)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (5, 12)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (6, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (6, 7)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (6, 8)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (6, 9)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (7, 10)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (7, 11)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (7, 13)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (7, 14)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (8, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (8, 15)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (8, 16)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (9, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (9, 15)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (9, 16)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (10, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (10, 15)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (10, 16)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (11, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (11, 15)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (11, 16)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (12, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (12, 4)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (13, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (13, 16)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (14, 2)
INSERT INTO QuoteStatusMap (QuoteStatusCodeID, NextQuoteStatusCodeID) VALUES (14, 16)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (15, 2)
-- INSERT INTO QuoteStatusMap (QuoteStatusID, NextQuoteStatusID) VALUES (16, 2)

-- SET IDENTITY_INSERT QuoteStatusMap OFF

GO

CREATE TABLE AuditTrail(
	AuditTrailID int IDENTITY(1,1) NOT NULL,
	TableName varchar(200) NOT NULL,
	ColumnName varchar(200) NOT NULL,
	RecordStatusCodeID int NOT NULL DEFAULT 1, -- From our Lookup Table
	Created datetime NOT NULL DEFAULT GETDATE(),
	BeforeValue text DEFAULT NULL,
	AfterValue text DEFAULT NULL,
	Details text DEFAULT NULL, -- Contains details about WHO, what Module did it, etc.
	RemoteObjectPrimaryKeyID int NOT NULL,
	PRIMARY KEY (AuditTrailID),
	FOREIGN KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
) ON [PRIMARY]

CREATE INDEX idxAudStatus ON AuditTrail(RecordStatusCodeID)
CREATE INDEX idxAudTable ON AuditTrail(TableName)
CREATE INDEX idxAudColumn ON AuditTrail(ColumnName)
CREATE INDEX idxAudKey ON AuditTrail(RemoteObjectPrimaryKeyID)

GO

CREATE TABLE SRGBrand(
	SRGBrandID int IDENTITY(1,1) NOT NULL,
	Name VARCHAR(255),
	Shortname VARCHAR(20),
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL DEFAULT GETDATE(),
	RecordStatusCodeID int NOT NULL default 1, -- From our Lookup Table
	PRIMARY KEY (SRGBrandID),
	FOREIGN KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
) ON [PRIMARY]

GO

CREATE TABLE InsuranceCompany(
	InsuranceCompanyID int IDENTITY(1,1) NOT NULL,
	Name VARCHAR(255),
	Shortname VARCHAR(20),
	Address1 VARCHAR(255),
	Address2 VARCHAR(255),
	State VARCHAR(20),
	Postcode VARCHAR(45),
	Phone VARCHAR(45),
	Email VARCHAR(255),
	RecordStatusCodeID int NOT NULL DEFAULT 1, -- From our Lookup Table
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL  DEFAULT GETDATE(),
	ParentInsuranceCompanyID int NOT NULL DEFAULT 0,
	CreditLimit TEXT,
	StandardDiscount float NOT NULL DEFAULT 0.0,
	ReportingCommitments TEXT,
	BrandAssociations TEXT,
	GiftCardLetter TEXT,
	LetterHeads TEXT,
	Notes TEXT,
	PRIMARY KEY (InsuranceCompanyID),
	FOREIGN KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
) ON [PRIMARY]

GO

CREATE TABLE Quote(
	QuoteID int IDENTITY(1,1) NOT NULL,
	InsuranceCompanyID int NOT NULL default 0,
	ClaimNum varchar(255) default NULL,
	StoreIDs TEXT NOT NULL default '',
	CustomerName varchar(255),
	CustomerAddress1 varchar(255),
	CustomerAddress2 varchar(255),
	CustomerCity varchar(255),
	CustomerState varchar(20),
	CustomerPostcode varchar(20),
	CustomerPhone varchar(20),
	CustomerEmail varchar(255),
	CustomerDateOfBirth Date,
	NextOfKinName varchar(255),
	NextOfKinAddress1 varchar(255),
	NextOfKinAddress2 varchar(255),
	NextOfKinCity varchar(255),
	NextOfKinState varchar(20),
	NextOfKinPostcode varchar(20),
	NextOfKinPhone varchar(20),
	NextOfKinEmail varchar(255),
	NextOfKinDateOfBirth Date,
	CustomerContactAllowed BIT default 1,
	PolicyLimit float default null,
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL DEFAULT GETDATE(),
	RecordStatusCodeID int NOT NULL default 1, -- From our Lookup Table
	QuotePriority TEXT,
	TeamMemberResponsible varchar(255),
	Notes TEXT,
	FulfilmentMethod TEXT,
	FulfilmentType TEXT,
	PreferredBrands TEXT,
	ClosestStores TEXT,
	PRIMARY KEY (QuoteID),
	FOREIGn KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
	FOREIGN KEY (InsuranceCompanyID) REFERENCES InsuranceCompany(InsuranceCompanyID),
) ON [PRIMARY]

GO

CREATE TABLE QuoteDetail(
	QuoteDetailID int IDENTITY(1,1) NOT NULL,
	QuoteID int NOT NULL default 0,
	Quantity varchar(20) NOT NULL default '1',
	Created datetime NOT NULL DEFAULT GETDATE(),
	LastModified datetime NOT NULL DEFAULT GETDATE(),
	RecordStatusCodeID int NOT NULL default 1, -- From our Lookup Table
	InsurerDescription varchar(255) default NULL,
	OtherInformation varchar(255) default NULL,
	PLU varchar(20) default NULL,
	PLUDescription varchar(255) default NULL,
	PLUQuantity int default 1,
	PLUPrice float,
	DiscountApplied float,
	SRGBrandSupplying varchar(255),
	SRGStoreSupplying TEXT,
	Comments varchar(255) default NULL,
	Specialorder bit default NULL,
	Isapproved bit default NULL,
	PRIMARY KEY (QuoteDetailID),
	FOREIGN KEY (RecordStatusCodeID) REFERENCES RecordStatusCode(RecordStatusCodeID),
	FOREIGN KEY (QuoteID) REFERENCES Quote(QuoteID),
) ON [PRIMARY]

GO
