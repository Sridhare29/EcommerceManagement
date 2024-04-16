using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Summary { get; set; }

    public string? CoverUrl { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<ProductSku> ProductSkus { get; set; } = new List<ProductSku>();

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
