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
        [Association("InternalUser-TicketsAssignedTo")]
        public XPCollection<Ticket> AssignedToTickets
        {
            get
            {
                return GetCollection<Ticket>("AssignedToTickets");
            }
        }
        [Association("InternalUser-TicketsRaisedBy")]
        public XPCollection<Ticket> RaisedByTickets
        {
            get
            {
                return GetCollection<Ticket>("RaisedByTickets");
            }
        }
        [Association("InternalUser-Comments")]
        public XPCollection<Comment> Comments
        {
            get
            {
                return GetCollection<Comment>("Comments");
            }
        }
        [Association("Manager-TicketResponses"), ImmediatePostData]
        public XPCollection<TicketResponse> TicketResponses
        {
            get
            {
                return GetCollection<TicketResponse>("TicketResponses");
            }
        }
        #endregion

    }
}