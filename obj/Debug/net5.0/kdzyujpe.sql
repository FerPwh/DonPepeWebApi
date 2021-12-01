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

CREATE TABLE [CabeceraFactura] (
    [nrofactura] int NOT NULL IDENTITY,
    [fecha] datetime2 NOT NULL,
    [total] int NOT NULL,
    [idcliente] int NOT NULL,
    CONSTRAINT [PK_CabeceraFactura] PRIMARY KEY ([nrofactura])
);
GO

CREATE TABLE [Categoria] (
    [idcategoria] int NOT NULL IDENTITY,
    [nombre] nvarchar(max) NULL,
    CONSTRAINT [PK_Categoria] PRIMARY KEY ([idcategoria])
);
GO

CREATE TABLE [Cliente] (
    [idcliente] int NOT NULL IDENTITY,
    [nombre] nvarchar(max) NULL,
    [apellido] nvarchar(max) NULL,
    [dni] int NOT NULL,
    [edad] int NOT NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY ([idcliente])
);
GO

CREATE TABLE [DetalleFactura] (
    [nrofactura] int NOT NULL,
    [linea] int NOT NULL,
    [codproducto] int NOT NULL,
    [cantidad] int NOT NULL,
    [total] int NOT NULL,
    CONSTRAINT [PK_DetalleFactura] PRIMARY KEY ([nrofactura], [linea])
);
GO

CREATE TABLE [Producto] (
    [codproducto] int NOT NULL IDENTITY,
    [nombre] nvarchar(max) NULL,
    [marca] nvarchar(max) NULL,
    [cantidad] int NOT NULL,
    [vencimiento] int NOT NULL,
    [idcategoria] int NOT NULL,
    [precio] int NOT NULL,
    CONSTRAINT [PK_Producto] PRIMARY KEY ([codproducto])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idcategoria', N'nombre') AND [object_id] = OBJECT_ID(N'[Categoria]'))
    SET IDENTITY_INSERT [Categoria] ON;
INSERT INTO [Categoria] ([idcategoria], [nombre])
VALUES (1, N'Gaseosas'),
(2, N'Fideos'),
(3, N'Galletitas'),
(4, N'Lacteos');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idcategoria', N'nombre') AND [object_id] = OBJECT_ID(N'[Categoria]'))
    SET IDENTITY_INSERT [Categoria] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idcliente', N'apellido', N'dni', N'edad', N'nombre') AND [object_id] = OBJECT_ID(N'[Cliente]'))
    SET IDENTITY_INSERT [Cliente] ON;
INSERT INTO [Cliente] ([idcliente], [apellido], [dni], [edad], [nombre])
VALUES (1, N'Lopez', 21195003, 45, N'Raul'),
(2, N'Parada', 20517319, 29, N'Jeni'),
(3, N'Perez', 27145119, 55, N'Rosita');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idcliente', N'apellido', N'dni', N'edad', N'nombre') AND [object_id] = OBJECT_ID(N'[Cliente]'))
    SET IDENTITY_INSERT [Cliente] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'codproducto', N'cantidad', N'idcategoria', N'marca', N'nombre', N'precio', N'vencimiento') AND [object_id] = OBJECT_ID(N'[Producto]'))
    SET IDENTITY_INSERT [Producto] ON;
INSERT INTO [Producto] ([codproducto], [cantidad], [idcategoria], [marca], [nombre], [precio], [vencimiento])
VALUES (45714, 2, 3, N'Bagley', N'Surtido', 195, 2025),
(45713, 3, 3, N'Arcor', N'Saladix Jamon', 108, 2023),
(45712, 7, 3, N'Arcor', N'Saladix Pizza', 108, 2023),
(45711, 7, 3, N'Oreo', N'Galletitas', 187, 2024),
(45692, 2, 2, N'Favorita', N'Spaghetti', 50, 2025),
(45683, 5, 1, N'Coca Cola', N'Cola 2,25L', 200, 2023),
(45690, 10, 2, N'Lucchetti', N'Spaghetti', 102, 2026),
(45670, 20, 4, N'Serenisima', N'Larga Vida 2%', 85, 2022),
(45682, 7, 1, N'Coca Cola', N'Cola 1,25L', 170, 2023),
(45681, 5, 1, N'Coca Cola', N'Coca 500ML', 150, 2023),
(45691, 6, 2, N'Knorr', N'Spaghetti', 106, 2027),
(45671, 10, 4, N'Serenisima', N'Larga Vida 3%', 87, 2022);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'codproducto', N'cantidad', N'idcategoria', N'marca', N'nombre', N'precio', N'vencimiento') AND [object_id] = OBJECT_ID(N'[Producto]'))
    SET IDENTITY_INSERT [Producto] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211129064513_InitMigration', N'5.0.12');
GO

COMMIT;
GO

