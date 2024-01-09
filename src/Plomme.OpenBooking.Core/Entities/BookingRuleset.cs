using Plomme.OpenBooking.Core.Common;

namespace Plomme.OpenBooking.Core.Entities;

public class BookingRuleset : BaseAuditableEntity
{
    public int MaxConcurrentBookings { get; set; } = 1;
    public int? MaxBookingLengthSeconds { get; set; }
    public int? MinBookingLengthSeconds { get; set; }

}
