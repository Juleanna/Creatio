namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using Terrasoft.Common;
    using Terrasoft.Core;
    using Terrasoft.Core.DB;
    using Terrasoft.Core.Entities;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceModel.Activation;

    /// <summary>
    /// Сервис для импорта данных калькуляции из Excel файлов
    /// </summary>
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ExcelImportService
    {
        #region Fields: Private

        private UserConnection _userConnection;

        #endregion

        #region Constructors: Public

        public ExcelImportService() {
            _userConnection = (UserConnection)System.Web.HttpContext.Current.Session["UserConnection"];
        }

        public ExcelImportService(UserConnection userConnection) {
            _userConnection = userConnection;
        }

        #endregion

        #region Methods: Public

        /// <summary>
        /// Импорт данных калькуляции из данных Excel
        /// </summary>
        /// <param name="excelData">Данные из Excel файла</param>
        /// <returns>Результат импорта</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "ImportExcelCalculation")]
        public ImportResult ImportExcelCalculation(List<ExcelCalculationRow> excelData) {
            var result = new ImportResult();

            try {
                // Создаем или находим продукт (по заголовку файла)
                var product = GetOrCreateProduct("Калькуляционная карта", "CALC-001", "шт");

                foreach (var row in excelData) {
                    if (string.IsNullOrEmpty(row.Name)) {
                        continue;
                    }

                    // Создаем или находим ингредиент
                    var ingredient = GetOrCreateIngredient(row);

                    // Создаем запись калькуляции
                    CreateProductCalculation(product.Id, ingredient.Id, row);

                    result.ProcessedRows++;
                }

                result.Success = true;
                result.Message = $"Успешно импортировано {result.ProcessedRows} строк";

            } catch (Exception ex) {
                result.Success = false;
                result.Message = $"Ошибка при импорте: {ex.Message}";
            }

            return result;
        }

        /// <summary>
        /// Расчёт общей стоимости продукта
        /// </summary>
        /// <param name="productId">ID продукта</param>
        /// <param name="productionVolume">Объём производства</param>
        /// <returns>Общая стоимость</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "CalculateTotalCost")]
        public CalculationResult CalculateTotalCost(Guid productId, double productionVolume) {
            var result = new CalculationResult();

            try {
                var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "ProductCalculation");
                esq.AddColumn("Ingredient.Name");
                esq.AddColumn("Ingredient.UnitPrice");
                esq.AddColumn("Quantity");
                esq.AddColumn("Coefficient");
                esq.AddColumn("AdjustedQuantity");

                var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
                    "Product", productId);
                esq.Filters.Add(filter);

                var calculations = esq.GetEntityCollection(_userConnection);

                decimal totalCost = 0;
                var details = new List<CalculationDetail>();

                foreach (var calc in calculations) {
                    var quantity = calc.GetTypedColumnValue<double>("Quantity");
                    var coefficient = calc.GetTypedColumnValue<double>("Coefficient");
                    var unitPrice = calc.GetTypedColumnValue<decimal>("Ingredient.UnitPrice");
                    var ingredientName = calc.GetTypedColumnValue<string>("Ingredient.Name");

                    var adjustedQuantity = quantity * coefficient;
                    var lineCost = (decimal)(adjustedQuantity * productionVolume) * unitPrice;

                    totalCost += lineCost;

                    details.Add(new CalculationDetail {
                        IngredientName = ingredientName,
                        Quantity = quantity,
                        Coefficient = coefficient,
                        AdjustedQuantity = adjustedQuantity,
                        UnitPrice = unitPrice,
                        LineCost = lineCost
                    });

                    // Обновляем запись калькуляции
                    var update = new Update(_userConnection, "ProductCalculation")
                        .Set("AdjustedQuantity", Column.Parameter(adjustedQuantity))
                        .Set("TotalCost", Column.Parameter(lineCost))
                        .Set("ProductionVolume", Column.Parameter(productionVolume))
                        .Where("Id").IsEqual(Column.Parameter(calc.PrimaryColumnValue));

                    update.Execute();
                }

                result.Success = true;
                result.TotalCost = totalCost;
                result.ProductionVolume = productionVolume;
                result.Details = details;

            } catch (Exception ex) {
                result.Success = false;
                result.Message = $"Ошибка при расчёте: {ex.Message}";
            }

            return result;
        }

        #endregion

        #region Methods: Private

        private Entity GetOrCreateProduct(string name, string code, string unit) {
            var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "Product");
            esq.AddAllSchemaColumns();
            var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", code);
            esq.Filters.Add(filter);

            var existing = esq.GetEntityCollection(_userConnection);

            if (existing.Count > 0) {
                return existing[0];
            }

            // Создаем новый продукт
            var product = _userConnection.EntitySchemaManager.GetInstanceByName("Product").CreateEntity(_userConnection);
            product.SetDefColumnValues();
            product.SetColumnValue("Name", name);
            product.SetColumnValue("Code", code);
            product.SetColumnValue("Unit", unit);
            product.Save();

            return product;
        }

        private Entity GetOrCreateIngredient(ExcelCalculationRow row) {
            var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "Ingredient");
            esq.AddAllSchemaColumns();
            var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", row.Code);
            esq.Filters.Add(filter);

            var existing = esq.GetEntityCollection(_userConnection);

            if (existing.Count > 0) {
                return existing[0];
            }

            // Создаем новый ингредиент
            var ingredient = _userConnection.EntitySchemaManager.GetInstanceByName("Ingredient").CreateEntity(_userConnection);
            ingredient.SetDefColumnValues();
            ingredient.SetColumnValue("Name", row.Name);
            ingredient.SetColumnValue("Code", row.Code);
            ingredient.SetColumnValue("Unit", row.Unit);
            ingredient.SetColumnValue("UnitPrice", row.UnitPrice);
            ingredient.SetColumnValue("Coefficient", row.Coefficient);
            ingredient.SetColumnValue("SupplyDocuments", row.SupplyDocuments);
            ingredient.Save();

            return ingredient;
        }

        private void CreateProductCalculation(Guid productId, Guid ingredientId, ExcelCalculationRow row) {
            var calculation = _userConnection.EntitySchemaManager.GetInstanceByName("ProductCalculation").CreateEntity(_userConnection);
            calculation.SetDefColumnValues();
            calculation.SetColumnValue("ProductId", productId);
            calculation.SetColumnValue("IngredientId", ingredientId);
            calculation.SetColumnValue("Quantity", row.Quantity);
            calculation.SetColumnValue("Coefficient", row.Coefficient);
            calculation.SetColumnValue("AdjustedQuantity", row.Quantity * row.Coefficient);
            calculation.SetColumnValue("ProductionVolume", row.ProductionVolume);

            // Рассчитываем общую стоимость
            var totalCost = row.Quantity * row.Coefficient * row.ProductionVolume * (double)row.UnitPrice;
            calculation.SetColumnValue("TotalCost", totalCost);

            calculation.Save();
        }

        #endregion
    }

    #region Classes: Public

    /// <summary>
    /// Строка данных из Excel файла
    /// </summary>
    public class ExcelCalculationRow
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public double Coefficient { get; set; }
        public decimal UnitPrice { get; set; }
        public double ProductionVolume { get; set; }
        public string SupplyDocuments { get; set; }
    }

    /// <summary>
    /// Результат импорта
    /// </summary>
    public class ImportResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int ProcessedRows { get; set; }
    }

    /// <summary>
    /// Результат расчёта стоимости
    /// </summary>
    public class CalculationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public decimal TotalCost { get; set; }
        public double ProductionVolume { get; set; }
        public List<CalculationDetail> Details { get; set; } = new List<CalculationDetail>();
    }

    /// <summary>
    /// Детальная информация по расчёту
    /// </summary>
    public class CalculationDetail
    {
        public string IngredientName { get; set; }
        public double Quantity { get; set; }
        public double Coefficient { get; set; }
        public double AdjustedQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineCost { get; set; }
    }

    #endregion
}