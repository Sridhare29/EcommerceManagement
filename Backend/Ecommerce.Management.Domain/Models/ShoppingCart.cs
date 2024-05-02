namespace Ecommerce.Management.Domain.Models
{
    public partial class ShoppingCart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public SiteUser User { get; set; }

    }
}