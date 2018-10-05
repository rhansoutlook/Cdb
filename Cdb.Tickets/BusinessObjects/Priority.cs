using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
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
    public class Priority : BaseObject, ITicketGeneric
    {
        private string genericTextField;
        public Priority(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region ITicketGeneric
        [DisplayName("Description")]
        public string GenericTextField
        {
            get { return genericTextField; }
            set
            {
                SetPropertyValue("GenericTextField", ref genericTextField, value);
            }

        }

        [Association("Priority-Tickets")]
        public XPCollection<Ticket> Tickets
        {
            get
            {
                return GetCollection<Ticket>("Tickets");
            }
        }
        #endregion    }
    }
}