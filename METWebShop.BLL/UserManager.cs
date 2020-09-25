using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.BLL
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _repository;

        public UserManager(IUserRepository repository)
        {
            _repository = repository;
        }


        public int GetBalanceOfUser(string userId)
        {
           return _repository.GetBalance(userId);
        }

        public void AddBalanceToUser(string userId, int balance)
        {
            var user = _repository.GetUserByUserId(userId);

            if (user == null)
            {
                var newUser = new User {UserId = userId, Balance = balance};
                _repository.AddUser(newUser);
                _repository.Commit();
            }
        }
    }
}
