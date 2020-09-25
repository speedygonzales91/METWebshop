using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace METWebShop.Core.Data
{
    public class Product
    {
        public int Id  { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }
        public ProductCategoryType ProductType { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
