using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class SubCategory
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
