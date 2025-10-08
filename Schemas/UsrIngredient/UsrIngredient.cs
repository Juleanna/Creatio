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

    #region Class: UsrIngredientSchema

    /// <exclude/>
    public class UsrIngredientSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public UsrIngredientSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public UsrIngredientSchema(UsrIngredientSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public UsrIngredientSchema(UsrIngredientSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e");
            RealUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e");
            Name = "UsrIngredient";
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
            if (Columns.FindByUId(new Guid("c6d7e8f9-a0b1-42c3-d4e5-f6a7b8c9d0e1")) == null) {
                Columns.Add(CreateUsrNameColumn());
            }
            if (Columns.FindByUId(new Guid("d7e8f9a0-b1c2-43d4-e5f6-a7b8c9d0e1f2")) == null) {
                Columns.Add(CreateUsrCodeColumn());
            }
            if (Columns.FindByUId(new Guid("e8f9a0b1-c2d3-44e5-f6a7-b8c9d0e1f2a3")) == null) {
                Columns.Add(CreateUsrUnitColumn());
            }
            if (Columns.FindByUId(new Guid("f9a0b1c2-d3e4-45f6-a7b8-c9d0e1f2a3b4")) == null) {
                Columns.Add(CreateUsrUnitPriceColumn());
            }
            if (Columns.FindByUId(new Guid("a0b1c2d3-e4f5-46a7-b8c9-d0e1f2a3b4c5")) == null) {
                Columns.Add(CreateUsrCoefficientColumn());
            }
            if (Columns.FindByUId(new Guid("b1c2d3e4-f5a6-47b8-c9d0-e1f2a3b4c5d6")) == null) {
                Columns.Add(CreateUsrSupplyDocumentsColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateUsrNameColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
                UId = new Guid("c6d7e8f9-a0b1-42c3-d4e5-f6a7b8c9d0e1"),
                Name = @"UsrName",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                ModifiedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false
            };
        }

        protected virtual EntitySchemaColumn CreateUsrCodeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("d7e8f9a0-b1c2-43d4-e5f6-a7b8c9d0e1f2"),
                Name = @"UsrCode",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                ModifiedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false,
                IsIndexed = true
            };
        }

        protected virtual EntitySchemaColumn CreateUsrUnitColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("e8f9a0b1-c2d3-44e5-f6a7-b8c9d0e1f2a3"),
                Name = @"UsrUnit",
                CreatedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                ModifiedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false,
                DefValue = new EntitySchemaColumnDef() {
                    Source = EntitySchemaColumnDefSource.Const,
                    ValueSource = @"кг"
                }
            };
        }

        protected virtual EntitySchemaColumn CreateUsrUnitPriceColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("f9a0b1c2-d3e4-45f6-a7b8-c9d0e1f2a3b4"),
                Name = @"UsrUnitPrice",
                CreatedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                ModifiedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrCoefficientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("a0b1c2d3-e4f5-46a7-b8c9-d0e1f2a3b4c5"),
                Name = @"UsrCoefficient",
                CreatedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                ModifiedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                DefValue = new EntitySchemaColumnDef() {
                    Source = EntitySchemaColumnDefSource.Const,
                    ValueSource = @"1.00"
                }
            };
        }

        protected virtual EntitySchemaColumn CreateUsrSupplyDocumentsColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
                UId = new Guid("b1c2d3e4-f5a6-47b8-c9d0-e1f2a3b4c5d6"),
                Name = @"UsrSupplyDocuments",
                CreatedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                ModifiedInSchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new UsrIngredient(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new UsrIngredient_UsrProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new UsrIngredientSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new UsrIngredientSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e"));
        }

        #endregion
    }

    #endregion

    #region Class: UsrIngredient

    /// <summary>
    /// Інгредієнт (матеріал).
    /// </summary>
    public class UsrIngredient : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public UsrIngredient(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "UsrIngredient";
        }

        public UsrIngredient(UsrIngredient source)
            : base(source) {
        }

        #endregion

        #region Properties: Public

        /// <summary>
        /// Назва інгредієнта.
        /// </summary>
        public string UsrName {
            get {
                return GetTypedColumnValue<string>("UsrName");
            }
            set {
                SetColumnValue("UsrName", value);
            }
        }

        /// <summary>
        /// Код інгредієнта.
        /// </summary>
        public string UsrCode {
            get {
                return GetTypedColumnValue<string>("UsrCode");
            }
            set {
                SetColumnValue("UsrCode", value);
            }
        }

        /// <summary>
        /// Одиниця вимірювання.
        /// </summary>
        public string UsrUnit {
            get {
                return GetTypedColumnValue<string>("UsrUnit");
            }
            set {
                SetColumnValue("UsrUnit", value);
            }
        }

        /// <summary>
        /// Ціна за одиницю.
        /// </summary>
        public decimal UsrUnitPrice {
            get {
                return GetTypedColumnValue<decimal>("UsrUnitPrice");
            }
            set {
                SetColumnValue("UsrUnitPrice", value);
            }
        }

        /// <summary>
        /// Коефіцієнт витрат.
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
        /// Документи постачання.
        /// </summary>
        public string UsrSupplyDocuments {
            get {
                return GetTypedColumnValue<string>("UsrSupplyDocuments");
            }
            set {
                SetColumnValue("UsrSupplyDocuments", value);
            }
        }

        #endregion

        #region Methods: Protected

        protected override Process InitializeEmbeddedProcess() {
            var process = new UsrIngredient_UsrProductCalculationEventsProcess(UserConnection);
            process.Entity = this;
            return process;
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeThrowEvents() {
            base.InitializeThrowEvents();
        }

        #endregion
    }

    #endregion

    #region Class: UsrIngredient_UsrProductCalculationEventsProcess

    /// <exclude/>
    public partial class UsrIngredient_UsrProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrIngredient
    {
        public UsrIngredient_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "UsrIngredient_UsrProductCalculationEventsProcess";
            SchemaUId = new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("b2c3d4e5-f6a7-4b5c-9d0e-2f3a4b5c6d7e");
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

    #region Class: UsrIngredient_UsrProductCalculationEventsProcess

    /// <exclude/>
    public class UsrIngredient_UsrProductCalculationEventsProcess : UsrIngredient_UsrProductCalculationEventsProcess<UsrIngredient>
    {
        public UsrIngredient_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}
