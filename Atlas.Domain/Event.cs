using System;
using NodaTime;
using System.Runtime.Serialization;

namespace Atlas.Domain
{
    
    [DataContract]
    public class Event
    {
        [DataMember]
        public Guid Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public ZonedDateTime OnSale { get; set; }
        
        [DataMember]
        public ZonedDateTime DoorsOpen { get; set; }
        
        [DataMember]
        public ZonedDateTime Start { get; set; }
        
        [DataMember]
        public ZonedDateTime End { get; set; }

        public Location Location { get; set; }
    }
}
