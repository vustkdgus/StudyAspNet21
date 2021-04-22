CREATE TABLE [dbo].[Manages] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Cate]     VARCHAR (10)   NOT NULL,
    [Subject]  NVARCHAR (20)  NOT NULL,
    [Contents] NVARCHAR (MAX) NOT NULL,
    [RegDate]  DATETIME       CONSTRAINT [DF_Page_RegDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Page] PRIMARY KEY CLUSTERED ([ID] ASC)
);

