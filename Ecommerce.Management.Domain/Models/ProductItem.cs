namespace Ecommerce.Management.Domain.Models
{
    public partial class ProductItem
    {
        public Guid Id { get; set; }
        public Guid Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Product_Image { get; set; }
        public Guid Category_Id { get; set; }
        public string Category_Name { get; set; }
        public int Price { get; set; }
        public int Qty_In_Stock { get; set; }
        public Product Product { get; set; }
    }
}