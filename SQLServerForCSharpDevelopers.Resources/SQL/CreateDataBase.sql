use BikeStore
GO

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[OrderDetails]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Sales].[OrderDetails]
            DROP CONSTRAINT IF EXISTS [FK_Sales.OrderDetails_Products.Product]
        ALTER TABLE [Sales].[OrderDetails]
            DROP CONSTRAINT IF EXISTS [FK_Sales.OrderDetails_Sales.Order]
        DROP TABLE [Sales].[OrderDetails]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Manager]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Sales].[Manager]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Manager_Sales.Staff]
        ALTER TABLE [Sales].[Manager]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Manager_Sales.Staff]
        DROP TABLE [Sales].[Manager]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Order]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Sales].[Order]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Order_Sales.Customer]
        ALTER TABLE [Sales].[Order]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Order_Sales.Staff]
        ALTER TABLE [Sales].[Order]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Order_Sales.Store]
        DROP TABLE [Sales].[Order]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Products].Stock]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Products].[Stock]
            DROP CONSTRAINT IF EXISTS [FK_Products.Stock_Products.Product]
        ALTER TABLE [Products].[Stock]
            DROP CONSTRAINT IF EXISTS [FK_Products.Stock_Sales.Store]
        DROP TABLE [Products].[Stock]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Products].[Stock]')
            AND type in (N'U'))
    BEGIN
        DROP TABLE [Products].[Stock]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Customer]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Sales].[Customer]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Customer_Sales.Address]
        ALTER TABLE [Sales].[Customer]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Customer_Sales.Contact]
        DROP TABLE [Sales].[Customer]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Staff]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Sales].[Staff]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Staff_Sales.Address]
        ALTER TABLE [Sales].[Staff]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Staff_Sales.Contact]
        ALTER TABLE [Sales].[Staff]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Staff_Sales.Store]
        DROP TABLE [Sales].[Staff]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Store]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Sales].[Store]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Store_Sales.Address]
        ALTER TABLE [Sales].[Store]
            DROP CONSTRAINT IF EXISTS [FK_Sales.Store_Sales.Contact]
        DROP TABLE [Sales].[Store]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Products].[Product]')
            AND type in (N'U'))
    BEGIN
        ALTER TABLE [Products].[Product]
            DROP CONSTRAINT IF EXISTS [FK_Products.Product_Products.Brand]
        ALTER TABLE [Products].[Product]
            DROP CONSTRAINT IF EXISTS [FK_Products.Product_Products.Category]
        DROP TABLE [Products].[Product]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Address]')
            AND type in (N'U'))
    BEGIN
        DROP TABLE [Sales].[Address]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Sales].[Contact]')
            AND type in (N'U'))
    BEGIN
        DROP TABLE [Sales].[Contact]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Products].[Brand]')
            AND type in (N'U'))
    BEGIN
        DROP TABLE [Products].[Brand]
    END

IF EXISTS(SELECT *
          FROM sys.objects
          WHERE object_id = OBJECT_ID(N'[Products].[Category]')
            AND type in (N'U'))
    BEGIN
        DROP TABLE [Products].[Category]
    END

DROP SCHEMA IF EXISTS Sales

DROP SCHEMA IF EXISTS Products
GO

/*********************************************************

Create Tables

**********************************************************/

CREATE SCHEMA Sales
GO
CREATE SCHEMA Products
GO

