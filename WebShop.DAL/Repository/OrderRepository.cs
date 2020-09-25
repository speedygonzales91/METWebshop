using System.Linq;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.DAL.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public Order GetOrderById(int id)
        {
            return _context.Orders.SingleOrDefault(x => x.Id == id);
        }

        public Order AddOrder(Order newOrder)
        {
            _context.Orders.Add(newOrder);
            return newOrder;
        }

        public Order Delete(int id)
        {
            var orderToDelete = GetOrderById(id);
            if (orderToDelete != null)
            {
                _context.Orders.Remove(orderToDelete);
            }
            return orderToDelete;
        }

        public Product GetProductToOrder(int id)
        {
            return _context.Products.First(x => x.Id == id);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
