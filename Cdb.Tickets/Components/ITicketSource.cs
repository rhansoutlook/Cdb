﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdb.Tickets.Components
{
    interface ITicketSource
    {
        XPCollection<Ticket> Tickets { get; }
    }
}
