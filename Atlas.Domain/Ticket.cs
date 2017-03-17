using System;

namespace Atlas.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public double AmountPaid { get; set; }
        public double SalesTax { get; set; }
    }
}