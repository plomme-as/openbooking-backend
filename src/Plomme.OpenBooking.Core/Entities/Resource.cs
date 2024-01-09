using Plomme.OpenBooking.Core.Common;

namespace Plomme.OpenBooking.Core.Entities;

public class Resource : BaseAuditableEntity
{
    public string? Title { get; set; }
    public IList<Booking> Bookings { get; set; } = new List<Booking>();
    public BookingRuleset Ruleset { get; set; } = new BookingRuleset();


}
