IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Categories] (
    [CategoryID] int NOT NULL IDENTITY,
    [CategoryName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryID])
);
GO

CREATE TABLE [Members] (
    [MemberID] int NOT NULL IDENTITY,
    [MemberName] nvarchar(max) NOT NULL,
    [Email] nvarchar(20) NOT NULL,
    [Password] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_Members] PRIMARY KEY ([MemberID])
);
GO

CREATE TABLE [Products] (
    [ProductID] int NOT NULL IDENTITY,
    [ProductName] nvarchar(max) NOT NULL,
    [UnitsInStock] int NOT NULL,
    [UnitPrice] float NOT NULL,
    [CategoryID] int NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductID]),
    CONSTRAINT [FK_Products_Categories_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [Categories] ([CategoryID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Orders] (
    [OrderID] int NOT NULL IDENTITY,
    [OrderDate] datetime2 NOT NULL,
    [MemberID] int NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderID]),
    CONSTRAINT [FK_Orders_Members_MemberID] FOREIGN KEY ([MemberID]) REFERENCES [Members] ([MemberID]) ON DELETE CASCADE
);
GO

CREATE TABLE [OrderDetails] (
    [OrderDetailID] int NOT NULL IDENTITY,
    [OrderID] int NOT NULL,
    [ProductID] int NOT NULL,
    [Quantity] int NOT NULL,
    [UnitPrice] float NOT NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderDetailID]),
    CONSTRAINT [FK_OrderDetails_Orders_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [Orders] ([OrderID]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderDetails_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([ProductID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_OrderDetails_OrderID] ON [OrderDetails] ([OrderID]);
GO

CREATE INDEX [IX_OrderDetails_ProductID] ON [OrderDetails] ([ProductID]);
GO

CREATE INDEX [IX_Orders_MemberID] ON [Orders] ([MemberID]);
GO

CREATE INDEX [IX_Products_CategoryID] ON [Products] ([CategoryID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211028064714_InitDB', N'5.0.11');
GO

COMMIT;
GO

