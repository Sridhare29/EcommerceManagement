namespace Ecommerce.Management.Domain.Models
{
    public partial class ProductItem
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string SKU { get; set; }
        public Guid QtyInStock { get; set; }
        public string ProductImage { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
    }
}