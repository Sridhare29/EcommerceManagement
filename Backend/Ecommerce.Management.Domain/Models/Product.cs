namespace Ecommerce.Management.Domain.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public Guid Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Product_Image { get; set; }
        public string Category_Name { get; set; }
        public ProductCategory Category { get; set; }
    }
}