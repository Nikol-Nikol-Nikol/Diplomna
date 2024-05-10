using Microsoft.AspNetCore.Identity;

namespace SaitZaObuvkiComfort.Data
{
    public class Client : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; }
    }
}
