﻿using Cdb.Tickets.BusinessObjects;
using DevExpress.Persistent.Base.General;
using DevExpress.Xpo;

namespace Cdb.Tickets.Components
{
    public interface IInternalUser : IPerson
    {
        bool IsFormerEmployee { get; set; }
        Position Position { get; set; }
        XPCollection<Ticket> AssignedToTickets { get;  }
        XPCollection<Ticket> RaisedByTickets { get; }
        XPCollection<Comment> Comments { get; }
        XPCollection<TicketResponse> TicketResponsesByManager { get; }
        XPCollection<TicketResponse> TicketResponsesByEmployee { get;}
    }
}
