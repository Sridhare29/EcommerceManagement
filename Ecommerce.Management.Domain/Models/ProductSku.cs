using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class ProductSku
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? AttributeId { get; set; }

    public string? Sku { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ProductAttribute? Attribute { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product? Product { get; set; }
}