CREATE TABLE [Sales].[Contact]
(
    [ContactId] [uniqueidentifier] NOT NULL,
    [Phone]     [int]              NULL,
    [Email]     [nvarchar](255)    NULL,
    CONSTRAINT [PK_Sales.Contact] PRIMARY KEY CLUSTERED
        (
         [ContactId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[Address]
(
    [AddressId]    [uniqueidentifier] NOT NULL,
    [AddressLine1] [nvarchar](255)    NOT NULL,
    [AddressLine2] [nvarchar](255)    NULL,
    [StreetName]   [nvarchar](255)    NOT NULL,
    [Town]         [nvarchar](255)    NOT NULL,
    [County]       [nvarchar](255)    NOT NULL,
    [EirCode]      [nvarchar](8)      NULL,
    CONSTRAINT [PK_Sales.Address] PRIMARY KEY CLUSTERED
        (
         [AddressId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[Staff]
(
    [StaffId]   [uniqueidentifier] NOT NULL,
    [StoreId]   [uniqueidentifier] NOT NULL,
    [AddressId] [uniqueidentifier] NOT NULL,
    [ContactId] [uniqueidentifier] NOT NULL,
    [FirstName] [nvarchar](255)    NOT NULL,
    [SurName]   [nvarchar](255)    NOT NULL,
    [Active]    [bit]              NOT NULL,
    [ManagerId] [uniqueidentifier] NULL,
    CONSTRAINT [PK_Sales.Staff] PRIMARY KEY CLUSTERED
        (
         [StaffId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[Store]
(
    [StoreId]   [uniqueidentifier] NOT NULL,
    [AddressId] [uniqueidentifier] NOT NULL,
    [ContactId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Sales.Store] PRIMARY KEY CLUSTERED
        (
         [StoreId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[Manager]
(
    [StaffId] [uniqueidentifier] NOT NULL,
    [StoreId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Sales.Manager] PRIMARY KEY CLUSTERED
        (
         [StaffId] ASC,
         [StoreId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[Customer]
(
    [CustomerId] [uniqueidentifier] NOT NULL,
    [AddressId]  [uniqueidentifier] NOT NULL,
    [ContactId]  [uniqueidentifier] NOT NULL,
    [FirstName]  [nvarchar](255)    NOT NULL,
    [Surname]    [nvarchar](255)    NOT NULL,
    CONSTRAINT [PK_Sales.Customer] PRIMARY KEY CLUSTERED
        (
         [CustomerId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Products].[Brand]
(
    [BrandId]   [uniqueidentifier] NOT NULL,
    [BrandName] [nvarchar](255)    NOT NULL,
    CONSTRAINT [PK_Products.Brand] PRIMARY KEY CLUSTERED
        (
         [BrandId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Products].[Category]
(
    [CategoryId]   [uniqueidentifier] NOT NULL,
    [CategoryName] [nvarchar](255)    NOT NULL,
    CONSTRAINT [PK_Products.Category] PRIMARY KEY CLUSTERED
        (
         [CategoryId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Products].[Product]
(
    [ProductId]  [uniqueidentifier] NOT NULL,
    [BrandId]    [uniqueidentifier] NOT NULL,
    [CategoryId] [uniqueidentifier] NOT NULL,
    [ModelYear]  [tinyint]          NOT NULL,
    [Price]      [decimal](12, 2)   NOT NULL,
    CONSTRAINT [PK_Products.Product] PRIMARY KEY CLUSTERED
        (
         [ProductId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Products].[Stock]
(
    [StoreId]   [uniqueidentifier] NOT NULL,
    [ProductId] [uniqueidentifier] NOT NULL,
    [Quantity]  [int]              NULL,
    CONSTRAINT [PK_Products.Stock] PRIMARY KEY CLUSTERED
        (
         [StoreId] ASC,
         [ProductId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[Order]
(
    [OrderId]     [uniqueidentifier] NOT NULL,
    [StoreId]     [uniqueidentifier] NOT NULL,
    [StaffId]     [uniqueidentifier] NOT NULL,
    [CustomerId]  [uniqueidentifier] NOT NULL,
    [Status]      [int]              NOT NULL,
    [OrderDate]   [datetime2]        NOT NULL,
    [ShippedDate] [datetime2]        NOT NULL,
    [RefundDate]  [datetime2]        NULL
        CONSTRAINT [PK_Sales.Order] PRIMARY KEY CLUSTERED
            (
             [OrderId] ASC
                ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Sales].[OrderDetails]
(
    [OrderId]   [uniqueidentifier] NOT NULL,
    [ProductId] [uniqueidentifier] NOT NULL,
    [Quantity]  [int]              NULL,
    [Price]     [decimal](12, 2)   NOT NULL,
    [VAT]       [decimal](5, 2)    NOT NULL,
    [Discount]  [decimal](5, 2)    NULL,
    CONSTRAINT [PK_Sales.OrderDetails] PRIMARY KEY CLUSTERED
        (
         [OrderId] ASC,
         [ProductId] ASC
            ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/*********************************************************

Add foreign keys and constraints

**********************************************************/

ALTER TABLE [Sales].[Customer]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Customer_Sales.Address] FOREIGN KEY ([AddressId])
        REFERENCES [Sales].[Address] ([AddressId])
        ON UPDATE NO ACTION
        ON DELETE CASCADE
GO

ALTER TABLE [Sales].[Customer]
    CHECK CONSTRAINT [FK_Sales.Customer_Sales.Address]
GO

ALTER TABLE [Sales].[Customer]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Customer_Sales.Contact] FOREIGN KEY ([ContactId])
        REFERENCES [Sales].[Contact] ([ContactId])
        ON UPDATE NO ACTION
        ON DELETE CASCADE
GO

ALTER TABLE [Sales].[Customer]
    CHECK CONSTRAINT [FK_Sales.Customer_Sales.Contact]
GO

ALTER TABLE [Sales].[Staff]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Staff_Sales.Address] FOREIGN KEY ([AddressId])
        REFERENCES [Sales].[Address] ([AddressId])
        ON UPDATE NO ACTION
        ON DELETE CASCADE
GO

ALTER TABLE [Sales].[Staff]
    CHECK CONSTRAINT [FK_Sales.Staff_Sales.Address]
GO

ALTER TABLE [Sales].[Staff]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Staff_Sales.Contact] FOREIGN KEY ([ContactId])
        REFERENCES [Sales].[Contact] ([ContactId])
        ON UPDATE NO ACTION
        ON DELETE CASCADE
GO

ALTER TABLE [Sales].[Staff]
    CHECK CONSTRAINT [FK_Sales.Staff_Sales.Contact]
GO

ALTER TABLE [Sales].[Staff]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Staff_Sales.Store] FOREIGN KEY ([StoreId])
        REFERENCES [Sales].[Store] ([StoreId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Staff]
    CHECK CONSTRAINT [FK_Sales.Staff_Sales.Store]
GO

ALTER TABLE [Sales].[Store]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Store_Sales.Address] FOREIGN KEY ([AddressId])
        REFERENCES [Sales].[Address] ([AddressId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Store]
    CHECK CONSTRAINT [FK_Sales.Store_Sales.Address]
GO

ALTER TABLE [Sales].[Store]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Store_Sales.Contact] FOREIGN KEY ([ContactId])
        REFERENCES [Sales].[Contact] ([ContactId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Store]
    CHECK CONSTRAINT [FK_Sales.Store_Sales.Contact]
GO

ALTER TABLE [Products].[Product]
    WITH CHECK ADD CONSTRAINT [FK_Products.Product_Products.Brand] FOREIGN KEY ([BrandId])
        REFERENCES [Products].[Brand] ([BrandId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Products].[Product]
    CHECK CONSTRAINT [FK_Products.Product_Products.Brand]
GO

ALTER TABLE [Products].[Product]
    WITH CHECK ADD CONSTRAINT [FK_Products.Product_Products.Category] FOREIGN KEY ([CategoryId])
        REFERENCES [Products].[Category] ([CategoryId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Products].[Product]
    CHECK CONSTRAINT [FK_Products.Product_Products.Category]
GO

ALTER TABLE [Products].[Stock]
    WITH CHECK ADD CONSTRAINT [FK_Products.Stock_Products.Product] FOREIGN KEY ([ProductId])
        REFERENCES [Products].[Product] ([ProductId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Products].[Stock]
    CHECK CONSTRAINT [FK_Products.Stock_Products.Product]
GO

ALTER TABLE [Products].[Stock]
    WITH CHECK ADD CONSTRAINT [FK_Products.Stock_Sales.Store] FOREIGN KEY ([StoreId])
        REFERENCES [Sales].[Store] ([StoreId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Products].[Stock]
    CHECK CONSTRAINT [FK_Products.Stock_Sales.Store]
GO

ALTER TABLE [Sales].[Order]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Order_Sales.Customer] FOREIGN KEY ([CustomerId])
        REFERENCES [Sales].[Customer] ([CustomerId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Order]
    CHECK CONSTRAINT [FK_Sales.Order_Sales.Customer]
GO

ALTER TABLE [Sales].[Order]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Order_Sales.Staff] FOREIGN KEY ([StaffId])
        REFERENCES [Sales].[Staff] ([StaffId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Order]
    CHECK CONSTRAINT [FK_Sales.Order_Sales.Staff]
GO

ALTER TABLE [Sales].[Order]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Order_Sales.Store] FOREIGN KEY ([StoreId])
        REFERENCES [Sales].[Store] ([StoreId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Order]
    CHECK CONSTRAINT [FK_Sales.Order_Sales.Store]
GO

ALTER TABLE [Sales].[OrderDetails]
    WITH CHECK ADD CONSTRAINT [FK_Sales.OrderDetails_Products.Product] FOREIGN KEY ([ProductId])
        REFERENCES [Products].[Product] ([ProductId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[OrderDetails]
    CHECK CONSTRAINT [FK_Sales.OrderDetails_Products.Product]
GO

ALTER TABLE [Sales].[OrderDetails]
    WITH CHECK ADD CONSTRAINT [FK_Sales.OrderDetails_Sales.Order] FOREIGN KEY ([OrderId])
        REFERENCES [Sales].[Order] ([OrderId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Manager]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Manager_Sales.Staff] FOREIGN KEY ([StaffId])
        REFERENCES [Sales].[Staff] ([StaffId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Manager]
    CHECK CONSTRAINT [FK_Sales.Manager_Sales.Staff]
GO

ALTER TABLE [Sales].[Manager]
    WITH CHECK ADD CONSTRAINT [FK_Sales.Manager_Sales.Store] FOREIGN KEY ([StoreId])
        REFERENCES [Sales].[Store] ([StoreId])
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
GO

ALTER TABLE [Sales].[Manager]
    CHECK CONSTRAINT [FK_Sales.Manager_Sales.Store]
GO

ALTER TABLE [Sales].[OrderDetails]
    CHECK CONSTRAINT [FK_Sales.OrderDetails_Sales.Order]
GO

ALTER TABLE [Sales].[OrderDetails]
    WITH CHECK ADD CONSTRAINT [CK_OrderDetails_Discount] CHECK (([Discount] IS NULL OR [Discount] >= (0.00) AND [Discount] <= (100.00)))
GO

ALTER TABLE [Sales].[OrderDetails]
    CHECK CONSTRAINT [CK_OrderDetails_Discount]
GO

ALTER TABLE [Sales].[OrderDetails]
    WITH CHECK ADD CONSTRAINT [CK_OrderDetails_VAT] CHECK (([Vat] < (100.00)))
GO

ALTER TABLE [Sales].[OrderDetails]
    CHECK CONSTRAINT [CK_OrderDetails_VAT]
GO

ALTER TABLE [Sales].[Staff]
    ADD CONSTRAINT [DF_Sales.Staff_Active] DEFAULT ((1)) FOR [Active]
GO
