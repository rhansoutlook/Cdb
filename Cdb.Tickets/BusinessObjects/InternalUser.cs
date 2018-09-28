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

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    public class InternalUser : User
    {
        // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        private Boolean isFormerEmployee;
        public InternalUser(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        public bool IsFormerEmployee
        {
            get
            {
                return isFormerEmployee;
            }
            set
            {
                SetPropertyValue("IsFormerEmployee", ref isFormerEmployee, value);
            }
        }

        #region OneToMany
        [Association("InternalUser-Tickets")]
        public XPCollection<InternalUser> AssignedToTickets
        {
            get
            {
                return GetCollection<InternalUser>("AssignedToTickets");
            }
        }
        [Association("InternalUser-Tickets")]
        public XPCollection<InternalUser> RaisedByTickets
        {
            get
            {
                return GetCollection<InternalUser>("RaisedByTickets");
            }
        }
        #endregion

    }
}