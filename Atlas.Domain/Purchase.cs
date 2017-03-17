using System;
using System.Collections.Generic;

namespace Atlas.Domain
{
    public class TicketOrder 
    {
        public Guid Id { get; set; }
        public Event Event { get; set; }
        public int Quantity { get; set; }
    }

    public class Purchase
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CreditCard CreditCard { get; set; }
        public Event Event { get; set; }
        
        //private IList<TicketOrder>_tickets;
        public IList<TicketOrder> Tickets { get; set; } 
        
    }
}