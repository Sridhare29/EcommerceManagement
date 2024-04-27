namespace Ecommerce.Management.Domain.Models
{
    public partial class Variation
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
    }
}