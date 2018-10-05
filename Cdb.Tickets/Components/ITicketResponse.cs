using Cdb.Tickets.BusinessObjects;
using Cdb.Tickets.SecurityObjects;
using System;
using System.Linq;

namespace Cdb.Tickets.Components
{
    public interface ITicketResponse
    {
        DateTime ResponseDate { get; set; }
        String ProposedSolution { get; set; }
        Ticket Ticket { get; set; }
        InternalUser Manager { get; set; }
        InternalUser Employee { get; set; }
    }
}
