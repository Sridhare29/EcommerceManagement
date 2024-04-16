using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class ProductAttributeType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; } = new List<ProductAttribute>();
}
