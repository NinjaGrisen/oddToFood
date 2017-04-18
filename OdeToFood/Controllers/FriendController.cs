using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using OdeToFood.Entities;
using Microsoft.AspNetCore.Identity;

namespace OdeToFood.Controllers
{
    public class FriendController : Controller
    {
        private IUserData _userData;
        private UserManager<User> _userManager;

        public FriendController(
            IUserData userData,
            UserManager<User> userManager)
        {
            _userManager = userManager;
            _userData = userData;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            User model = _userData.Get("Alva");

            var user = new User
            {
                UserName = "Created",
                Email = "created@mail.se",
                PasswordHash = "HashatPassword!1",
                Friends = new List<Friend> { }
                
            };
            

            return View(model);
        }

    }
}
