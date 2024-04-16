using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Features.User.GetAllUser.Queries
{
    public class UserDto
    {
        public string Email { get; set; } = null!;

        public string? PasswordHash { get; set; }

        public DateOnly? BirthOfDate { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
