namespace Ecommerce.Management.Domain.Models
{
    public partial class UserReview
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid OrderedProductId { get; set; }
        public Guid RatingValue { get; set; }
        public string Comment { get; set; }
        public SiteUser User { get; set; }
        public OrderLine OrderedProduct { get; set; }

    }
}