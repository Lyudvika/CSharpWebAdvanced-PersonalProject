using Microsoft.AspNetCore.Identity;

namespace ChemJourney.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

        public DateTime MemberSince { get; set; }
    }
}
