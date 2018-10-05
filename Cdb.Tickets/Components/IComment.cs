using Cdb.Tickets.BusinessObjects;
using Cdb.Tickets.SecurityObjects;
using System;

namespace Cdb.Tickets.Components
{
    public interface IComment
    {
        string CommentText { get; set; }
        DateTime CommentDate { get; set; }
        Ticket Ticket { get; set; }
        InternalUser InternalUser { get; set; }
    }
}
