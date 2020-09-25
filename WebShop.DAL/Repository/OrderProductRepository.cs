using System.Linq;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.DAL.Repository
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly DataContext _context;

        public OrderProductRepository(DataContext context)
        {
            _context = context;
        }

        public Product GetProductToOrder(int id)
        {
            return _context.Products.First(x => x.Id == id);
        }

        public OrderProduct AddOrderProduct(OrderProduct newOrderProduct)
        {
            _context.OrderProducts.Add(newOrderProduct);
            return newOrderProduct;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
