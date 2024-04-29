namespace Ecommerce.Management.Domain.Models
{
    public partial class ShippingMethod
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Price { get; set; }

    }
}