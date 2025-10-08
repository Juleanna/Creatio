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

    #region Class: UsrProductSchema

    /// <exclude/>
    public class UsrProductSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public UsrProductSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public UsrProductSchema(UsrProductSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public UsrProductSchema(UsrProductSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d");
            RealUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d");
            Name = "UsrProduct";
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
            if (Columns.FindByUId(new Guid("d1e2f3a4-b5c6-4d7e-8f9a-0b1c2d3e4f5a")) == null) {
                Columns.Add(CreateUsrNameColumn());
            }
            if (Columns.FindByUId(new Guid("e2f3a4b5-c6d7-4e8f-9a0b-1c2d3e4f5a6b")) == null) {
                Columns.Add(CreateUsrCodeColumn());
            }
            if (Columns.FindByUId(new Guid("f3a4b5c6-d7e8-4f9a-0b1c-2d3e4f5a6b7c")) == null) {
                Columns.Add(CreateUsrDescriptionColumn());
            }
            if (Columns.FindByUId(new Guid("a4b5c6d7-e8f9-40a1-b2c3-d4e5f6a7b8c9")) == null) {
                Columns.Add(CreateUsrUnitColumn());
            }
            if (Columns.FindByUId(new Guid("b5c6d7e8-f9a0-41b2-c3d4-e5f6a7b8c9d0")) == null) {
                Columns.Add(CreateUsrBasePriceColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateUsrNameColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
                UId = new Guid("d1e2f3a4-b5c6-4d7e-8f9a-0b1c2d3e4f5a"),
                Name = @"UsrName",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                ModifiedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false
            };
        }

        protected virtual EntitySchemaColumn CreateUsrCodeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("e2f3a4b5-c6d7-4e8f-9a0b-1c2d3e4f5a6b"),
                Name = @"UsrCode",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                ModifiedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false,
                IsIndexed = true
            };
        }

        protected virtual EntitySchemaColumn CreateUsrDescriptionColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
                UId = new Guid("f3a4b5c6-d7e8-4f9a-0b1c-2d3e4f5a6b7c"),
                Name = @"UsrDescription",
                CreatedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                ModifiedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false
            };
        }

        protected virtual EntitySchemaColumn CreateUsrUnitColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("a4b5c6d7-e8f9-40a1-b2c3-d4e5f6a7b8c9"),
                Name = @"UsrUnit",
                CreatedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                ModifiedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012"),
                IsLocalizable = false,
                DefValue = new EntitySchemaColumnDef() {
                    Source = EntitySchemaColumnDefSource.Const,
                    ValueSource = @"шт"
                }
            };
        }

        protected virtual EntitySchemaColumn CreateUsrBasePriceColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("b5c6d7e8-f9a0-41b2-c3d4-e5f6a7b8c9d0"),
                Name = @"UsrBasePrice",
                CreatedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                ModifiedInSchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new UsrProduct(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new UsrProduct_UsrProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new UsrProductSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new UsrProductSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d"));
        }

        #endregion
    }

    #endregion

    #region Class: UsrProduct

    /// <summary>
    /// Товар.
    /// </summary>
    public class UsrProduct : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public UsrProduct(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "UsrProduct";
        }

        public UsrProduct(UsrProduct source)
            : base(source) {
        }

        #endregion

        #region Properties: Public

        /// <summary>
        /// Назва товару.
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
        /// Код товару.
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
        /// Опис.
        /// </summary>
        public string UsrDescription {
            get {
                return GetTypedColumnValue<string>("UsrDescription");
            }
            set {
                SetColumnValue("UsrDescription", value);
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
        /// Базова ціна.
        /// </summary>
        public decimal UsrBasePrice {
            get {
                return GetTypedColumnValue<decimal>("UsrBasePrice");
            }
            set {
                SetColumnValue("UsrBasePrice", value);
            }
        }

        #endregion

        #region Methods: Protected

        protected override Process InitializeEmbeddedProcess() {
            var process = new UsrProduct_UsrProductCalculationEventsProcess(UserConnection);
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

    #region Class: UsrProduct_UsrProductCalculationEventsProcess

    /// <exclude/>
    public partial class UsrProduct_UsrProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrProduct
    {
        public UsrProduct_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "UsrProduct_UsrProductCalculationEventsProcess";
            SchemaUId = new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("a1b2c3d4-e5f6-4a5b-8c9d-1e2f3a4b5c6d");
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

    #region Class: UsrProduct_UsrProductCalculationEventsProcess

    /// <exclude/>
    public class UsrProduct_UsrProductCalculationEventsProcess : UsrProduct_UsrProductCalculationEventsProcess<UsrProduct>
    {
        public UsrProduct_UsrProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}
