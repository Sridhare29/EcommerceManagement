using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class OrderItem
{
    public Guid Id { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? ProductSkuId { get; set; }

    public Guid? Quantity { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
    public virtual Order? Order { get; set; }

    public virtual ProductSku? ProductSku { get; set; }
}
