using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Landmark { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }

}

