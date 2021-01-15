CREATE TABLE [dbo].[Products]
(
	[ProductID] INT NOT NULL , 
    [Name] NVARCHAR(50) NOT NULL, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [Size] INT NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL, 
    [Product_image] IMAGE NOT NULL, 
    [CategoryID] INT NOT NULL, 
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductID]), 
    CONSTRAINT [FK_Products_ToCategories] FOREIGN KEY ([CategoryID]) REFERENCES [Categories]([CategoryID]),

     
  
);


