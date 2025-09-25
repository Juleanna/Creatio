namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using Terrasoft.Common;
    using Terrasoft.Core;
    using Terrasoft.Core.Configuration;
    using Terrasoft.Core.DB;
    using Terrasoft.Core.DcmProcess;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Factories;
    using Terrasoft.Core.Process;
    using Terrasoft.Core.Process.Configuration;

    #region Class: ProductCalculationSchema

    [Schema("ProductCalculation")]
    public class ProductCalculationSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public ProductCalculationSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public ProductCalculationSchema(ProductCalculationSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public ProductCalculationSchema(ProductCalculationSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
            RealUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
            Name = "ProductCalculation";
            ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
            ExtendParent = false;
            CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012");
            IsDBView = false;
            UseDenyRecordRights = false;
            ShowInAdvancedMode = true;
            UseLiveEditing = false;
            UseRecordDeactivation = false;
        }

        protected override void InitializeColumns() {
            base.InitializeColumns();
            if (Columns.FindByUId(new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff")) == null) {
                Columns.Add(CreateProductColumn());
            }
            if (Columns.FindByUId(new Guid("00000000-1111-2222-3333-444444444444")) == null) {
                Columns.Add(CreateIngredientColumn());
            }
            if (Columns.FindByUId(new Guid("11111111-2222-3333-4444-555555555555")) == null) {
                Columns.Add(CreateQuantityColumn());
            }
            if (Columns.FindByUId(new Guid("22222222-3333-4444-5555-666666666666")) == null) {
                Columns.Add(CreateCoefficientColumn());
            }
            if (Columns.FindByUId(new Guid("33333333-4444-5555-6666-777777777777")) == null) {
                Columns.Add(CreateAdjustedQuantityColumn());
            }
            if (Columns.FindByUId(new Guid("44444444-5555-6666-7777-888888888888")) == null) {
                Columns.Add(CreateTotalCostColumn());
            }
            if (Columns.FindByUId(new Guid("55555555-6666-7777-8888-999999999999")) == null) {
                Columns.Add(CreateProductionVolumeColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateProductColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
                UId = new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Name = @"Product",
                ReferenceSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                IsIndexed = true,
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateIngredientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
                UId = new Guid("00000000-1111-2222-3333-444444444444"),
                Name = @"Ingredient",
                ReferenceSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                IsIndexed = true,
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateQuantityColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("11111111-2222-3333-4444-555555555555"),
                Name = @"Quantity",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateCoefficientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("22222222-3333-4444-5555-666666666666"),
                Name = @"Coefficient",
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateAdjustedQuantityColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("33333333-4444-5555-6666-777777777777"),
                Name = @"AdjustedQuantity",
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateTotalCostColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("44444444-5555-6666-7777-888888888888"),
                Name = @"TotalCost",
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateProductionVolumeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("55555555-6666-7777-8888-999999999999"),
                Name = @"ProductionVolume",
                CreatedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                ModifiedInSchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new ProductCalculation(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new ProductCalculation_ProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new ProductCalculationSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new ProductCalculationSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));
        }

        #endregion
    }

    #endregion

    #region Class: ProductCalculation

    public class ProductCalculation : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public ProductCalculation(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "ProductCalculation";
        }

        public ProductCalculation(ProductCalculation source)
            : base(source) {
        }

        #endregion

        #region Properties: Public

        public Guid ProductId {
            get {
                return GetTypedColumnValue<Guid>("ProductId");
            }
            set {
                SetColumnValue("ProductId", value);
            }
        }

        public string ProductName {
            get {
                return GetTypedColumnValue<string>("ProductName");
            }
            set {
                SetColumnValue("ProductName", value);
            }
        }

        public Guid IngredientId {
            get {
                return GetTypedColumnValue<Guid>("IngredientId");
            }
            set {
                SetColumnValue("IngredientId", value);
            }
        }

        public string IngredientName {
            get {
                return GetTypedColumnValue<string>("IngredientName");
            }
            set {
                SetColumnValue("IngredientName", value);
            }
        }

        public double Quantity {
            get {
                return GetTypedColumnValue<double>("Quantity");
            }
            set {
                SetColumnValue("Quantity", value);
            }
        }

        public double Coefficient {
            get {
                return GetTypedColumnValue<double>("Coefficient");
            }
            set {
                SetColumnValue("Coefficient", value);
            }
        }

        public double AdjustedQuantity {
            get {
                return GetTypedColumnValue<double>("AdjustedQuantity");
            }
            set {
                SetColumnValue("AdjustedQuantity", value);
            }
        }

        public decimal TotalCost {
            get {
                return GetTypedColumnValue<decimal>("TotalCost");
            }
            set {
                SetColumnValue("TotalCost", value);
            }
        }

        public double ProductionVolume {
            get {
                return GetTypedColumnValue<double>("ProductionVolume");
            }
            set {
                SetColumnValue("ProductionVolume", value);
            }
        }

        #endregion

        #region Methods: Protected

        protected override Process InitializeEmbeddedProcess() {
            var process = new ProductCalculation_ProductCalculationEventsProcess(UserConnection);
            process.Entity = this;
            return process;
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeThrowEvents() {
            Saved += SavedEventHandler;
            Saving += SavingEventHandler;
            base.InitializeThrowEvents();
        }

        #endregion

        #region Methods: Private

        private void SavingEventHandler(object sender, EntityBeforeEventArgs e) {
            // Расчёт скорректированного количества: Количество * Коэффициент
            if (Coefficient != 0) {
                AdjustedQuantity = Quantity * Coefficient;
            }

            // Расчёт общей стоимости: Скорректированное количество * Объём производства
            if (ProductionVolume != 0) {
                TotalCost = (decimal)(AdjustedQuantity * ProductionVolume);
            }
        }

        private void SavedEventHandler(object sender, EntityAfterEventArgs e) {
            // Дополнительная логика после сохранения, если нужна
        }

        #endregion
    }

    #endregion

    #region Class: ProductCalculation_ProductCalculationEventsProcess

    public partial class ProductCalculation_ProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ProductCalculation
    {
        public ProductCalculation_ProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "ProductCalculation_ProductCalculationEventsProcess";
            SchemaUId = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee");
            }
        }

        #endregion

        #region Properties: Public

        public override string InstanceUId {
            get {
                return Entity.InstanceUId.ToString();
            }
        }

        #endregion

        #region Methods: Private

        private void InitializeFlowElements() {
        }

        private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
            ProcessQueue(e.Context);
        }

        #endregion

        #region Methods: Protected

        protected override void PrepareStart(ProcessExecutingContext context) {
            base.PrepareStart(context);
            context.Process = this;
        }

        protected override bool ProcessQueue(ProcessExecutingContext context) {
            bool result = base.ProcessQueue(context);
            if (context.QueueTasks.Count == 0) {
                return result;
            }
            if (!result && context.QueueTasks.Count > 0) {
                ProcessQueue(context);
            }
            return result;
        }

        #endregion

        #region Methods: Public

        public override void ThrowEvent(ProcessExecutingContext context, string message) {
            base.ThrowEvent(context, message);
            ProcessQueue(context);
        }

        #endregion
    }

    #endregion

    #region Class: ProductCalculation_ProductCalculationEventsProcess

    public class ProductCalculation_ProductCalculationEventsProcess : ProductCalculation_ProductCalculationEventsProcess<ProductCalculation>
    {
        public ProductCalculation_ProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}