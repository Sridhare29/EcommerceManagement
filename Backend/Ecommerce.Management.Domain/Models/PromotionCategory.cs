namespace Ecommerce.Management.Domain.Models
{
    public partial class PromotionCategory
    {
        public Guid CategoryId { get; set; }
        public Guid PromotionId { get; set; }
        public ProductCategory Category { get; set; }
        public Promotion Promotion { get; set; }
    }
}