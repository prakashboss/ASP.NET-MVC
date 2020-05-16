using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDB.Models
{
    public class test
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
    }
}
