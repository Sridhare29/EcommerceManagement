using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class Wishlist
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
