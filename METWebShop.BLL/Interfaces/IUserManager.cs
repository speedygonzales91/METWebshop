namespace METWebShop.BLL.Interfaces
{
    public interface IUserManager
    {
        int GetBalanceOfUser(string userId);
        void AddBalanceToUser(string userId, int balance);
    }
}
