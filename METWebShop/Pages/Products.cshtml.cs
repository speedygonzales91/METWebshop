using System.Collections.Generic;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace METWebShop.Pages
{
    public class ProductModel : PageModel
    {
        private readonly IProductManager _productManager;

        public List<Product> ProductList { get; set; }

        public ProductModel(IProductManager productManager)
        {
            _productManager = productManager;
            ProductList = new List<Product>();
        }
        public void OnGet(int productCatType)
        {
            var category = productCatType switch
            {
                1 => ProductCategoryType.WarmUpPack,
                2 => ProductCategoryType.SportPack,
                3 => ProductCategoryType.SpartaPack,
                _ => ProductCategoryType.WarmUpPack,
            };
            ProductList = _productManager.GetProductsByCategory(category);
        }
    }
}
