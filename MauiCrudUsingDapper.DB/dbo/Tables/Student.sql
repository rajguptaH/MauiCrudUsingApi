CREATE TABLE [dbo].[Student] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50)  NOT NULL,
    [Class]     VARCHAR (50)  NOT NULL,
    [RollNo]    INT           NOT NULL,
    [Address]   VARCHAR (100) NOT NULL,
    [IsDeleted] BIT           CONSTRAINT [DF_Student_IsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC)
);

