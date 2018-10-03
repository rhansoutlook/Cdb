﻿using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    public class Ticket : BaseObject, IObjectSpaceLink
    {        
        #region Private declarations
        private int ticketNumber; 
        private DateTime creationDate;
        private DateTime errorOccurDate;
        private DateTime errorIdentifiedDate;
        private string ticketDescription;
        private string followUp;

        private TicketSource ticketSource;
        private TicketState ticketState;
        private TicketType ticketType;
        private Priority priority;
        private InternalUser raisedBy;
        private InternalUser assignedTo;
        private Client client;

        #endregion
        public Ticket(Session session)
            : base(session)
        {
            
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            CreationDate = DateTime.Now;
            
            // This code is not working. Need to discuss
            //Priority priority = ObjectSpace.FindObject<Priority>(new BinaryOperator("Description", "Normal"));
            //if (priority != null)
            //    Priority = priority;

            Priority priority = Session.FindObject<Priority>(new BinaryOperator("Description", "Medium") 
                || new BinaryOperator("Description", "Normal"));
            if (priority != null)
                Priority = priority;

        }

        #region Columns
        public int TicketNumber
        {
            get
            {
                return ticketNumber;
            }
            set
            {
                SetPropertyValue("TicketNumber", ref ticketNumber, value);
            }
        }
        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }
            set
            {
                SetPropertyValue("CreationDate", ref creationDate, value);
            }
        }
        public DateTime ErrorOccurDate
        {
            get
            {
                return errorOccurDate;
            }
            set
            {
                SetPropertyValue("ErrorOccurDate", ref errorOccurDate, value);
            }
        }
        public DateTime ErrorIdentifiedDate
        {
            get
            {
                return errorIdentifiedDate;
            }
            set
            {
                SetPropertyValue("errorIdentifiedDate", ref errorIdentifiedDate, value);
            }
        }
        public string TicketDescription
        {
            get
            {
                return ticketDescription;
            }
            set
            {
                SetPropertyValue("TicketDescription", ref ticketDescription, value);
            }
        }
        public string FollowUp
        {
            get
            {
                return followUp;
            }
            set
            {
                SetPropertyValue("FollowUp", ref followUp, value);
            }
        }
        #endregion    

        #region Foreign Keys
        [Association("Priority-Tickets"), ImmediatePostData]
        [DisplayName("Priority")]
        public Priority Priority
        {
            get
            {
                return priority;
            }
            set
            {
                SetPropertyValue("TicketPriority", ref priority, value);
            }
        }


        [Association("TicketSource-Tickets"), ImmediatePostData]
        [DisplayName("Source")]
        public TicketSource TicketSource
        {
            get
            {
                return ticketSource;
            }
            set
            {
                SetPropertyValue("TicketSourceId", ref ticketSource, value);
            }
        }

        [Association("TicketState-Tickets") , ImmediatePostData]
        [DisplayName("State")]
        public TicketState TicketState
        {
            get
            {
                return ticketState;
            }
            set
            {
                SetPropertyValue("TicketState", ref ticketState, value);
            }
        }

        [Association("TicketType-Tickets"), ImmediatePostData]
        [DisplayName("Type")]
        public TicketType TicketType
        {
            get
            {
                return ticketType;
            }
            set
            {
                SetPropertyValue("TicketType", ref ticketType, value);
            }
        }

        [Association("InternalUser-TicketsRaisedBy"),ImmediatePostData]
        public InternalUser RaisedBy
        {
            get
            {
                return raisedBy;
            }
            set
            {
                SetPropertyValue("RaisedBy", ref raisedBy, value);
            }
        }

        [Association("InternalUser-TicketsAssignedTo"), ImmediatePostData]
        public InternalUser AssignedTo
        {
            get
            {
                return assignedTo;
            }
            set
            {
                SetPropertyValue("AssignedTo", ref assignedTo, value);
            }
        }

        [Association("Client-Tickets"), ImmediatePostData]
        [DisplayName("Client")]
        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                SetPropertyValue("ClientId", ref client, value);
            }
        }
        #endregion

        #region OneToMany
        [Association("Ticket-Comments"), Aggregated]
        public XPCollection<Comment> Comments
        {
            get
            {
                return GetCollection<Comment>("Comments");
            }
        }
        [Association("Ticket-TicketResponses"), Aggregated]
        public XPCollection<TicketResponse> TicketResponses
        {
            get
            {
                return GetCollection<TicketResponse>("TicketResponses");
            }
        }

        #endregion

        public IObjectSpace ObjectSpace { get; set; }

    }
}