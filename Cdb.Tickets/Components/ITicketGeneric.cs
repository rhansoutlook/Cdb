using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using Cdb.Tickets.BusinessObjects;

namespace Cdb.Tickets.Components
{
    public interface ITicketGeneric 
    {
        string GenericTextField { get; set; }
        XPCollection<Ticket> Tickets { get; }
    }
}
