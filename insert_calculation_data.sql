-- Скрипт для импорта данных калькуляции
-- Сгенерирован автоматически

-- Создание продукта
INSERT INTO Product (Id, Name, Code, Unit, BasePrice) VALUES
(NEWID(), 'Калькуляционная карта изготовления изделия', 'CALC-001', 'шт', 0);

DECLARE @ProductId UNIQUEIDENTIFIER = (SELECT Id FROM Product WHERE Code = 'CALC-001');

-- Создание ингредиентов
INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Гладко пофарбоване
трикотажне ворсове
начісне полотно типу
“фліс”', '18-0426', 'мп', 1.53, 1.02, N'Акт №1 від 24.12.24                                                                             Акт №2 від 24.12.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = '18-0426'), 1.5, 1.02, 1.53, 70227.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Поліамідна тканина', '18-0426', 'мп', 0.41, 1.02, N'ВН №1230 від 23.01.25');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = '18-0426'), 0.4, 1.02, 0.40800000000000003, 5018.4, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Поліестерова сітка', '18-0426', 'мп', 0.41, 1.02, N'ВН №1230 від 23.01.25');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = '18-0426'), 0.4, 1.02, 0.40800000000000003, 5018.4, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Стрічка еластична', 'чорний', 'мп', 0.51, 1.02, N'ВН №103 від 21.01.25');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'чорний'), 0.5, 1.02, 0.51, 7803.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Шнур еластичний', 'хакі', 'мп', 1.58, 1.02, N'ВН №7092 від 30.09.24                                    ВН №2985 від 31.05.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 1.55, 1.02, 1.5810000000000002, 74939.40000000001, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Шнур плетений', 'хакі', 'шт', 1.1, 1.0, N'ВН №1259 від 23.09.24                                   ВН №53 від 17.01.25');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 1.1, 1.0, 1.1, 36300.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Тасьма репсова', 'хакі', 'мп', 2.86, 1.02, N'ВН №1218 від 17.09.24                                ВН №1259 від 23.09.24                                   ВН №53 від 17.01.25                                     ВН №103 від 21.01.25');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 2.8, 1.02, 2.856, 245044.8, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Застібка текстильна "петля" 2,5', 'хакі', 'мп', 0.27, 1.02, N'ВН №4938 від 12.09.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 0.26, 1.02, 0.2652, 2148.1200000000003, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Застібка текстильна "петля" 4,0', 'хакі', 'мп', 0.61, 1.02, N'ВН №1060 від 13.02.24                                       ВН №4541 від 23.08.24                                               ВН №4938 від 12.09.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 0.6, 1.02, 0.612, 11199.6, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Застібка текстильна "петля" 5,0', 'хакі', 'мп', 0.1, 1.02, N'ВН №1060 від 13.02.24                                               ВН №4938 від 12.09.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 0.1, 1.02, 0.10200000000000001, 306.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Застібка-блискавка №6 20см.', 'хакі', 'шт', 2.0, 1.0, N'ВН №3294 від 10.06.24                           ВН №3495 від 21.06.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 2.0, 1.0, 2.0, 120000.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Застібка-блискавка роз'ємна з двома замками №6                                                  65,70-75,80см.', 'хакі', 'шт', 1.0, 1.0, N'ВН №79 від 17.01.25                                  ВН №82 від 21.01.25                                                                                  ВН №3495 від 21.06.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 1.0, 1.0, 1.0, 30000.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Фіксатор шнура з двома отворами Тип 3.', 'хакі', 'шт', 2.0, 1.0, N'ВН №107 від 09.05.24                                                    ВН №51 від 04.09.24                                                         ВН №55 від 06.09.24                                      ВН №56 від 09.09.24                                      ВН №57 від 10.09.24                                      ВН №60 від 12.09.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі'), 2.0, 1.0, 2.0, 120000.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Нитки армовані', 'хакі 264', 'мп', 306.0, 1.02, N'ВН №2818 від 31.05.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі 264'), 300.0, 1.02, 306.0, 2809080000.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Нитки поліестерові', 'хакі 264', 'мп', 204.0, 1.02, N'ВН №2818 від 31.05.24');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = 'хакі 264'), 200.0, 1.02, 204.0, 1248480000.0, 30000);

INSERT INTO Ingredient (Id, Name, Code, Unit, UnitPrice, Coefficient, SupplyDocuments) VALUES
(NEWID(), N'Директор', '', 'кг', 0.0, 1.0, N'Б.В.Сидоренко');

INSERT INTO ProductCalculation (Id, ProductId, IngredientId, Quantity, Coefficient, AdjustedQuantity, TotalCost, ProductionVolume) VALUES
(NEWID(), @ProductId, (SELECT Id FROM Ingredient WHERE Code = ''), 0.0, 1.0, 0.0, 0.0, 30000);

