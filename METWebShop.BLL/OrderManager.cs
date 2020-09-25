using System.Collections.Generic;
using METWebShop.BLL.Interfaces;
using METWebShop.Core.Data;
using METWebShop.Core.DTO;
using METWebShop.DAL.Interfaces.Repository;

namespace METWebShop.BLL
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderProductRepository _orderProductRepository;

        public OrderManager(IOrderRepository orderRepository, IOrderProductRepository orderProductRepository)
        {
            _orderRepository = orderRepository;
            _orderProductRepository = orderProductRepository;
        }

        public Order PlaceOrder(Dictionary<int, int> shoppingCart, DeliveryDataDTO deliveryData)
        {
            var order = new Order
            {
                ZipCode = deliveryData.ZipCode,
                City = deliveryData.City,
                Address = deliveryData.Address,
                PhoneNumber = deliveryData.PhoneNumber,
                InfoToDelivery = deliveryData.InfoToDelivery,
                UserId = deliveryData.UserId
            };

            _orderRepository.AddOrder(order);

            foreach (var shoppingCartElement in shoppingCart)
            {
                var orderProduct = new OrderProduct
                {
                    ProductId = shoppingCartElement.Key,
                    Amount = shoppingCartElement.Value,
                    Order = order
                };

                _orderProductRepository.AddOrderProduct(orderProduct);
            }

            _orderRepository.Commit();
            _orderProductRepository.Commit();

            return order;
        }
    }
}
