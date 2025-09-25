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

    #region Class: IngredientSchema

    [Schema("Ingredient")]
    public class IngredientSchema : Terrasoft.Configuration.BaseEntitySchema
    {
        #region Constructors: Public

        public IngredientSchema(EntitySchemaManager entitySchemaManager)
            : base(entitySchemaManager) {
        }

        public IngredientSchema(IngredientSchema source, bool isShallowClone)
            : base(source, isShallowClone) {
        }

        public IngredientSchema(IngredientSchema source)
            : base(source) {
        }

        #endregion

        #region Methods: Protected

        protected override void InitializeProperties() {
            base.InitializeProperties();
            UId = new Guid("77777777-7777-7777-7777-777777777777");
            RealUId = new Guid("77777777-7777-7777-7777-777777777777");
            Name = "Ingredient";
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
            if (Columns.FindByUId(new Guid("88888888-8888-8888-8888-888888888888")) == null) {
                Columns.Add(CreateNameColumn());
            }
            if (Columns.FindByUId(new Guid("99999999-9999-9999-9999-999999999999")) == null) {
                Columns.Add(CreateCodeColumn());
            }
            if (Columns.FindByUId(new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa")) == null) {
                Columns.Add(CreateUnitColumn());
            }
            if (Columns.FindByUId(new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb")) == null) {
                Columns.Add(CreateUnitPriceColumn());
            }
            if (Columns.FindByUId(new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc")) == null) {
                Columns.Add(CreateCoefficientColumn());
            }
            if (Columns.FindByUId(new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd")) == null) {
                Columns.Add(CreateSupplyDocumentsColumn());
            }
        }

        protected virtual EntitySchemaColumn CreateNameColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
                UId = new Guid("88888888-8888-8888-8888-888888888888"),
                Name = @"Name",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                ModifiedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateCodeColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("99999999-9999-9999-9999-999999999999"),
                Name = @"Code",
                RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
                CreatedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                ModifiedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUnitColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
                UId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                Name = @"Unit",
                CreatedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                ModifiedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateUnitPriceColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
                UId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                Name = @"UnitPrice",
                CreatedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                ModifiedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateCoefficientColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
                UId = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                Name = @"Coefficient",
                CreatedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                ModifiedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        protected virtual EntitySchemaColumn CreateSupplyDocumentsColumn() {
            return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
                UId = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                Name = @"SupplyDocuments",
                CreatedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                ModifiedInSchemaUId = new Guid("77777777-7777-7777-7777-777777777777"),
                CreatedInPackageId = new Guid("12345678-1234-1234-1234-123456789012")
            };
        }

        #endregion

        #region Methods: Public

        public override Entity CreateEntity(UserConnection userConnection) {
            return new Ingredient(userConnection) { Schema = this };
        }

        public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
            return new Ingredient_ProductCalculationEventsProcess(userConnection);
        }

        public override object Clone() {
            return new IngredientSchema(this);
        }

        public override EntitySchema CloneShallow() {
            return new IngredientSchema(this, true);
        }

        public override void GetParentRealUIds(Collection<Guid> realUIds) {
            base.GetParentRealUIds(realUIds);
            realUIds.Add(new Guid("77777777-7777-7777-7777-777777777777"));
        }

        #endregion
    }

    #endregion

    #region Class: Ingredient

    public class Ingredient : Terrasoft.Configuration.BaseEntity
    {
        #region Constructors: Public

        public Ingredient(UserConnection userConnection)
            : base(userConnection) {
            SchemaName = "Ingredient";
        }

        public Ingredient(Ingredient source)
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

        public string Unit {
            get {
                return GetTypedColumnValue<string>("Unit");
            }
            set {
                SetColumnValue("Unit", value);
            }
        }

        public decimal UnitPrice {
            get {
                return GetTypedColumnValue<decimal>("UnitPrice");
            }
            set {
                SetColumnValue("UnitPrice", value);
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

        public string SupplyDocuments {
            get {
                return GetTypedColumnValue<string>("SupplyDocuments");
            }
            set {
                SetColumnValue("SupplyDocuments", value);
            }
        }

        #endregion

        #region Methods: Protected

        protected override Process InitializeEmbeddedProcess() {
            var process = new Ingredient_ProductCalculationEventsProcess(UserConnection);
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

    #region Class: Ingredient_ProductCalculationEventsProcess

    public partial class Ingredient_ProductCalculationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Ingredient
    {
        public Ingredient_ProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
            InitializeMetaPathParameterValues();
            UId = Guid.NewGuid();
            Name = "Ingredient_ProductCalculationEventsProcess";
            SchemaUId = new Guid("77777777-7777-7777-7777-777777777777");
            SchemaManagerName = "EntitySchemaManager";
            SerializeToDB = false;
            IsLogging = false;
            InitializeFlowElements();
        }

        #region Properties: Private

        private Guid InternalSchemaUId {
            get {
                return new Guid("77777777-7777-7777-7777-777777777777");
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

    #region Class: Ingredient_ProductCalculationEventsProcess

    public class Ingredient_ProductCalculationEventsProcess : Ingredient_ProductCalculationEventsProcess<Ingredient>
    {
        public Ingredient_ProductCalculationEventsProcess(UserConnection userConnection)
            : base(userConnection) {
        }
    }

    #endregion
}