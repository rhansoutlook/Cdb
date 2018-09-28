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
    public class Notification : BaseObject
    {
        private string notificationText;
        private string notificationEmail;
        private DateTime notificationDate;

        public Notification(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        public string NotificationText
        {
            get
            {
                return notificationText;
            }
            set
            {
                SetPropertyValue("NotificationText", ref notificationText, value);
            }
        }
        public String NotificationEmail
        {
            get
            {
                return notificationEmail;
            }
            set
            {
                SetPropertyValue("NotificationEmail", ref notificationEmail, value);
            }
        }
        public DateTime NotificationDate
        {
            get
            {
                return notificationDate;
            }
            set
            {
                SetPropertyValue("NotificationDate", ref notificationDate, value);
            }
        }


    }
}