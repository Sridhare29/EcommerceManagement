using Ecommerce.Management.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Features.User.GetAllUser.Queries.GetAllUser
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Password { get; set; }

        public DateOnly? BirthOfDate { get; set; }

        public string? MobileNumber { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

    }
}
