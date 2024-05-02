namespace Ecommerce.Management.Domain.Models
{
    public class UserAddress
    {
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public bool IsDefault { get; set; }
        public SiteUser User { get; set; }
        public Address Address { get; set; }

    }
}