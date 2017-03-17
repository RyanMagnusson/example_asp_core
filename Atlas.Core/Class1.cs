using System;
using NodaTime.Date;

namespace Atlas.Core
{
    public class Event
    {
        public guid Id { get; set; }
        public string Name { get; set; }
        public ZonedDateTime OnSale { get; set; }
        public ZonedDateTime DoorsOpen { get; set; }
        public ZonedDateTime Start { get; set; }
        public ZonedDateTime End { get; set; }
        public Location Location { get; set; }
    }
}
