namespace Ecommerce.Management.Domain.Models
{
    public partial class ProductItem
    {
        public Guid Id { get; set; }
        public Guid Product_Id { get; set; }
        public int Qty_In_Stock { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
    }
}