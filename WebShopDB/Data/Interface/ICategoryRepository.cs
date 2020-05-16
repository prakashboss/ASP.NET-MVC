using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDB.Models;

namespace WebShopDB.Data.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }

}
