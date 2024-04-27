using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Domain.Models
{
    public partial class Country
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
    }
}
