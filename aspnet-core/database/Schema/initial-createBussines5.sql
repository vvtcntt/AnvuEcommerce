BEGIN TRANSACTION;
GO

CREATE TABLE [AppOrderItems] (
    [OrderId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [SKU] varchar(50) NOT NULL,
    [Quantity] int NOT NULL,
    [Price] float NOT NULL,
    CONSTRAINT [PK_AppOrderItems] PRIMARY KEY ([ProductId], [OrderId])
);
GO

CREATE TABLE [AppProductLinks] (
    [ProductId] uniqueidentifier NOT NULL,
    [LinkedProductId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_AppProductLinks] PRIMARY KEY ([ProductId], [LinkedProductId])
);
GO

CREATE TABLE [AppProductTags] (
    [ProductId] uniqueidentifier NOT NULL,
    [TagId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AppProductTags] PRIMARY KEY ([ProductId], [TagId])
);
GO

CREATE TABLE [Inventories] (
    [Id] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [SKU] nvarchar(max) NULL,
    [StockQuantity] int NOT NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierId] uniqueidentifier NULL,
    CONSTRAINT [PK_Inventories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [InventoryTicketItems] (
    [Id] uniqueidentifier NOT NULL,
    [TicketId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [SKU] nvarchar(max) NULL,
    [Quantity] int NOT NULL,
    [BatchNumber] nvarchar(max) NULL,
    [ExpiredDate] datetime2 NULL,
    CONSTRAINT [PK_InventoryTicketItems] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [InventoryTickets] (
    [Id] uniqueidentifier NOT NULL,
    [Code] nvarchar(max) NULL,
    [TicketType] int NOT NULL,
    [IsApproved] bit NOT NULL,
    [ApproverId] uniqueidentifier NULL,
    [ApprovedDate] datetime2 NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierId] uniqueidentifier NULL,
    CONSTRAINT [PK_InventoryTickets] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Manufacturers] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Code] nvarchar(max) NULL,
    [Slug] nvarchar(max) NULL,
    [CoverPicture] nvarchar(max) NULL,
    [Visibility] bit NOT NULL,
    [IsActive] bit NOT NULL,
    [Country] nvarchar(max) NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    CONSTRAINT [PK_Manufacturers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Orders] (
    [Id] uniqueidentifier NOT NULL,
    [Code] nvarchar(max) NULL,
    [Status] int NOT NULL,
    [PaymentMethod] int NOT NULL,
    [ShippingFee] float NOT NULL,
    [Tax] float NOT NULL,
    [Total] float NOT NULL,
    [Subtotal] float NOT NULL,
    [Discount] float NOT NULL,
    [GrandTotal] float NOT NULL,
    [CustomerName] nvarchar(max) NULL,
    [CustomerPhoneNumber] nvarchar(max) NULL,
    [CustomerAddress] nvarchar(max) NULL,
    [CustomerUserId] uniqueidentifier NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierId] uniqueidentifier NULL,
    [IsDeleted] bit NOT NULL DEFAULT CAST(0 AS bit),
    [DeleterId] uniqueidentifier NULL,
    [DeletionTime] datetime2 NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [OrderTransactions] (
    [Id] uniqueidentifier NOT NULL,
    [Code] nvarchar(max) NULL,
    [OrderId] uniqueidentifier NOT NULL,
    [UserId] uniqueidentifier NULL,
    [TransactionType] int NOT NULL,
    [Note] nvarchar(max) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    CONSTRAINT [PK_OrderTransactions] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductAttributeDateTimes] (
    [Id] uniqueidentifier NOT NULL,
    [AttributeId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [Value] datetime2 NOT NULL,
    CONSTRAINT [PK_ProductAttributeDateTimes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductAttributeDecimals] (
    [Id] uniqueidentifier NOT NULL,
    [AttributeId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [Value] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_ProductAttributeDecimals] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductAttributeInts] (
    [Id] uniqueidentifier NOT NULL,
    [AttributeId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [Value] int NOT NULL,
    CONSTRAINT [PK_ProductAttributeInts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductAttributeTexts] (
    [Id] uniqueidentifier NOT NULL,
    [AttributeId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_ProductAttributeTexts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductAttributeVarchars] (
    [Id] uniqueidentifier NOT NULL,
    [AttributeId] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_ProductAttributeVarchars] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductCategories] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Code] nvarchar(max) NULL,
    [Slug] nvarchar(max) NULL,
    [SortOrder] int NOT NULL,
    [CoverPicture] nvarchar(max) NULL,
    [Visibility] bit NOT NULL,
    [IsActive] bit NOT NULL,
    [ParentId] uniqueidentifier NULL,
    [SeoMetaDescription] nvarchar(max) NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    CONSTRAINT [PK_ProductCategories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ProductReviews] (
    [Id] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [ParentId] uniqueidentifier NULL,
    [Title] nvarchar(max) NULL,
    [Rating] float NOT NULL,
    [PublishedDate] datetime2 NULL,
    [Content] nvarchar(max) NULL,
    [OrderId] uniqueidentifier NOT NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    CONSTRAINT [PK_ProductReviews] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Products] (
    [Id] uniqueidentifier NOT NULL,
    [ManufacturerId] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Code] nvarchar(max) NULL,
    [ProductType] int NOT NULL,
    [SKU] nvarchar(max) NULL,
    [SortOrder] int NOT NULL,
    [Visibility] bit NOT NULL,
    [IsActive] bit NOT NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    [Slug] nvarchar(max) NULL,
    [SeoMetaDescription] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [ThumbnailPicture] nvarchar(max) NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierId] uniqueidentifier NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PromotionCategories] (
    [Id] uniqueidentifier NOT NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    [PromotionId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_PromotionCategories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PromotionManufacturers] (
    [Id] uniqueidentifier NOT NULL,
    [ManufactureId] uniqueidentifier NOT NULL,
    [PromotionId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_PromotionManufacturers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PromotionProducts] (
    [Id] uniqueidentifier NOT NULL,
    [ProductId] uniqueidentifier NOT NULL,
    [PromotionId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_PromotionProducts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Promotions] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [CouponCode] nvarchar(max) NULL,
    [RequireUseCouponCode] bit NOT NULL,
    [ValidDate] datetime2 NOT NULL,
    [ExpiredDate] datetime2 NULL,
    [DiscountAmount] float NOT NULL,
    [DiscountUnit] int NOT NULL,
    [LimitedUsageTimes] bit NOT NULL,
    [MaximumDiscountAmount] bigint NOT NULL,
    [IsActive] bit NOT NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    [LastModificationTime] datetime2 NULL,
    [LastModifierId] uniqueidentifier NULL,
    CONSTRAINT [PK_Promotions] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PromotionUsageHistories] (
    [Id] uniqueidentifier NOT NULL,
    [PromotionId] uniqueidentifier NOT NULL,
    [OrderId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_PromotionUsageHistories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Tags] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221123154510_initial-createBussines1', N'6.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [PromotionUsageHistories] DROP CONSTRAINT [PK_PromotionUsageHistories];
GO

ALTER TABLE [Promotions] DROP CONSTRAINT [PK_Promotions];
GO

ALTER TABLE [PromotionProducts] DROP CONSTRAINT [PK_PromotionProducts];
GO

ALTER TABLE [PromotionManufacturers] DROP CONSTRAINT [PK_PromotionManufacturers];
GO

ALTER TABLE [PromotionCategories] DROP CONSTRAINT [PK_PromotionCategories];
GO

ALTER TABLE [ProductCategories] DROP CONSTRAINT [PK_ProductCategories];
GO

ALTER TABLE [OrderTransactions] DROP CONSTRAINT [PK_OrderTransactions];
GO

ALTER TABLE [Orders] DROP CONSTRAINT [PK_Orders];
GO

EXEC sp_rename N'[PromotionUsageHistories]', N'AppPromotionUsageHistories';
GO

EXEC sp_rename N'[Promotions]', N'AppPromotions';
GO

EXEC sp_rename N'[PromotionProducts]', N'AppPromotionProducts';
GO

EXEC sp_rename N'[PromotionManufacturers]', N'AppPromotionManufacturers';
GO

EXEC sp_rename N'[PromotionCategories]', N'AppPromotionCategories';
GO

EXEC sp_rename N'[ProductCategories]', N'AppProductCategories';
GO

EXEC sp_rename N'[OrderTransactions]', N'AppOrderTransactions';
GO

EXEC sp_rename N'[Orders]', N'AppOrders';
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppPromotions]') AND [c].[name] = N'Name');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AppPromotions] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AppPromotions] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [AppPromotions] ADD DEFAULT N'' FOR [Name];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppPromotions]') AND [c].[name] = N'CouponCode');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [AppPromotions] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [AppPromotions] ALTER COLUMN [CouponCode] varchar(50) NOT NULL;
ALTER TABLE [AppPromotions] ADD DEFAULT '' FOR [CouponCode];
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'Slug');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [Slug] varchar(50) NOT NULL;
ALTER TABLE [AppProductCategories] ADD DEFAULT '' FOR [Slug];
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'SeoMetaDescription');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [SeoMetaDescription] nvarchar(250) NULL;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'Name');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [AppProductCategories] ADD DEFAULT N'' FOR [Name];
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'CoverPicture');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [CoverPicture] nvarchar(250) NULL;
GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductCategories]') AND [c].[name] = N'Code');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [AppProductCategories] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [AppProductCategories] ALTER COLUMN [Code] varchar(50) NOT NULL;
ALTER TABLE [AppProductCategories] ADD DEFAULT '' FOR [Code];
GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppOrderTransactions]') AND [c].[name] = N'Code');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [AppOrderTransactions] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [AppOrderTransactions] ALTER COLUMN [Code] varchar(50) NOT NULL;
ALTER TABLE [AppOrderTransactions] ADD DEFAULT '' FOR [Code];
GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppOrders]') AND [c].[name] = N'CustomerPhoneNumber');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [AppOrders] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [AppOrders] ALTER COLUMN [CustomerPhoneNumber] nvarchar(50) NOT NULL;
ALTER TABLE [AppOrders] ADD DEFAULT N'' FOR [CustomerPhoneNumber];
GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppOrders]') AND [c].[name] = N'CustomerName');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [AppOrders] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [AppOrders] ALTER COLUMN [CustomerName] nvarchar(50) NOT NULL;
ALTER TABLE [AppOrders] ADD DEFAULT N'' FOR [CustomerName];
GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppOrders]') AND [c].[name] = N'CustomerAddress');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [AppOrders] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [AppOrders] ALTER COLUMN [CustomerAddress] nvarchar(250) NOT NULL;
ALTER TABLE [AppOrders] ADD DEFAULT N'' FOR [CustomerAddress];
GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppOrders]') AND [c].[name] = N'Code');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [AppOrders] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [AppOrders] ALTER COLUMN [Code] varchar(50) NOT NULL;
ALTER TABLE [AppOrders] ADD DEFAULT '' FOR [Code];
GO

