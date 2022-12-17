BEGIN TRANSACTION;
GO

ALTER TABLE [AppProducts] ADD [SellPrice] float NOT NULL DEFAULT 0.0E0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221217102736_AddSellPriceProduct', N'6.0.5');
GO

COMMIT;
GO

