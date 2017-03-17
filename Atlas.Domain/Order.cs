using System;
using NodaTime;
using System.Collections.Generic;

namespace Atlas.Domain {

    public class Order {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ZonedDateTime PurchaseDate { get; set; }
        public Double AmountPaid { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }

}