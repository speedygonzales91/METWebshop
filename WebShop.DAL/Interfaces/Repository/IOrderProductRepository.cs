using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface IOrderProductRepository
    {
        Product GetProductToOrder(int id);

        OrderProduct AddOrderProduct(OrderProduct newOrderProduct);

        int Commit();
    }
}