ALTER TABLE [AppPromotionUsageHistories] ADD CONSTRAINT [PK_AppPromotionUsageHistories] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppPromotions] ADD CONSTRAINT [PK_AppPromotions] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppPromotionProducts] ADD CONSTRAINT [PK_AppPromotionProducts] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppPromotionManufacturers] ADD CONSTRAINT [PK_AppPromotionManufacturers] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppPromotionCategories] ADD CONSTRAINT [PK_AppPromotionCategories] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductCategories] ADD CONSTRAINT [PK_AppProductCategories] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppOrderTransactions] ADD CONSTRAINT [PK_AppOrderTransactions] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppOrders] ADD CONSTRAINT [PK_AppOrders] PRIMARY KEY ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221124033235_initial-createBussines2', N'6.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Manufacturers] DROP CONSTRAINT [PK_Manufacturers];
GO

ALTER TABLE [InventoryTickets] DROP CONSTRAINT [PK_InventoryTickets];
GO

ALTER TABLE [InventoryTicketItems] DROP CONSTRAINT [PK_InventoryTicketItems];
GO

ALTER TABLE [Inventories] DROP CONSTRAINT [PK_Inventories];
GO

EXEC sp_rename N'[Manufacturers]', N'AppManufacturers';
GO

