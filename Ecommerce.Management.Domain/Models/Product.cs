namespace Ecommerce.Management.Domain.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public ProductCategory Category { get; set; }
    }
}