using Dapper.Contrib.Extensions;

namespace Ecommerce.Management.Domain.Models
{
    public partial class Address
    {
        public Guid Id { get; set; }
        public string UnitNumber { get; set; }
        public string StreetNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public Guid CountryId { get; set; }

        [Write(false)]
        public Country Country { get; set; }
    }
}