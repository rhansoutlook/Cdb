﻿using Cdb.Tickets.BusinessObjects;
using DevExpress.Persistent.Base.General;
using DevExpress.Xpo;

namespace Cdb.Tickets.Components
{
    public interface IClient 
    {
        string Organization { get; set; }
        XPCollection<Ticket> Tickets { get; }
    }
}
