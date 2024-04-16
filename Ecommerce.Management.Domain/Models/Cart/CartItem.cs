using Ecommerce.Management.Domain.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models.Cart
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("ProductSku")]
        public int ProductSkuId { get; set; }
        public ProductSku ProductSku { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
