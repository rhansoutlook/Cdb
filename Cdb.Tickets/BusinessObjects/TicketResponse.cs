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
using Cdb.Tickets.SecurityObjects;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    public class TicketResponse : BaseObject
    {
        #region Private declarations
        private string proposedSolution;
        private DateTime responseDate;
        private InternalUser manager;
        private InternalUser employee;
        private Ticket ticket; 
        #endregion
        public TicketResponse(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();            
        }

        #region Columns
        public DateTime ResponseDate
        {
            get
            {
                return responseDate;
            }
            set
            {
                SetPropertyValue("ResponseDate", ref responseDate, value);
            }
        }
        [Size(4096)]
        public string ProposedSolution
        {
            get
            {
                return proposedSolution;
            }
            set
            {
                SetPropertyValue("ProposedSolution", ref proposedSolution, value);
            }
        }
        #endregion

        #region Foreign Keys
        [Association("Ticket-TicketResponses"), ImmediatePostData]
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
        [Association("Manager-TicketResponses"), ImmediatePostData]
        public InternalUser Manager
        {
            get
            {
                return manager;
            }
            set
            {
                SetPropertyValue("Manager", ref manager, value);
            }
        }    
        [Association("Employee-TicketResponses"), ImmediatePostData]
        public InternalUser Employee
        {
            get
            {
                return employee;
            }
            set
            {
                SetPropertyValue("Employee", ref employee, value);
            }
        }
        #endregion
    }
}