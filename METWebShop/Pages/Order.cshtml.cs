using System.Collections.Generic;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using METWebShop.Core.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace METWebShop.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderManager _manager;

        [BindProperty]
        public DeliveryDataDTO Order { get; set; }

        public Dictionary<int, int> ShoppingCart { get; set; }

        public OrderModel(IOrderManager manager)
        {
            _manager = manager;
            ShoppingCart = new Dictionary<int, int>() { { 1, 10 }, { 2, 3 } };
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Order.UserId = this.User.Identity.Name; 
            _manager.PlaceOrder(ShoppingCart,Order);
        }

    }
}
