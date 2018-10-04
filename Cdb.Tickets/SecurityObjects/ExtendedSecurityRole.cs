using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Cdb.Tickets.SecurityObjects
{
    [DefaultClassOptions, ImageName("BO_Role")]
    public class ExtendedSecurityRole : PermissionPolicyRole
    {
        public ExtendedSecurityRole(Session session) : base(session) { }
        public bool CanExport
        {
            get { return GetPropertyValue<bool>("CanExport"); }
            set { SetPropertyValue<bool>("CanExport", value); }
        }
        /*
        protected override IEnumerable<IOperationPermission> GetPermissionsCore() {
            List<IOperationPermission> result = new List<IOperationPermission>();
            result.AddRange(base.GetPermissionsCore());
            if (CanExport) result.Add(new ExportPermission());
            return result;
        }*/
    }
}