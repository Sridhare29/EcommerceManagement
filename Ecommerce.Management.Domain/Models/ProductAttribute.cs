using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class ProductAttribute
{
    public Guid Id { get; set; }

    public Guid? TypeId { get; set; }

    public string? Value { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();

    public virtual ProductAttributeType? Type { get; set; }
}
