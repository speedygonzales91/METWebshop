using System.Collections.Generic;
using METWebShop.Core.Data;

namespace METWebShop.DAL.Interfaces.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts(ProductCategoryType category);
        Product GetProductById(int id);
    }
}
