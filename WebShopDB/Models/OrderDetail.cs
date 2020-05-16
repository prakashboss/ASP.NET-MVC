using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDB.Models
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailId { get; private set; }
        public Guid OrderId { get; private set; }
        public int ProductId { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }
        public virtual Product Products { get; set; }
        public virtual Order Order { get; set; }
    }
}
