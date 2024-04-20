using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class ProductSku
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public string? Sku { get; set; }

    public decimal? Price { get; set; }

    public Guid? Quantity { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product? Product { get; set; }
}
