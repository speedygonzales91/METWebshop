using System.Collections.Generic;
using METWebShop.Core.Data;
using METWebShop.Core.DTO;

namespace METWebShop.BLL.Interfaces
{
    public interface IOrderManager
    {
        Order PlaceOrder(Dictionary<int, int> shoppingCart, DeliveryDataDTO deliveryData);
    }
}
