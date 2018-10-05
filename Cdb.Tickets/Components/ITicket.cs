using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cdb.Tickets.BusinessObjects;
using Cdb.Tickets.SecurityObjects;
using DevExpress.Xpo;

namespace Cdb.Tickets.Components
{
    public interface ITicket
    {
        int TicketNumber { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ErrorOccurDate { get; set; }
        DateTime ErrorIdentifiedDate { get; set; }
        String TicketDescription { get; set; }
        String FollowUp { get; set; }
        Priority Priority { get; set; }
        TicketSource TicketSource { get; set; }
        TicketType TicketType { get; set; }
        TicketState TicketState { get; set; }
        InternalUser RaisedBy { get; set; }
        InternalUser AssignedTo { get; set; }
        Client Client { get; set; }
        XPCollection<Comment> Comments { get; }
        XPCollection<TicketResponse> TicketResponses { get; }

    }
}