EXEC sp_rename N'[InventoryTickets]', N'AppInventoryTickets';
GO

EXEC sp_rename N'[InventoryTicketItems]', N'AppInventoryTicketItems';
GO

EXEC sp_rename N'[Inventories]', N'AppInventories';
GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppManufacturers]') AND [c].[name] = N'Slug');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [AppManufacturers] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [AppManufacturers] ALTER COLUMN [Slug] varchar(50) NOT NULL;
ALTER TABLE [AppManufacturers] ADD DEFAULT '' FOR [Slug];
GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppManufacturers]') AND [c].[name] = N'Name');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [AppManufacturers] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [AppManufacturers] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [AppManufacturers] ADD DEFAULT N'' FOR [Name];
GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppManufacturers]') AND [c].[name] = N'CoverPicture');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [AppManufacturers] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [AppManufacturers] ALTER COLUMN [CoverPicture] nvarchar(250) NULL;
GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppManufacturers]') AND [c].[name] = N'Code');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [AppManufacturers] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [AppManufacturers] ALTER COLUMN [Code] varchar(50) NOT NULL;
ALTER TABLE [AppManufacturers] ADD DEFAULT '' FOR [Code];
GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppInventoryTickets]') AND [c].[name] = N'Code');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [AppInventoryTickets] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [AppInventoryTickets] ALTER COLUMN [Code] varchar(50) NOT NULL;
ALTER TABLE [AppInventoryTickets] ADD DEFAULT '' FOR [Code];
GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppInventoryTicketItems]') AND [c].[name] = N'SKU');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [AppInventoryTicketItems] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [AppInventoryTicketItems] ALTER COLUMN [SKU] varchar(50) NOT NULL;
ALTER TABLE [AppInventoryTicketItems] ADD DEFAULT '' FOR [SKU];
GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppInventoryTicketItems]') AND [c].[name] = N'BatchNumber');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [AppInventoryTicketItems] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [AppInventoryTicketItems] ALTER COLUMN [BatchNumber] varchar(50) NULL;
GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppInventories]') AND [c].[name] = N'SKU');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [AppInventories] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [AppInventories] ALTER COLUMN [SKU] varchar(50) NOT NULL;
ALTER TABLE [AppInventories] ADD DEFAULT '' FOR [SKU];
GO

