using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace OdeToFood.Entities
{
    public class User : IdentityUser
    {
        public IEnumerable<User> Friends { get; set; }
    }
}
