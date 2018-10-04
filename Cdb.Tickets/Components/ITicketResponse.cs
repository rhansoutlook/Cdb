using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cdb.Tickets.BusinessObjects;
using Cdb.Tickets.SecurityObjects;

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
