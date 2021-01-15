CREATE TABLE [dbo].[Order_Items] (
    [Quantity]    NVARCHAR (50) NOT NULL,
    [ProductID]   INT           NOT NULL,
    [OrderID]     INT           NOT NULL,

    CONSTRAINT [FK_Order_Items_Products] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ProductID]),
    CONSTRAINT [FK_Order_Items_Orders] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([OrderID]),
	    CONSTRAINT [PK_Order_Items] PRIMARY KEY CLUSTERED ([OrderID],[ProductID])
);

