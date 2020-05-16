using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopDB.Models;
using WebShopDB.ViewModel;

namespace WebShopDB.Controllers
{
    public class ProductController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }
        
        private DatabaseContext _context;


        public ProductController(DatabaseContext context)
        {
            _context = context;
        }
        [Authorize]
        public ViewResult List(string category)
        {
            var _category = category;
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _context.Product.OrderBy(d => d.ProductId);
                currentCategory = "All Products";
            }
            else
            {
                products = _context.Product.Where(d => d.Category.CategoryName.Equals(_category, StringComparison.CurrentCultureIgnoreCase)).OrderBy(d => d.ProductId);

                currentCategory = _category;
            }

            var productListViewModel = new ProductList
            {
                productL = products,
                CurrentCategory = currentCategory
            };

            return View(productListViewModel);
        }
    }
}