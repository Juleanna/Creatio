namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Terrasoft.Common;
    using Terrasoft.Core;
    using Terrasoft.Core.Configuration;
    using Terrasoft.Core.DB;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Process;
    using Terrasoft.Core.Process.Configuration;

    #region Class: UsrProductCalculationSchema

    /// <exclude/>
    public class UsrProductCalculationSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public UsrProductCalculationSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public UsrProductCalculationSchema(UsrProductCalculationSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public UsrProductCalculationSchema(UsrProductCalculationSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f");
            RealUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f");
            Name = "UsrProductCalculation";
            ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"); // BaseEntity
            ExtendParent = false;
            CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012");
            IsDBView = false;
            UseDenyRecordRights = false;
            ShowInAdvancedMode = false;
            UseLiveEditing = false;
            UseRecordDeactivation = false;
        }

        protected override void InitializeColumns() {
            base.InitializeColumns();
            if (Columns.FindByUId(new Guid("c2d3e4f5-a6b7-48c9-d0e1-f2a3b4c5d6e7")) == null) {
                Columns.Add(CreateUsrProductColumn());
            }
            if (Columns.FindByUId(new Guid("d3e4f5a6-b7c8-49d0-e1f2-a3b4c5d6e7f8")) == null) {
                Columns.Add(CreateUsrIngredientColumn());
            }
            if (Columns.FindByUId(new Guid("e4f5a6b7-c8d9-40e1-f2a3-b4c5d6e7f8a9")) == null) {
                Columns.Add(CreateUsrQuantityColumn());
            }
            if (Columns.FindByUId(new Guid("f5a6b7c8-d9e0-41f2-a3b4-c5d6e7f8a9b0")) == null) {
                Columns.Add(CreateUsrCoefficientColumn());
            }
            if (Columns.FindByUId(new Guid("a6b7c8d9-e0f1-42a3-b4c5-d6e7f8a9b0c1")) == null) {
                Columns.Add(CreateUsrAdjustedQuantityColumn());
            }
            if (Columns.FindByUId(new Guid("b7c8d9e0-f1a2-43b4-c5d6-e7f8a9b0c1d2")) == null) {
                Columns.Add(CreateUsrProductionVolumeColumn());
            }
            if (Columns.FindByUId(new Guid("c8d9e0f1-a2b3-44c5-d6e7-f8a9b0c1d2e3")) == null) {
                Columns.Add(CreateUsrTotalCostColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateUsrProductColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
                UId = new Guid("c2d3e4f5-a6b7-48c9-d0e1-f2a3b4c5d6e7"),
                Name = @"UsrProduct",
                ReferenceSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"), // UsrProduct
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                IsIndexed = true,
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrIngredientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
                UId = new Guid("d3e4f5a6-b7c8-49d0-e1f2-a3b4c5d6e7f8"),
                Name = @"UsrIngredient",
                ReferenceSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"), // UsrIngredient
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                IsIndexed = true,
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrQuantityColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("e4f5a6b7-c8d9-40e1-f2a3-b4c5d6e7f8a9"),
                Name = @"UsrQuantity",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrCoefficientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("f5a6b7c8-d9e0-41f2-a3b4-c5d6e7f8a9b0"),
                Name = @"UsrCoefficient",
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                DefValue = new EntitySchemaColumnDef() {
                    Source = EntitySchemaColumnDefSource.Const,
                    ValueSource = @"1.00"
                }
            };
        }

        protected virtual EntitySchemaColumn CreateUsrAdjustedQuantityColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("a6b7c8d9-e0f1-42a3-b4c5-d6e7f8a9b0c1"),
                Name = @"UsrAdjustedQuantity",
                UsageType = EntitySchemaColumnUsageType.None,
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrProductionVolumeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("b7c8d9e0-f1a2-43b4-c5d6-e7f8a9b0c1d2"),
                Name = @"UsrProductionVolume",
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrTotalCostColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("c8d9e0f1-a2b3-44c5-d6e7-f8a9b0c1d2e3"),
                Name = @"UsrTotalCost",
                UsageType = EntitySchemaColumnUsageType.None,
                CreatedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                ModifiedInSchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new UsrProductCalculation(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new UsrProductCalculation_UsrProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new UsrProductCalculationSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new UsrProductCalculationSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f"));
        }

        #endregion
    }

    #endregion

    #region Class: UsrProductCalculation

    /// <summary>
    /// Калькуляція товару.
    /// </summary>
    public class UsrProductCalculation : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public UsrProductCalculation(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "UsrProductCalculation";
        }

        public UsrProductCalculation(UsrProductCalculation source)
            : base(source) {
        }

        #endregion

        #region Properties: Public

        /// <exclude/>
        public Guid UsrProductId {
            get {
                return GetTypedColumnValue<Guid>("UsrProductId");
            }
            set {
                SetColumnValue("UsrProductId", value);
                _usrProduct = null;
            }
        }

        /// <exclude/>
        public string UsrProductUsrName {
            get {
                return GetTypedColumnValue<string>("UsrProductUsrName");
            }
            set {
                SetColumnValue("UsrProductUsrName", value);
                if (_usrProduct != null) {
                    _usrProduct.UsrName = value;
                }
            }
        }

        private UsrProduct _usrProduct;
        /// <summary>
        /// Товар.
        /// </summary>
        public UsrProduct UsrProduct {
            get {
                return _usrProduct ??
                    (_usrProduct = LookupColumnEntities.GetEntity("UsrProduct") as UsrProduct);
            }
        }

        /// <exclude/>
        public Guid UsrIngredientId {
            get {
                return GetTypedColumnValue<Guid>("UsrIngredientId");
            }
            set {
                SetColumnValue("UsrIngredientId", value);
                _usrIngredient = null;
            }
        }

        /// <exclude/>
        public string UsrIngredientUsrName {
            get {
                return GetTypedColumnValue<string>("UsrIngredientUsrName");
            }
            set {
                SetColumnValue("UsrIngredientUsrName", value);
                if (_usrIngredient != null) {
                    _usrIngredient.UsrName = value;
                }
            }
        }

        private UsrIngredient _usrIngredient;
        /// <summary>
        /// Інгредієнт.
        /// </summary>
        public UsrIngredient UsrIngredient {
            get {
                return _usrIngredient ??
                    (_usrIngredient = LookupColumnEntities.GetEntity("UsrIngredient") as UsrIngredient);
            }
        }

        /// <summary>
        /// Кількість.
        /// </summary>
        public double UsrQuantity {
            get {
                return GetTypedColumnValue<double>("UsrQuantity");
            }
            set {
                SetColumnValue("UsrQuantity", value);
            }
        }

        /// <summary>
        /// Коефіцієнт.
        /// </summary>
        public double UsrCoefficient {
            get {
                return GetTypedColumnValue<double>("UsrCoefficient");
            }
            set {
                SetColumnValue("UsrCoefficient", value);
            }
        }

        /// <summary>
        /// Скоригована кількість (автоматично).
        /// </summary>
        public double UsrAdjustedQuantity {
            get {
                return GetTypedColumnValue<double>("UsrAdjustedQuantity");
            }
            set {
                SetColumnValue("UsrAdjustedQuantity", value);
            }
        }

        /// <summary>
        /// Об'єм виробництва.
        /// </summary>
        public double UsrProductionVolume {
            get {
                return GetTypedColumnValue<double>("UsrProductionVolume");
            }
            set {
                SetColumnValue("UsrProductionVolume", value);
            }
        }

        /// <summary>
        /// Загальна вартість (автоматично).
        /// </summary>
        public decimal UsrTotalCost {
            get {
                return GetTypedColumnValue<decimal>("UsrTotalCost");
            }
            set {
                SetColumnValue("UsrTotalCost", value);
            }
        }

        #endregion

        #region Methods: Protected

        protected override Process InitializeEmbeddedProcess() {
            var process = new UsrProductCalculation_UsrProductCalculationEventsProcess(UserConnection);
            process.Entity = this;
            return process;
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeThrowEvents() {
            Saving += OnSaving;
            base.InitializeThrowEvents();
        }

        #endregion

        #region Methods: Private

        /// <summary>
        /// Обчислює скориговану кількість та загальну вартість перед збереженням.
        /// </summary>
        private void OnSaving(object sender, EntityBeforeEventArgs e) {
            // Розрахунок скоригованої кількості: Кількість × Коефіцієнт
            UsrAdjustedQuantity = UsrQuantity * UsrCoefficient;

            // Отримуємо ціну інгредієнта з пов'язаного запису
            decimal unitPrice = 0;
            if (UsrIngredientId != Guid.Empty) {
                var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "UsrIngredient");
                var unitPriceColumn = esq.AddColumn("UsrUnitPrice");
                var entity = esq.GetEntity(UserConnection, UsrIngredientId);
                if (entity != null) {
                    unitPrice = entity.GetTypedColumnValue<decimal>("UsrUnitPrice");
                }
            }

            // Розрахунок загальної вартості: Скоригована кількість × Об'єм виробництва × Ціна за одиницю
            UsrTotalCost = (decimal)(UsrAdjustedQuantity * UsrProductionVolume) * unitPrice;
        }

        #endregion
    }

    #endregion

    #region Class: UsrProductCalculation_UsrProductCalculationEventsProcess

    /// <exclude/>
    public partial class UsrProductCalculation_UsrProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrProductCalculation
    {
        public UsrProductCalculation_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "UsrProductCalculation_UsrProductCalculationEventsProcess";
            SchemaUId = new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("c3d4e5f6-a7b8-4c5d-0e1f-3a4b5c6d7e8f");
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

    #region Class: UsrProductCalculation_UsrProductCalculationEventsProcess

    /// <exclude/>
    public class UsrProductCalculation_UsrProductCalculationEventsProcess : UsrProductCalculation_UsrProductCalculationEventsProcess<UsrProductCalculation>
    {
        public UsrProductCalculation_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}
