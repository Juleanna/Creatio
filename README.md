# Система калькуляции товаров для Creatio

Этот проект содержит полную систему для управления калькуляцией товаров и ингредиентов в Creatio.

## Структура проекта

```
D:\Creatio\
├── descriptor.json                 # Описание пакета Creatio
├── Schemas/                       # Схемы сущностей
│   ├── Product.cs                 # Схема товаров
│   ├── Ingredient.cs              # Схема ингредиентов
│   ├── ProductCalculation.cs      # Схема калькуляции
│   └── ExcelImportService.cs      # Сервис импорта из Excel
├── SqlScripts/
│   └── CreateTables.sql           # Скрипты создания таблиц
├── Files/                         # Дополнительные файлы
├── import_excel_data.py           # Python скрипт для анализа Excel
├── calculation_data.json          # Экспорт данных в JSON
├── insert_calculation_data.sql    # SQL скрипт для импорта данных
└── README.md                      # Этот файл
```

## Основные сущности

### 1. Product (Товары)
- **Name** - Название товара
- **Code** - Код товара
- **Description** - Описание
- **Unit** - Единица измерения
- **BasePrice** - Базовая цена

### 2. Ingredient (Ингредиенты)
- **Name** - Название ингредиента
- **Code** - Код ингредиента
- **Unit** - Единица измерения
- **UnitPrice** - Цена за единицу
- **Coefficient** - Коэффициент
- **SupplyDocuments** - Документы поставки

### 3. ProductCalculation (Калькуляция)
- **Product** - Связь с товаром
- **Ingredient** - Связь с ингредиентом
- **Quantity** - Количество
- **Coefficient** - Коэффициент
- **AdjustedQuantity** - Скорректированное количество (Количество × Коэффициент)
- **TotalCost** - Общая стоимость
- **ProductionVolume** - Объём производства

## Установка

### 1. Установка в Creatio

1. Создайте новый пакет в Creatio или используйте существующий
2. Скопируйте файлы из папки `Schemas/` в папку схем вашего пакета
3. Выполните SQL скрипты из `SqlScripts/CreateTables.sql` для создания таблиц
4. Перекомпилируйте приложение

### 2. Импорт данных из Excel

#### Вариант A: Используя Python скрипт

```bash
# Установите зависимости
pip install pandas openpyxl requests

# Запустите скрипт
python import_excel_data.py

# Выберите нужное действие:
# 1 - Анализ данных
# 2 - Экспорт в JSON
# 3 - Генерация SQL скриптов
# 4 - Всё вместе
```

#### Вариант B: Используя SQL скрипты

1. Запустите `import_excel_data.py` с опцией 3 для генерации SQL
2. Выполните сгенерированный файл `insert_calculation_data.sql` в базе данных

#### Вариант C: Используя веб-сервис

```javascript
// Пример вызова сервиса импорта
var excelData = [
    {
        "Name": "Мясо говяжье",
        "Code": "18-0426",
        "Unit": "кг",
        "Quantity": 1.5,
        "Coefficient": 1.02,
        "UnitPrice": 46820.00,
        "ProductionVolume": 30000,
        "SupplyDocuments": "Накладная №1 от 24.12.24"
    }
    // ... другие ингредиенты
];

ServiceHelper.CallService("ExcelImportService", "ImportExcelCalculation",
    { excelData: excelData }, callback);
```

## Формулы расчёта

### Скорректированное количество
```
AdjustedQuantity = Quantity × Coefficient
```

### Общая стоимость ингредиента
```
TotalCost = AdjustedQuantity × ProductionVolume × UnitPrice
```

### Общая стоимость товара
```
ProductTotalCost = Σ(TotalCost всех ингредиентов)
```

## Использование

### 1. Создание товара
```csharp
var product = new Product(userConnection);
product.Name = "Калькуляционная карта изделия";
product.Code = "CALC-001";
product.Unit = "шт";
product.Save();
```

### 2. Создание ингредиента
```csharp
var ingredient = new Ingredient(userConnection);
ingredient.Name = "Мясо говяжье";
ingredient.Code = "18-0426";
ingredient.Unit = "кг";
ingredient.UnitPrice = 46820m;
ingredient.Coefficient = 1.02;
ingredient.Save();
```

### 3. Создание калькуляции
```csharp
var calculation = new ProductCalculation(userConnection);
calculation.ProductId = productId;
calculation.IngredientId = ingredientId;
calculation.Quantity = 1.5;
calculation.Coefficient = 1.02;
calculation.ProductionVolume = 30000;
calculation.Save(); // AdjustedQuantity и TotalCost рассчитываются автоматически
```

### 4. Расчёт общей стоимости
```csharp
var service = new ExcelImportService(userConnection);
var result = service.CalculateTotalCost(productId, 30000);
```

## Анализ данных из Excel

Из вашего Excel файла была извлечена следующая структура:

- **16 ингредиентов** для производства товара
- **Объём производства**: 30,000 единиц
- **Общая стоимость**: 4,058,288,004.72 (это может быть ошибка в данных - проверьте цены)

### Основные ингредиенты:
1. Мясо говяжье - 1.5 кг (коэф. 1.02)
2. Печень говяжья - 0.4 кг (коэф. 1.02)
3. Почки говяжьи - 0.4 кг (коэф. 1.02)
4. Шпиг свиной - 0.5 кг (коэф. 1.02)
5. Соль поваренная - 1.55 кг (коэф. 1.02)

## Возможные доработки

1. **Интерфейс загрузки Excel файлов** - создание веб-страницы для загрузки файлов
2. **Отчёты по калькуляции** - создание отчётов с детализацией
3. **История изменений** - отслеживание изменений в калькуляции
4. **Проверка правильности данных** - валидация входных данных
5. **Экспорт в Excel** - обратный экспорт результатов расчётов

## Контакты

Для вопросов по использованию обращайтесь к разработчику.