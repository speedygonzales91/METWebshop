using System.Collections.Generic;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.BLL
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetProductsByCategory(ProductCategoryType category)
        {
            return _productRepository.GetProducts(category);
        }
        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }
    }
}
