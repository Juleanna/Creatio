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

    #region Class: UsrMaterialSchema

    /// <summary>
    /// Матеріал (сировина).
    /// </summary>
    public class UsrMaterialSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public UsrMaterialSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public UsrMaterialSchema(UsrMaterialSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public UsrMaterialSchema(UsrMaterialSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a");
            RealUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a");
            Name = "UsrMaterial";
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
            if (Columns.FindByUId(new Guid("f6a7b8c9-d0e1-42f3-a4b5-c6d7e8f9a0b1")) == null) {
                Columns.Add(CreateUsrNameColumn());
            }
            if (Columns.FindByUId(new Guid("a7b8c9d0-e1f2-43a4-b5c6-d7e8f9a0b1c2")) == null) {
                Columns.Add(CreateUsrCodeColumn());
            }
            if (Columns.FindByUId(new Guid("b8c9d0e1-f2a3-44b5-c6d7-e8f9a0b1c2d3")) == null) {
                Columns.Add(CreateUsrUnitColumn());
            }
            if (Columns.FindByUId(new Guid("c9d0e1f2-a3b4-45c6-d7e8-f9a0b1c2d3e4")) == null) {
                Columns.Add(CreateUsrUnitPriceColumn());
            }
            if (Columns.FindByUId(new Guid("d0e1f2a3-b4c5-46d7-e8f9-a0b1c2d3e4f5")) == null) {
                Columns.Add(CreateUsrWasteCoefficientColumn());
            }
            if (Columns.FindByUId(new Guid("e1f2a3b4-c5d6-47e8-f9a0-b1c2d3e4f5a6")) == null) {
                Columns.Add(CreateUsrSupplyDocumentsColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateUsrNameColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
                UId = new Guid("f6a7b8c9-d0e1-42f3-a4b5-c6d7e8f9a0b1"),
                Name = @"UsrName",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                ModifiedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false
            };
        }

        protected virtual EntitySchemaColumn CreateUsrCodeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("a7b8c9d0-e1f2-43a4-b5c6-d7e8f9a0b1c2"),
                Name = @"UsrCode",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                ModifiedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false,
                IsIndexed = true
            };
        }

        protected virtual EntitySchemaColumn CreateUsrUnitColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("b8c9d0e1-f2a3-44b5-c6d7-e8f9a0b1c2d3"),
                Name = @"UsrUnit",
                CreatedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                ModifiedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
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
                UId = new Guid("c9d0e1f2-a3b4-45c6-d7e8-f9a0b1c2d3e4"),
                Name = @"UsrUnitPrice",
                CreatedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                ModifiedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUsrWasteCoefficientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("d0e1f2a3-b4c5-46d7-e8f9-a0b1c2d3e4f5"),
                Name = @"UsrWasteCoefficient",
                CreatedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                ModifiedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                DefValue = new EntitySchemaColumnDef() {
                    Source = EntitySchemaColumnDefSource.Const,
                    ValueSource = @"1.00"
                }
            };
        }

        protected virtual EntitySchemaColumn CreateUsrSupplyDocumentsColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
                UId = new Guid("e1f2a3b4-c5d6-47e8-f9a0-b1c2d3e4f5a6"),
                Name = @"UsrSupplyDocuments",
                CreatedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                ModifiedInSchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new UsrMaterial(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new UsrMaterial_UsrProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new UsrMaterialSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new UsrMaterialSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a"));
        }

        #endregion
    }

    #endregion

    #region Class: UsrMaterial

    /// <summary>
    /// Матеріал (сировина).
    /// </summary>
    public class UsrMaterial : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public UsrMaterial(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "UsrMaterial";
        }

        public UsrMaterial(UsrMaterial source)
            : base(source) {
        }

        #endregion

        #region Properties: Public

        /// <summary>
        /// Назва матеріалу.
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
        /// Код матеріалу.
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
        /// Коефіцієнт витрат (wastage).
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
            var process = new UsrMaterial_UsrProductCalculationEventsProcess(UserConnection);
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

    #region Class: UsrMaterial_UsrProductCalculationEventsProcess

    /// <exclude/>
    public partial class UsrMaterial_UsrProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrMaterial
    {
        public UsrMaterial_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "UsrMaterial_UsrProductCalculationEventsProcess";
            SchemaUId = new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("d4e5f6a7-b8c9-4d0e-1f2a-3b4c5d6e7f8a");
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

    #region Class: UsrMaterial_UsrProductCalculationEventsProcess

    /// <exclude/>
    public class UsrMaterial_UsrProductCalculationEventsProcess : UsrMaterial_UsrProductCalculationEventsProcess<UsrMaterial>
    {
        public UsrMaterial_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}
