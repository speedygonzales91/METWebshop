using System.Collections.Generic;
using METWebShop.Core.Data;

namespace METWebShop.BLL.Interfaces
{
    public interface IProductManager
    {
        List<Product> GetProductsByCategory(ProductCategoryType category);
        public Product GetProductById(int id);
    }
}
