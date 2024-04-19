﻿using System;
using System.Collections.Generic;

namespace Ecommerce.Management.Domain.Models;

public partial class Wishlist
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ProductId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Product? Product { get; set; }

    public virtual User? User { get; set; }
}
