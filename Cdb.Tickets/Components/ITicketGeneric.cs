﻿using Cdb.Tickets.BusinessObjects;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cdb.Tickets.Components
{
    public interface ITicketGeneric 
    {
        string GenericTextField { get; set; }
        XPCollection<Ticket> Tickets { get; }
    }
}
