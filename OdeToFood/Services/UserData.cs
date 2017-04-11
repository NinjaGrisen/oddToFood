using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Entities;


namespace OdeToFood.Services
{
    public interface IUserData
    {
        User Get(string userName);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetFriends();
    }
    public class SqlUserData : IUserData
    {

        private OdeToFoodDbContext _context;

        public SqlUserData(OdeToFoodDbContext context)
        {
            _context = context;
        }

        public User Get(string userName)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == userName);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public IEnumerable<User> GetFriends()
        {
            return _context.Users.SelectMany(u => u.Friends);
        }
    }
}
