BEGIN TRANSACTION;
GO

CREATE TABLE [IdentitySettings] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NULL,
    [Prefix] nvarchar(max) NULL,
    [CurrentNumber] int NOT NULL,
    [StepNumber] int NOT NULL,
    CONSTRAINT [PK_IdentitySettings] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221225110649_addIdentitySetting', N'6.0.5');
GO

COMMIT;
GO

