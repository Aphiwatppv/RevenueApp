CREATE TABLE [dbo].[UserRoles]
(
    [UserId] INT,
    [RoleId] INT,
    PRIMARY KEY ([UserId], [RoleId]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[AccountTB]([Id]),
    FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles]([RoleId])
);