ALTER TABLE [AppManufacturers] ADD CONSTRAINT [PK_AppManufacturers] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppInventoryTickets] ADD CONSTRAINT [PK_AppInventoryTickets] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppInventoryTicketItems] ADD CONSTRAINT [PK_AppInventoryTicketItems] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppInventories] ADD CONSTRAINT [PK_AppInventories] PRIMARY KEY ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221124033356_initial-createBussines3', N'6.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Tags] DROP CONSTRAINT [PK_Tags];
GO

ALTER TABLE [Products] DROP CONSTRAINT [PK_Products];
GO

ALTER TABLE [ProductReviews] DROP CONSTRAINT [PK_ProductReviews];
GO

ALTER TABLE [ProductAttributeVarchars] DROP CONSTRAINT [PK_ProductAttributeVarchars];
GO

ALTER TABLE [ProductAttributeTexts] DROP CONSTRAINT [PK_ProductAttributeTexts];
GO

ALTER TABLE [ProductAttributeInts] DROP CONSTRAINT [PK_ProductAttributeInts];
GO

ALTER TABLE [ProductAttributeDecimals] DROP CONSTRAINT [PK_ProductAttributeDecimals];
GO

ALTER TABLE [ProductAttributeDateTimes] DROP CONSTRAINT [PK_ProductAttributeDateTimes];
GO

EXEC sp_rename N'[Tags]', N'AppTags';
GO

