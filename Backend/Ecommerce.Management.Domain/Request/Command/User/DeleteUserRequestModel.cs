using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Request.Command.User
{
    public class DeleteUserRequestModel : IRequest<String>
    {
        public Guid Id { get; set; }
    }
}
