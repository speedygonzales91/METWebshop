using System;
using System.Collections.Generic;
using System.Text;

namespace METWebShop.Core.DTO
{
    public class DeliveryDataDTO
    {
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string InfoToDelivery { get; set; }
        public string UserId { get; set; }
    }
}
