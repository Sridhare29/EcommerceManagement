using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class ProductAttribute
{
    public int Id { get; set; }

    public int? TypeId { get; set; }

    public string? Value { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();

    public virtual ProductAttributeType? Type { get; set; }
}
