using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDB.Data.Interface;
using WebShopDB.Models;

namespace WebShopDB.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _appDbContext;

        public ProductRepository(DatabaseContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> Products => _appDbContext.Product.Include(d => d.Category);

        public IEnumerable<Product> PreferredProduct => _appDbContext.Product.Where(d => d.IsPreferredProduct == true).Include(d => d.Category);

        public IEnumerable<Product> Product => throw new NotImplementedException();

        

        public IEnumerable<Product> PreferredProducts => throw new NotImplementedException();

        public Product GetProductById(int productId) => _appDbContext.Product.FirstOrDefault(d => d.ProductId == productId);

        //public Mobile GetMobileById(int mobileId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
