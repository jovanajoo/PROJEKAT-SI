CREATE TABLE [dbo].[Customers] (
    [CustomerID]   INT           NOT NULL,
	[Username]     NVARCHAR (50) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [E-mail]       NVARCHAR (40) NOT NULL,
    [City]         NVARCHAR (50) NOT NULL,
    [Address]      NVARCHAR (30) NOT NULL,
    [Phone_number] NVARCHAR (15) NOT NULL,
	[Password]     NVARCHAR (20) NOT NULL,
    [OrderID]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC),
    CONSTRAINT [FK_Customers_ToOrders] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([OrderID])
);

