using Plomme.OpenBooking.Core.Common;

namespace Plomme.OpenBooking.Core.Entities;

public class Booking : BaseAuditableEntity
{
    public DateTimeOffset FromUtc { get; set; }
    public DateTimeOffset ToUtc { get; set; }
    public string? Note { get; set; }

}
