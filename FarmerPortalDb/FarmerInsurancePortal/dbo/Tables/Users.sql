CREATE TABLE [dbo].[Users] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (50) NOT NULL,
    [MiddleName]  VARCHAR (50) NULL,
    [LastName]    VARCHAR (50) NOT NULL,
    [DateOfBirth] DATE         NOT NULL,
    [Gender]      CHAR (1)     NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

