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
using Cdb.Tickets.Components;
using DisplayNameAttribute = DevExpress.Xpo.DisplayNameAttribute;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("GenericTextField")]
    public class TicketType : BaseObject, ITicketType
    { 
        private string genericTextField;
        public TicketType(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region ITicketType
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

        [Association("TicketType-Tickets")]
        public XPCollection<Ticket> Tickets
        {
            get
            {
                return GetCollection<Ticket>("Tickets");
            }
        }

        #endregion
    }
}