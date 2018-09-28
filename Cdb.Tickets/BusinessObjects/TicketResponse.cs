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
    public class TicketResponse : BaseObject
    {
        private string proposedSolution;
        private DateTime responseDate;
        private InternalUser managerId;
        private Ticket ticketId;

        public TicketResponse(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();            
        }
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


        #region Foreign Keys
        [Association("Ticket-TicketResponses"), ImmediatePostData]
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
        [Association("Manager-TicketResponses"), ImmediatePostData]
        public InternalUser ManagerId
        {
            get
            {
                return managerId;
            }
            set
            {
                SetPropertyValue("ManagerId", ref managerId, value);
            }
        }

        #endregion
    }
}