using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models.Product
{
    public class Products
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Summary { get; set; }

        public string Cover { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
