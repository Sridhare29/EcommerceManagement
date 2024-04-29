using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models.Product
{
    public class ProductSku
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("SizeAttribute")]
        public int SizeAttributeId { get; set; }
        public ProductAttribute SizeAttribute { get; set; }

        [ForeignKey("ColorAttribute")]
        public int ColorAttributeId { get; set; }
        public ProductAttribute ColorAttribute { get; set; }

        public string Sku { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }

}
