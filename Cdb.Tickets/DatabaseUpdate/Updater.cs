using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using Cdb.Tickets.BusinessObjects;

namespace Cdb.Tickets.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            #region Create Priorities for the Priority Entity
            // If priority 'Low' does not exist, create it

            Priority low = ObjectSpace.FindObject<Priority>(new BinaryOperator("GenericTextField", "Low"));
            if (low == null)
            {
                low = ObjectSpace.CreateObject<Priority>();
                low.GenericTextField = "Low";
            }
            // If priority 'Medium' does not exist, create it

            Priority normal = ObjectSpace.FindObject<Priority>(new BinaryOperator("GenericTextField", "Normal"));
            if (normal == null)
            {
                normal = ObjectSpace.CreateObject<Priority>();
                normal.GenericTextField = "Normal";
            }
            // If a role with the Administrators name doesn't exist in the database, create this role
            Priority high = ObjectSpace.FindObject<Priority>(new BinaryOperator("GenericTextField", "High"));
            if (high == null)
            {
                high = ObjectSpace.CreateObject<Priority>();
                high.GenericTextField = "High";
            }

            #endregion
            ObjectSpace.CommitChanges();
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
