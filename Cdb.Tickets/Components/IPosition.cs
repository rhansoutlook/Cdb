using Cdb.Tickets.SecurityObjects;
using DevExpress.Xpo;

namespace Cdb.Tickets.Components
{
    public interface IPosition 
    {
        string Description { get; set; }
        XPCollection<InternalUser> InternalUsers { get; }


    }
}