EXEC sp_rename N'[Products]', N'AppProducts';
GO

EXEC sp_rename N'[ProductReviews]', N'AppProductReviews';
GO

EXEC sp_rename N'[ProductAttributeVarchars]', N'AppProductAttributeVarchars';
GO

EXEC sp_rename N'[ProductAttributeTexts]', N'AppProductAttributeTexts';
GO

EXEC sp_rename N'[ProductAttributeInts]', N'AppProductAttributeInts';
GO

EXEC sp_rename N'[ProductAttributeDecimals]', N'AppProductAttributeDecimals';
GO

EXEC sp_rename N'[ProductAttributeDateTimes]', N'AppProductAttributeDateTimes';
GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppTags]') AND [c].[name] = N'Name');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [AppTags] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [AppTags] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [AppTags] ADD DEFAULT N'' FOR [Name];
GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppTags]') AND [c].[name] = N'Id');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [AppTags] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [AppTags] ALTER COLUMN [Id] nvarchar(50) NOT NULL;
GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'ThumbnailPicture');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [ThumbnailPicture] nvarchar(250) NULL;
GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'Slug');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [Slug] varchar(50) NOT NULL;
ALTER TABLE [AppProducts] ADD DEFAULT '' FOR [Slug];
GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'SeoMetaDescription');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [SeoMetaDescription] nvarchar(250) NULL;
GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'SKU');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [SKU] varchar(50) NOT NULL;
ALTER TABLE [AppProducts] ADD DEFAULT '' FOR [SKU];
GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'Name');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [AppProducts] ADD DEFAULT N'' FOR [Name];
GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProducts]') AND [c].[name] = N'Code');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [AppProducts] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [AppProducts] ALTER COLUMN [Code] varchar(50) NOT NULL;
ALTER TABLE [AppProducts] ADD DEFAULT '' FOR [Code];
GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductReviews]') AND [c].[name] = N'Title');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [AppProductReviews] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [AppProductReviews] ALTER COLUMN [Title] nvarchar(250) NOT NULL;
ALTER TABLE [AppProductReviews] ADD DEFAULT N'' FOR [Title];
GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AppProductAttributeVarchars]') AND [c].[name] = N'Value');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [AppProductAttributeVarchars] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [AppProductAttributeVarchars] ALTER COLUMN [Value] nvarchar(500) NULL;
GO

ALTER TABLE [AppTags] ADD CONSTRAINT [PK_AppTags] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProducts] ADD CONSTRAINT [PK_AppProducts] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductReviews] ADD CONSTRAINT [PK_AppProductReviews] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductAttributeVarchars] ADD CONSTRAINT [PK_AppProductAttributeVarchars] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductAttributeTexts] ADD CONSTRAINT [PK_AppProductAttributeTexts] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductAttributeInts] ADD CONSTRAINT [PK_AppProductAttributeInts] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductAttributeDecimals] ADD CONSTRAINT [PK_AppProductAttributeDecimals] PRIMARY KEY ([Id]);
GO

ALTER TABLE [AppProductAttributeDateTimes] ADD CONSTRAINT [PK_AppProductAttributeDateTimes] PRIMARY KEY ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221124033511_initial-createBussines4', N'6.0.5');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AppProductAttributes] (
    [Id] uniqueidentifier NOT NULL,
    [Code] varchar(50) NOT NULL,
    [DataType] int NOT NULL,
    [Label] nvarchar(50) NOT NULL,
    [SortOrder] int NOT NULL,
    [Visibility] bit NOT NULL,
    [IsActive] bit NOT NULL,
    [IsRequired] bit NOT NULL,
    [IsUnique] bit NOT NULL,
    [Note] nvarchar(max) NULL,
    [ExtraProperties] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(40) NULL,
    [CreationTime] datetime2 NOT NULL,
    [CreatorId] uniqueidentifier NULL,
    CONSTRAINT [PK_AppProductAttributes] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221124034109_initial-createBussines5', N'6.0.5');
GO

COMMIT;
GO

