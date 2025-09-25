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

    #region Class: ProductSchema

    [Schema("Product")]
    public class ProductSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public ProductSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public ProductSchema(ProductSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public ProductSchema(ProductSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("11111111-1111-1111-1111-111111111111");
            RealUId = new Guid("11111111-1111-1111-1111-111111111111");
            Name = "Product";
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
            if (Columns.FindByUId(new Guid("22222222-2222-2222-2222-222222222222")) == null) {
                Columns.Add(CreateNameColumn());
            }
            if (Columns.FindByUId(new Guid("33333333-3333-3333-3333-333333333333")) == null) {
                Columns.Add(CreateCodeColumn());
            }
            if (Columns.FindByUId(new Guid("44444444-4444-4444-4444-444444444444")) == null) {
                Columns.Add(CreateDescriptionColumn());
            }
            if (Columns.FindByUId(new Guid("55555555-5555-5555-5555-555555555555")) == null) {
                Columns.Add(CreateUnitColumn());
            }
            if (Columns.FindByUId(new Guid("66666666-6666-6666-6666-666666666666")) == null) {
                Columns.Add(CreateBasePriceColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateNameColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
                UId = new Guid("22222222-2222-2222-2222-222222222222"),
                Name = @"Name",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                ModifiedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateCodeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("33333333-3333-3333-3333-333333333333"),
                Name = @"Code",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                ModifiedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateDescriptionColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
                UId = new Guid("44444444-4444-4444-4444-444444444444"),
                Name = @"Description",
                CreatedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                ModifiedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUnitColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("55555555-5555-5555-5555-555555555555"),
                Name = @"Unit",
                CreatedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                ModifiedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateBasePriceColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("66666666-6666-6666-6666-666666666666"),
                Name = @"BasePrice",
                CreatedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                ModifiedInSchemaUId = new Guid("11111111-1111-1111-1111-111111111111"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new Product(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new Product_ProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new ProductSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new ProductSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("11111111-1111-1111-1111-111111111111"));
        }

        #endregion
    }

    #endregion

    #region Class: Product

    public class Product : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public Product(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "Product";
        }

        public Product(Product source)
            : base(source) {
        }

        #endregion

        #region Properties: Public

        public string Name {
            get {
                return GetTypedColumnValue<string>("Name");
            }
            set {
                SetColumnValue("Name", value);
            }
        }

        public string Code {
            get {
                return GetTypedColumnValue<string>("Code");
            }
            set {
                SetColumnValue("Code", value);
            }
        }

        public string Description {
            get {
                return GetTypedColumnValue<string>("Description");
            }
            set {
                SetColumnValue("Description", value);
            }
        }

        public string Unit {
            get {
                return GetTypedColumnValue<string>("Unit");
            }
            set {
                SetColumnValue("Unit", value);
            }
        }

        public decimal BasePrice {
            get {
                return GetTypedColumnValue<decimal>("BasePrice");
            }
            set {
                SetColumnValue("BasePrice", value);
            }
        }

        #endregion

        #region Methods: Protected

        protected override Process InitializeEmbeddedProcess() {
            var process = new Product_ProductCalculationEventsProcess(UserConnection);
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

    #region Class: Product_ProductCalculationEventsProcess

    public partial class Product_ProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Product
    {
        public Product_ProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "Product_ProductCalculationEventsProcess";
            SchemaUId = new Guid("11111111-1111-1111-1111-111111111111");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("11111111-1111-1111-1111-111111111111");
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

    #region Class: Product_ProductCalculationEventsProcess

    public class Product_ProductCalculationEventsProcess : Product_ProductCalculationEventsProcess<Product>
    {
        public Product_ProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}