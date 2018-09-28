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

namespace Cdb.Notifications.BusinessObjects
{
    [DefaultClassOptions]
    public class EventType : BaseObject
    {
        private string eventDescription;
        private Int16 eventId;

        public EventType(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        public Int16 EventId
        {
            get
            {
                return eventId;
            }
            set
            {
                SetPropertyValue("EventId", ref eventId, value);
            }
        }
        public String EventDescription
        {
            get
            {
                return eventDescription;
            }
            set
            {
                SetPropertyValue("EventDescription", ref eventDescription, value);
            }
        }

        #region OneToMany
        [Association("EventType-Notifications")]
        public XPCollection<Notification> Notifications
        {
            get
            {
                return GetCollection<Notification>("Notifications");
            }
        }
        #endregion

    }
}