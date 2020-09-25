using System.Collections.Generic;
using System.Linq;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace METWebShop.Pages
{
    public class ShoppingCartModel : PageModel
    {
        private readonly IProductManager _productManager;
        public List<Product> Products { get; set; }

        public Dictionary<int,int> ShoppingCart { get; set; }

        public ShoppingCartModel(IProductManager productManager)
        {
            _productManager = productManager;
            Products = new List<Product>();
            ShoppingCart = new Dictionary<int, int>() {{1,10},{2,3}};
        }

        public void OnGet()
        {
            foreach (var product in ShoppingCart.Select(shoppingElement => _productManager.GetProductById(shoppingElement.Key)))
            {
                Products.Add(product);
            }
        }
    }
}
