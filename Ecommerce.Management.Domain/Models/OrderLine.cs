namespace Ecommerce.Management.Domain.Models
{
    public partial class OrderLine
    {
        public Guid Id { get; set; }
        public Guid ProductItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid Qty { get; set; }
        public Guid Price { get; set; }
        public ProductItem ProductItem { get; set; }
        public ShopOrder Order { get; set; }

    }
}