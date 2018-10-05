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
using Cdb.Tickets.SecurityObjects;
using Cdb.Tickets.Components;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    public class Comment : BaseObject, IComment
    {
        #region Private declarations
        private Ticket ticket;
        private InternalUser internalUser;
        private string commentText;
        private DateTime commentDate;
        #endregion

        public Comment(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region IComment
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
        public DateTime CommentDate
        {
            get
            {
                return commentDate;
            }
            set
            {
                SetPropertyValue("CommentDate", ref commentDate, value);
            }
        }        

        [Association("Ticket-Comments"), ImmediatePostData]
        public Ticket Ticket
        {
            get
            {
                return ticket;
            }
            set
            {
                SetPropertyValue("Ticket", ref ticket, value);
            }
        }

        [Association("InternalUser-Comments"), ImmediatePostData]
        public InternalUser InternalUser
        {
            get
            {
                return internalUser;
            }
            set
            {
                SetPropertyValue("InternalUser", ref internalUser, value);
            }
        }
        #endregion
    }
}