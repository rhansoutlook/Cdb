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
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using Cdb.Tickets.Components;
using Cdb.Tickets.SecurityObjects;
using DevExpress.Persistent.Base.General;
using DisplayNameAttribute = DevExpress.Xpo.DisplayNameAttribute;

namespace Cdb.Tickets.BusinessObjects
{
    [DefaultClassOptions]
    public class Client : BaseObject, IClient
    {
        #region Private Declarations
        private string organization;
        private string email;
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        #endregion

        public Client(Session session)
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
        [DisplayName("Contact Person")]
        public string FullName { get { return string.Concat(FirstName, " ", LastName); } }
        #endregion

        #region IClient
        public string Organization
        {
            get
            {
                return organization;
            }
            set
            {
                SetPropertyValue("Organization", ref organization, value);
            }
        }
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