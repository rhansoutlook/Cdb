using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Validation;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using Cdb.Tickets.BusinessObjects;
using DevExpress.Persistent.Base.General;
using DisplayNameAttribute = DevExpress.Xpo.DisplayNameAttribute;
using Cdb.Tickets.Components;

namespace Cdb.Tickets.SecurityObjects
{
    [DefaultClassOptions]
    public class InternalUser : PermissionPolicyUser, IInternalUser
    {
        #region Internl Declarations
        private Boolean isFormerEmployee;
        private Boolean isManager;
        private string email;
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        private Position position;
        #endregion

        public InternalUser(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        #region IPerson
        public void SetFullName(string fullName)
        {
            throw new NotImplementedException();
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                SetPropertyValue("Email", ref email, value);
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                SetPropertyValue("FirstName", ref firstName, value);
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                SetPropertyValue("LastName", ref lastName, value);
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                SetPropertyValue("MiddleName", ref middleName, value);
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                SetPropertyValue("Birthday", ref birthday, value);
            }
        }
        [NotMapped]
        public string FullName { get { return string.Concat(FirstName, " ", LastName); } }
        #endregion

        #region IInternalUser
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
        public bool IsManager
        {
            get
            {
                return isManager;
            }
            set
            {
                SetPropertyValue("IsManager", ref isManager, value);
            }
        }
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
        public XPCollection<TicketResponse> TicketResponsesByManager
        {
            get
            {
                return GetCollection<TicketResponse>("TicketResponsesByManager");
            }
        }
        [Association("Employee-TicketResponses"), ImmediatePostData]
        public XPCollection<TicketResponse> TicketResponsesByEmployee
        {
            get
            {
                return GetCollection<TicketResponse>("TicketResponsesByEmployee");
            }
        }

        [Association("Position-Internal User")]
        [DisplayName("Position")]
        public Position Position
        {
            get
            {
                return position;
            }
            set
            {
                SetPropertyValue("Position", ref position, value);
            }
        }


        #endregion

    }
}