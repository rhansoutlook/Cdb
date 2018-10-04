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
using DisplayNameAttribute = DevExpress.Xpo.DisplayNameAttribute;
using Cdb.Tickets.Components;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("GenericTextField")]    
    public class TicketState : BaseObject, ITicketGeneric
    {
        private string genericTextField;
        public TicketState(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()

        {
            base.AfterConstruction();
        }

        [DisplayName("Description")]
        public string GenericTextField
        {
            get
            {
                return genericTextField;
            }
            set
            {
                SetPropertyValue("GenericTextField", ref genericTextField, value);
            }
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