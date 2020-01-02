using System;

namespace Interview.Domain.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public double OrderPrice { get; set; }
        public string PaymentType { get; set; }
    }
}