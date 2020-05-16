using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDB.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; private set; }
        public List<OrderDetail> OrderLines { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string ZipCode { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public decimal OrderTotal { get; private set; }
        public DateTime OrderPlaced { get; private set; }
    }
}
