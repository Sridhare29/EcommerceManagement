namespace Ecommerce.Management.Domain.Models
{
    public partial class VariationOption
    {
        public Guid Id { get; set; }
        public Guid VariationId { get; set; }
        public string Value { get; set; }
        public Variation Variation { get; set; }

    }
}