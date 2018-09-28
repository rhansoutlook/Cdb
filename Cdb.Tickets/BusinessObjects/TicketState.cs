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
    public class TicketState : BaseObject
    { 
        // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public TicketState(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()

        {
            base.AfterConstruction();
        }

        [Association("TicketState-Tickets")]
        public XPCollection<Ticket> Tickets
        {
            get
            {
                return GetCollection<Ticket>("Tickets");
            }
        }

    }
}