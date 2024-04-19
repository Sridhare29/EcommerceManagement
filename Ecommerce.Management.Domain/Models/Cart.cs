using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class Cart
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual User? User { get; set; }
}
