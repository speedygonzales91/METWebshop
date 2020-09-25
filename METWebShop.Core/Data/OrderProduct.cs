using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace METWebShop.Core.Data
{
    public class OrderProduct
    {
        [Key, Column(Order = 0)]
        [Required]
        public int OrderId { get; set; }
        [Key,Column(Order = 1)]
        [Required]
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
