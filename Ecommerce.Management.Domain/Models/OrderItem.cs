using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ProductSkuId { get; set; }

    public int? Quantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ProductSku? ProductSku { get; set; }
}
