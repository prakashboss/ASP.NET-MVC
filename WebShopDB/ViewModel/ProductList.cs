using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDB.Models;

namespace WebShopDB.ViewModel
{
    public class ProductList
    {
        public IEnumerable<Product> productL { get; set; }
        public string CurrentCategory { get; set; }
    }
}
