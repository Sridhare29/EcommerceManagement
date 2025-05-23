﻿namespace Ecommerce.Management.Domain.Models
{
    public partial class UserPaymentMethod
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PaymentTypeId { get; set; }
        public string Provider { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsDefault { get; set; }
        public SiteUser User { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}