using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace OdeToFood.Entities
{
    public class Friend : IdentityUser
    {
        //public int Id1 { get; set; }
        //public int Id2 { get; set; }
        public User FriendUser { get; set; }
        public List<Match> Matches { get; set; }
    }
}
