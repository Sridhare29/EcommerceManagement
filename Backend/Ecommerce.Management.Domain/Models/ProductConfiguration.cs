namespace Ecommerce.Management.Domain.Models
{
    public partial class ProductConfiguration
    {
        public Guid ProductItemId { get; set; }
        public Guid VariationOptionId { get; set; }
        public ProductItem ProductItem { get; set; }
        public VariationOption VariationOption { get; set; }

    }
}