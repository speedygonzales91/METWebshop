using System.Linq;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public User GetUserByUserId(string userId)
        {
            return _context.Users.SingleOrDefault(x => x.UserId == userId);
        }

        public int GetBalance(string userId)
        {
            var user = GetUserByUserId(userId);
            if (user != null)
            {
                return user.Balance;
            }

            return 0;
        }

        public User AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            return newUser;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
