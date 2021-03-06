CREATE TABLE [dbo].[Patient]
(
	[Patient_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First_Name] VARCHAR(50) NULL, 
    [Middle_Name] VARCHAR(50) NULL, 
    [Last_Name] VARCHAR(50) NULL, 
    [Age] INT NULL, 
    [Gender] VARCHAR NULL, 
    [Contact_Number] INT NULL, 
    [Email_ID] VARCHAR(50) NULL, 
    [Address] VARCHAR(250) NULL, 
    [Patient_Problem] VARCHAR(250) NULL, 
    [Brief_History] VARCHAR(500) NULL, 
    [Referred_By] VARCHAR(50) NULL, 
    [Per_Session_Cost] INT NULL, 
    [Notes] VARCHAR(500) NULL, 
    [Weight] FLOAT NULL, 
    [Height] FLOAT NULL, 
    [Start_Date] NCHAR(10) NULL
)
