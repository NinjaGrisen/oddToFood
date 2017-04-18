using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdeToFood.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Friend> Friends { get; set; }

        /* public virtual List<User> IAmFriendsWith { get; set; }
           public virtual List<User> AreFirendsWithMe { get; set; }

           public void AddFriend(User friend)
           {
               IAmFriendsWith.Add(friend);
               AreFirendsWithMe.Add(friend);
           }
       */

        /*
           public User()
           {
               Friends = new List<Friend>();
           }

           [ForeignKey("RequestedBy_Id")]
           public virtual ICollection<Friend> Friends { get; set; }

        
           public List<Friend> Friends { get; set; }
        */
    }
}
