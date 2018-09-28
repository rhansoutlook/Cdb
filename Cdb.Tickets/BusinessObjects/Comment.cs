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
    public class Comment : BaseObject
    {
        // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        private Ticket ticketId;
        private InternalUser internalUserId;        
        public Comment(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Foreign Keys
        [Association("Ticket-Comments"), ImmediatePostData]
        public Ticket TicketId
        {
            get
            {
                return ticketId;
            }
            set
            {
                SetPropertyValue("TicketId", ref ticketId, value);
            }
        }
        [Association("InternalUser-Comments"), ImmediatePostData]
        public InternalUser InternalUserId
        {
            get
            {
                return internalUserId;
            }
            set
            {
                SetPropertyValue("InternalUserId", ref internalUserId, value);
            }
        }
        #endregion


    }
}