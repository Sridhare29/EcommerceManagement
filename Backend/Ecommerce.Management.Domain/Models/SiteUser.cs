namespace Ecommerce.Management.Domain.Models
{
    public partial class SiteUser
    {
        public Guid Id { get; set; }
        public string Email_Address { get; set; }
        public string Phone_Number { get; set; }
        public string Password { get; set; }

    }
}