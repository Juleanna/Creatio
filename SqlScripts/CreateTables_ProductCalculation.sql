-- =====================================================
-- Скрипти створення таблиць для калькуляції товарів
-- Інтеграція з існуючим об'єктом Product
-- Версія: 1.0.2
-- Дата: 2025-10-08
-- =====================================================

-- Створення таблиці матеріалів (UsrMaterial)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsrMaterial]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UsrMaterial] (
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
        [UsrWasteCoefficient] FLOAT DEFAULT 1.00,
        [UsrSupplyDocuments] NVARCHAR(MAX)
    );

    PRINT 'Таблиця UsrMaterial створена успішно';
END
ELSE
BEGIN
    PRINT 'Таблиця UsrMaterial вже існує';
END
GO

-- Створення таблиці складу виробу (UsrProductComposition)
-- Зв'язує існуючий Product з UsrMaterial
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsrProductComposition]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[UsrProductComposition] (
        [Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        [CreatedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [CreatedById] UNIQUEIDENTIFIER,
        [ModifiedOn] DATETIME2 DEFAULT GETUTCDATE(),
        [ModifiedById] UNIQUEIDENTIFIER,
        [ProcessListeners] INT DEFAULT 0,
        -- Посилання на існуючий Product
        [UsrProductId] UNIQUEIDENTIFIER NOT NULL,
        -- Посилання на матеріал
        [UsrMaterialId] UNIQUEIDENTIFIER NOT NULL,
        -- Кількість матеріалу на одиницю товару
        [UsrQuantity] FLOAT NOT NULL,
        -- Коефіцієнт витрат (wastage factor)
        [UsrWasteCoefficient] FLOAT DEFAULT 1.00,
        -- Скоригована кількість (автоматично: Quantity × WasteCoefficient)
        [UsrAdjustedQuantity] FLOAT,
        -- Об'єм виробництва
        [UsrProductionVolume] FLOAT,
        -- Загальна вартість (автоматично: AdjustedQuantity × ProductionVolume × UnitPrice)
        [UsrTotalCost] MONEY,
        -- Зовнішні ключі
        CONSTRAINT FK_UsrProductComposition_Product FOREIGN KEY ([UsrProductId])
            REFERENCES [dbo].[Product]([Id]) ON DELETE CASCADE,
        CONSTRAINT FK_UsrProductComposition_UsrMaterial FOREIGN KEY ([UsrMaterialId])
            REFERENCES [dbo].[UsrMaterial]([Id]) ON DELETE CASCADE
    );

    PRINT 'Таблиця UsrProductComposition створена успішно';
END
ELSE
BEGIN
    PRINT 'Таблиця UsrProductComposition вже існує';
END
GO

-- Створення індексів для покращення продуктивності
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrMaterial_Code' AND object_id = OBJECT_ID('UsrMaterial'))
BEGIN
    CREATE INDEX IX_UsrMaterial_Code ON [dbo].[UsrMaterial]([UsrCode]);
    PRINT 'Індекс IX_UsrMaterial_Code створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrMaterial_Name' AND object_id = OBJECT_ID('UsrMaterial'))
BEGIN
    CREATE INDEX IX_UsrMaterial_Name ON [dbo].[UsrMaterial]([UsrName]);
    PRINT 'Індекс IX_UsrMaterial_Name створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrProductComposition_ProductId' AND object_id = OBJECT_ID('UsrProductComposition'))
BEGIN
    CREATE INDEX IX_UsrProductComposition_ProductId ON [dbo].[UsrProductComposition]([UsrProductId]);
    PRINT 'Індекс IX_UsrProductComposition_ProductId створено';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_UsrProductComposition_MaterialId' AND object_id = OBJECT_ID('UsrProductComposition'))
BEGIN
    CREATE INDEX IX_UsrProductComposition_MaterialId ON [dbo].[UsrProductComposition]([UsrMaterialId]);
    PRINT 'Індекс IX_UsrProductComposition_MaterialId створено';
END
GO

PRINT '==================================================';
PRINT 'Всі таблиці та індекси створені успішно!';
PRINT '==================================================';
PRINT '';
PRINT 'Створені таблиці:';
PRINT '  1. UsrMaterial - довідник матеріалів';
PRINT '  2. UsrProductComposition - склад виробу (деталь для Product)';
PRINT '';
PRINT 'Наступні кроки:';
PRINT '  1. Додайте схеми UsrMaterial та UsrProductComposition в Creatio';
PRINT '  2. Скомпілюйте проект';
PRINT '  3. Додайте деталь UsrProductComposition на форму Product';
PRINT '';
