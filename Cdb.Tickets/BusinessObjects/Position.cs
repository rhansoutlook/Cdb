using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using Cdb.Tickets.Components;
using Cdb.Tickets.SecurityObjects;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Description")]
    public class Position : BaseObject, IPosition
    { 
        public Position(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region IPosition
        public string Description { get; set; }

        [Association("Position-Internal User")]
        public XPCollection<InternalUser> InternalUsers
        {
            get
            {
                return GetCollection<InternalUser>("InternalUsers");
            }
        }
        #endregion
    }
}