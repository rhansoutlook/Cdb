using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using Cdb.Tickets.BusinessObjects;

namespace Cdb.Tickets.Components
{
    public interface ITicketType : ITicketGeneric
    {
        XPCollection<Ticket> Tickets { get;  }
    }
}
