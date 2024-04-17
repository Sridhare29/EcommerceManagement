using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public class Category
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string Description { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
