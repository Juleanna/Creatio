-- Создание таблицы продуктов (товаров)
CREATE TABLE Product (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    CreatedOn DATETIME2 DEFAULT GETUTCDATE(),
    CreatedById UNIQUEIDENTIFIER,
    ModifiedOn DATETIME2 DEFAULT GETUTCDATE(),
    ModifiedById UNIQUEIDENTIFIER,
    Name NVARCHAR(500) NOT NULL,
    Code NVARCHAR(50) NOT NULL,
    Description NVARCHAR(MAX),
    Unit NVARCHAR(50),
    BasePrice MONEY
);

-- Создание таблицы ингредиентов
CREATE TABLE Ingredient (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    CreatedOn DATETIME2 DEFAULT GETUTCDATE(),
    CreatedById UNIQUEIDENTIFIER,
    ModifiedOn DATETIME2 DEFAULT GETUTCDATE(),
    ModifiedById UNIQUEIDENTIFIER,
    Name NVARCHAR(500) NOT NULL,
    Code NVARCHAR(50) NOT NULL,
    Unit NVARCHAR(50),
    UnitPrice MONEY,
    Coefficient FLOAT,
    SupplyDocuments NVARCHAR(MAX)
);

-- Создание таблицы калькуляций (связь между продуктами и ингредиентами)
CREATE TABLE ProductCalculation (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    CreatedOn DATETIME2 DEFAULT GETUTCDATE(),
    CreatedById UNIQUEIDENTIFIER,
    ModifiedOn DATETIME2 DEFAULT GETUTCDATE(),
    ModifiedById UNIQUEIDENTIFIER,
    ProductId UNIQUEIDENTIFIER NOT NULL,
    IngredientId UNIQUEIDENTIFIER NOT NULL,
    Quantity FLOAT NOT NULL,
    Coefficient FLOAT,
    AdjustedQuantity FLOAT,
    TotalCost MONEY,
    ProductionVolume FLOAT,
    FOREIGN KEY (ProductId) REFERENCES Product(Id),
    FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id)
);

-- Создание индексов для улучшения производительности
CREATE INDEX IX_Product_Code ON Product(Code);
CREATE INDEX IX_Product_Name ON Product(Name);
CREATE INDEX IX_Ingredient_Code ON Ingredient(Code);
CREATE INDEX IX_Ingredient_Name ON Ingredient(Name);
CREATE INDEX IX_ProductCalculation_ProductId ON ProductCalculation(ProductId);
CREATE INDEX IX_ProductCalculation_IngredientId ON ProductCalculation(IngredientId);