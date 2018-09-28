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
    public class Client : Person
    {
        private string organizationName;
        public Client(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();            
        }

        public string OrganizationName
        {
            get
            {
                return organizationName;
            }
            set
            {
                SetPropertyValue("OrganizationName", ref organizationName, value);
            }
        }

        #region OneToMany
        [Association("Client-Tickets")]
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