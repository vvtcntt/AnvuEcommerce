USE [AnvuEcommerce]
GO

INSERT INTO [dbo].[AppProductCategories]
           ([Id]
           ,[Name]
           ,[Code]
           ,[Slug]
           ,[SortOrder]
           ,[CoverPicture]
           ,[Visibility]
           ,[IsActive]
           ,[ParentId]
           ,[SeoMetaDescription]
           ,[ExtraProperties]
           ,[ConcurrencyStamp]
           ,[CreationTime]
           ,[CreatorId])
     VALUES
           (newid()
           ,N'Điện thoại'
           ,'D1'
           ,'dien-thoai'
           ,1
           ,null
           ,1
           ,1
           ,null
           ,N'Danh mục điện thoại'
           ,null
           ,null
           ,getdate()
           ,null)
		   INSERT INTO [dbo].[AppProductCategories]
           ([Id]
           ,[Name]
           ,[Code]
           ,[Slug]
           ,[SortOrder]
           ,[CoverPicture]
           ,[Visibility]
           ,[IsActive]
           ,[ParentId]
           ,[SeoMetaDescription]
           ,[ExtraProperties]
           ,[ConcurrencyStamp]
           ,[CreationTime]
           ,[CreatorId])
     VALUES
           (newid()
           ,N'Laptop'
           ,'D2'
           ,'Laptop'
           ,1
           ,null
           ,1
           ,1
           ,null
           ,N'Danh mục laptop'
           ,null
           ,null
           ,getdate()
           ,null)
GO


