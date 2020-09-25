using System.Collections.Generic;
using System.Linq;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> GetProducts(ProductCategoryType category)
        {
            return _context.Products.Where(x => x.ProductType == category).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
