using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
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
        private string commentText;
        public Comment(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        [DisplayName("Enter comments")]
        [Size(4096)]
        public string CommentText
        {
            get
            {
                return commentText;
            }
            set
            {
                SetPropertyValue("CommentText", ref commentText, value);
            }
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