using Ecommerce.Management.Domain.Models.Cart;
using Ecommerce.Management.Domain.Models.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime? BirthOfDate { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
        public ICollection<Carts> Carts { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

    }
}
