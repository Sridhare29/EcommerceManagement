using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Management.Domain.Models;

public partial class Payment
{
    [Key]
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public decimal? Amount { get; set; }

    public string? Provider { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
    public virtual Order? Order { get; set; }
}
