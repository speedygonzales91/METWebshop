using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface IUserRepository
    {
        User GetUserByUserId(string userId);
        int GetBalance(string userId);
        User AddUser(User user);

        public int Commit();
    }
}
