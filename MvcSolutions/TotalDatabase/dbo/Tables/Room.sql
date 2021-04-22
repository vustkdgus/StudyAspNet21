CREATE TABLE [dbo].[Room] (
    [RoomId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomId] ASC)
);

