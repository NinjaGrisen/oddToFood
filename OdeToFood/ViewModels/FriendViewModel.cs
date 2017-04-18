using OdeToFood.Entities;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class FriendViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public User User { get; set; }
    }
}
