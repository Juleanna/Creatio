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

    #region Class: UsrProductCompositionSchema

    /// <summary>
    /// Склад виробу (калькуляція).
    /// </summary>
    public class UsrProductCompositionSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public UsrProductCompositionSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public UsrProductCompositionSchema(UsrProductCompositionSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public UsrProductCompositionSchema(UsrProductCompositionSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b");
            RealUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b");
            Name = "UsrProductComposition";
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
            if (Columns.FindByUId(new Guid("f2a3b4c5-d6e7-48f9-a0b1-c2d3e4f5a6b7")) == null) {
                Columns.Add(CreateUsrProductColumn());
            }
            if (Columns.FindByUId(new Guid("a3b4c5d6-e7f8-49a0-b1c2-d3e4f5a6b7c8")) == null) {
                Columns.Add(CreateUsrMaterialColumn());
            }
            if (Columns.FindByUId(new Guid("b4c5d6e7-f8a9-40b1-c2d3-e4f5a6b7c8d9")) == null) {
                Columns.Add(CreateUsrQuantityColumn());
            }
            if (Columns.FindByUId(new Guid("c5d6e7f8-a9b0-41c2-d3e4-f5a6b7c8d9e0")) == null) {
                Columns.Add(CreateUsrWasteCoefficientColumn());
            }
            if (Columns.FindByUId(new Guid("d6e7f8a9-b0c1-42d3-e4f5-a6b7c8d9e0f1")) == null) {
                Columns.Add(CreateUsrAdjustedQuantityColumn());
            }
            if (Columns.FindByUId(new Guid("e7f8a9b0-c1d2-43e4-f5a6-b7c8d9e0f1a2")) == null) {
                Columns.Add(CreateUsrProductionVolumeColumn());
            }
            if (Columns.FindByUId(new Guid("f8a9b0c1-d2e3-44f5-a6b7-c8d9e0f1a2b3")) == null) {
                Columns.Add(CreateUsrTotalCostColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateUsrProductColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
                UId = new Guid("f2a3b4c5-d6e7-48f9-a0b1-c2d3e4f5a6b7"),
                Name = @"UsrProduct",
                ReferenceSchemaUId = new Guid("88a31d51-6167-4980-8872-25c39784e8dc"), // Product schema UId
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                IsIndexed = true,
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrMaterialColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
                UId = new Guid("a3b4c5d6-e7f8-49a0-b1c2-d3e4f5a6b7c8"),
                Name = @"UsrMaterial",
                ReferenceSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"), // UsrMaterial
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                IsIndexed = true,
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrQuantityColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("b4c5d6e7-f8a9-40b1-c2d3-e4f5a6b7c8d9"),
                Name = @"UsrQuantity",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrWasteCoefficientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("c5d6e7f8-a9b0-41c2-d3e4-f5a6b7c8d9e0"),
                Name = @"UsrWasteCoefficient",
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                DefValue = new EntitySchemaColumnDef() {
                    Source = EntitySchemaColumnDefSource.Const,
                    ValueSource = @"1.00"
                }
            };
        }

        protected virtual EntitySchemaColumn CreateUsrAdjustedQuantityColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("d6e7f8a9-b0c1-42d3-e4f5-a6b7c8d9e0f1"),
                Name = @"UsrAdjustedQuantity",
                UsageType = EntitySchemaColumnUsageType.None,
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrProductionVolumeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("e7f8a9b0-c1d2-43e4-f5a6-b7c8d9e0f1a2"),
                Name = @"UsrProductionVolume",
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrTotalCostColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("f8a9b0c1-d2e3-44f5-a6b7-c8d9e0f1a2b3"),
                Name = @"UsrTotalCost",
                UsageType = EntitySchemaColumnUsageType.None,
                CreatedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                ModifiedInSchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new UsrProductComposition(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new UsrProductComposition_UsrProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new UsrProductCompositionSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new UsrProductCompositionSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b"));
        }

        #endregion
    }

    #endregion

    #region Class: UsrProductComposition

    /// <summary>
    /// Склад виробу (деталь калькуляції).
    /// </summary>
    public class UsrProductComposition : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public UsrProductComposition(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "UsrProductComposition";
        }

        public UsrProductComposition(UsrProductComposition source)
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
            }
        }

        /// <exclude/>
        public Guid UsrMaterialId {
            get {
                return GetTypedColumnValue<Guid>("UsrMaterialId");
            }
            set {
                SetColumnValue("UsrMaterialId", value);
            }
        }

        /// <summary>
        /// Кількість матеріалу на одиницю товару.
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
        /// Коефіцієнт витрат.
        /// </summary>
        public double UsrWasteCoefficient {
            get {
                return GetTypedColumnValue<double>("UsrWasteCoefficient");
            }
            set {
                SetColumnValue("UsrWasteCoefficient", value);
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
            var process = new UsrProductComposition_UsrProductCalculationEventsProcess(UserConnection);
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
            UsrAdjustedQuantity = UsrQuantity * UsrWasteCoefficient;

            // Отримуємо ціну матеріалу
            decimal unitPrice = 0;
            if (UsrMaterialId != Guid.Empty) {
                var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "UsrMaterial");
                var unitPriceColumn = esq.AddColumn("UsrUnitPrice");
                var entity = esq.GetEntity(UserConnection, UsrMaterialId);
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

    #region Class: UsrProductComposition_UsrProductCalculationEventsProcess

    /// <exclude/>
    public partial class UsrProductComposition_UsrProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrProductComposition
    {
        public UsrProductComposition_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "UsrProductComposition_UsrProductCalculationEventsProcess";
            SchemaUId = new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("e5f6a7b8-c9d0-4e1f-2a3b-4c5d6e7f8a9b");
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

    #region Class: UsrProductComposition_UsrProductCalculationEventsProcess

    /// <exclude/>
    public class UsrProductComposition_UsrProductCalculationEventsProcess : UsrProductComposition_UsrProductCalculationEventsProcess<UsrProductComposition>
    {
        public UsrProductComposition_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}
