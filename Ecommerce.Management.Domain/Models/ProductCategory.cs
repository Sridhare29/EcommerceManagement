
namespace Ecommerce.Management.Domain.Models
{
    public partial class ProductCategory
    {
        public Guid Id { get; set; }
        public Guid? ParentCategoryId { get; set; }
        public string Category_Name { get; set; }
        public ProductCategory ParentCategory { get; set; }

    }
}