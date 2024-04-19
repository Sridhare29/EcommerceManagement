using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.User
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Password { get; set; }

        public DateOnly? BirthOfDate { get; set; }

        public string? MobileNumber { get; set; }
    }
}
