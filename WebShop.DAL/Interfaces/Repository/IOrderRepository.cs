using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface IOrderRepository
    {
        Order GetOrderById(int id);
        Order AddOrder(Order newOrder);
        Order Delete(int id);
        Product GetProductToOrder(int id);

        int Commit();

    }
}
