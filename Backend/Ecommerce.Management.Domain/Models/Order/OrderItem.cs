using Ecommerce.Management.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models.Order
{
    public class OrderItem
    {
        public int Id { get; set; }

        [ForeignKey("OrderDetails")]
        public int OrderId { get; set; }
        public OrderDetails OrderDetails { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Products Product { get; set; }

        [ForeignKey("ProductSku")]
        public int ProductSkuId { get; set; }
        public ProductSku ProductSku { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
