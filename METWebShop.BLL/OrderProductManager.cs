using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.BLL
{
    public class OrderProductManager : IOrderProductManager
    {
        private readonly IOrderProductRepository _repository;

        public OrderProductManager(IOrderProductRepository repository)
        {
            _repository = repository;
        }

        public Product GetProductToOrder(int id)
        {
            return _repository.GetProductToOrder(id);
        }

        public void OrderProductWithAmount(int productId, Order order, int amount)
        {
            var OrderProduct = new OrderProduct();
            var product = GetProductToOrder(productId);

            OrderProduct.Order = order;
            OrderProduct.Product = product;
            OrderProduct.Amount = amount;
            

            _repository.AddOrderProduct(OrderProduct);

            _repository.Commit();
        }
    }
}
