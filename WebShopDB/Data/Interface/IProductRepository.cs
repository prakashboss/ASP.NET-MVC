using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDB.Models;

namespace WebShopDB.Data.Interface
{
   public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> PreferredProducts { get; }
        Product GetProductById(int ProductId);
    }
}
