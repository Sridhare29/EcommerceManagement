namespace Ecommerce.Management.Domain.Models
{
    public partial class ShopOrder
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid ShippingAddress { get; set; }
        public Guid ShippingMethod { get; set; }
        public Guid OrderTotal { get; set; }
        public Guid OrderStatus { get; set; }
        public SiteUser User { get; set; }
        public UserPaymentMethod PaymentMethod { get; set; }
        public Address ShippingAddressNavigation { get; set; }
        public ShippingMethod ShippingMethodNavigation { get; set; }
        public OrderStatus OrderStatusNavigation { get; set; }

    }
}