using System;
using System.Collections.Generic;

namespace workshop5.Models
{
    public partial class Bookings
    {
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string BookingNo { get; set; }
        public double? TravelerCount { get; set; }
        public int? CustomerId { get; set; }
        public string TripTypeId { get; set; }
        public int? PackageId { get; set; }
    }
}
