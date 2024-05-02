namespace Ecommerce.Management.Domain.Models
{
    public partial class ShoppingCartItem
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductItemId { get; set; }
        public Guid Qty { get; set; }
        public ShoppingCart Cart { get; set; }
        public ProductItem ProductItem { get; set; }

    }
}