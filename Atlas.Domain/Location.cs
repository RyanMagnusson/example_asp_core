using System;

namespace Atlas.Domain
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public long Capacity { get; set; }
    }
}
