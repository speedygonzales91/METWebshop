using System.Collections.Generic;

namespace METWebShop.Core.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string InfoToDelivery { get; set; }

        public User User { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
