using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Response.Queries.User
{
    public class GetUserResponseModel
    {
        public Guid Id { get; set; }
        public string Email_Address { get; set; }
        public string Phone_Number { get; set; }
        public string Password { get; set; }

    }
}
