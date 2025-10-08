-- =====================================================
-- Скрипти створення таблиць для модуля калькуляції
-- Версія: 1.0.1 (Creatio 8.x)
-- Дата: 2025-10-08
-- =====================================================

-- Створення таблиці товарів (UsrProduct)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsrProduct]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UsrProduct] (
        [Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        [CreatedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [CreatedById] UNIQUEIDENTIFIER,
        [ModifiedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [ModifiedById] UNIQUEIDENTIFIER,
        [ProcessListeners] INT DEFAULT 0,
        [UsrName] NVARCHAR(500) NOT NULL,
        [UsrCode] NVARCHAR(50) NOT NULL,
        [UsrDescription] NVARCHAR(MAX),
        [UsrUnit] NVARCHAR(50) DEFAULT N'шт',
        [UsrBasePrice] MONEY
    );

    PRINT 'Таблиця UsrProduct створена успішно';
END
ELSE
BEGIN
    PRINT 'Таблиця UsrProduct вже існує';
END
GO

-- Створення таблиці інгредієнтів (UsrIngredient)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsrIngredient]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UsrIngredient] (
        [Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        [CreatedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [CreatedById] UNIQUEIDENTIFIER,
        [ModifiedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [ModifiedById] UNIQUEIDENTIFIER,
        [ProcessListeners] INT DEFAULT 0,
        [UsrName] NVARCHAR(500) NOT NULL,
        [UsrCode] NVARCHAR(50) NOT NULL,
        [UsrUnit] NVARCHAR(50) DEFAULT N'кг',
        [UsrUnitPrice] MONEY,
        [UsrCoefficient] FLOAT DEFAULT 1.00,
        [UsrSupplyDocuments] NVARCHAR(MAX)
    );

    PRINT 'Таблиця UsrIngredient створена успішно';
END
ELSE
BEGIN
    PRINT 'Таблиця UsrIngredient вже існує';
END
GO

-- Створення таблиці калькуляцій (UsrProductCalculation)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsrProductCalculation]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UsrProductCalculation] (
        [Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        [CreatedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [CreatedById] UNIQUEIDENTIFIER,
        [ModifiedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [ModifiedById] UNIQUEIDENTIFIER,
        [ProcessListeners] INT DEFAULT 0,
        [UsrProductId] UNIQUEIDENTIFIER NOT NULL,
        [UsrIngredientId] UNIQUEIDENTIFIER NOT NULL,
        [UsrQuantity] FLOAT NOT NULL,
        [UsrCoefficient] FLOAT DEFAULT 1.00,
        [UsrAdjustedQuantity] FLOAT,
        [UsrProductionVolume] FLOAT,
        [UsrTotalCost] MONEY,
        CONSTRAINT FK_UsrProductCalculation_UsrProduct FOREIGN KEY ([UsrProductId])
            REFERENCES [dbo].[UsrProduct]([Id]) ON DELETE CASCADE,
        CONSTRAINT FK_UsrProductCalculation_UsrIngredient FOREIGN KEY ([UsrIngredientId])
            REFERENCES [dbo].[UsrIngredient]([Id]) ON DELETE CASCADE
    );

    PRINT 'Таблиця UsrProductCalculation створена успішно';
END
ELSE
BEGIN
    PRINT 'Таблиця UsrProductCalculation вже існує';
END
GO

-- Створення індексів для покращення продуктивності
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrProduct_Code' AND object_id = OBJECT_ID('UsrProduct'))
BEGIN
    CREATE INDEX IX_UsrProduct_Code ON [dbo].[UsrProduct]([UsrCode]);
    PRINT 'Індекс IX_UsrProduct_Code створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrProduct_Name' AND object_id = OBJECT_ID('UsrProduct'))
BEGIN
    CREATE INDEX IX_UsrProduct_Name ON [dbo].[UsrProduct]([UsrName]);
    PRINT 'Індекс IX_UsrProduct_Name створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrIngredient_Code' AND object_id = OBJECT_ID('UsrIngredient'))
BEGIN
    CREATE INDEX IX_UsrIngredient_Code ON [dbo].[UsrIngredient]([UsrCode]);
    PRINT 'Індекс IX_UsrIngredient_Code створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrIngredient_Name' AND object_id = OBJECT_ID('UsrIngredient'))
BEGIN
    CREATE INDEX IX_UsrIngredient_Name ON [dbo].[UsrIngredient]([UsrName]);
    PRINT 'Індекс IX_UsrIngredient_Name створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrProductCalculation_ProductId' AND object_id = OBJECT_ID('UsrProductCalculation'))
BEGIN
    CREATE INDEX IX_UsrProductCalculation_ProductId ON [dbo].[UsrProductCalculation]([UsrProductId]);
    PRINT 'Індекс IX_UsrProductCalculation_ProductId створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrProductCalculation_IngredientId' AND object_id = OBJECT_ID('UsrProductCalculation'))
BEGIN
    CREATE INDEX IX_UsrProductCalculation_IngredientId ON [dbo].[UsrProductCalculation]([UsrIngredientId]);
    PRINT 'Індекс IX_UsrProductCalculation_IngredientId створено';
END
GO

PRINT '==================================================';
PRINT 'Всі таблиці та індекси створені успішно!';
PRINT '==================================================';
