using OdeToFood.Entities;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Resturant> Resturants { get; set; }

        public IEnumerable<User> Users { get; set; }

        public IEnumerable<User> Friends { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
