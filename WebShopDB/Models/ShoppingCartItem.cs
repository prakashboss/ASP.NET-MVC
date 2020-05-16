using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDB.Models
{
    public class ShoppingCartItem
    {
        public ShoppingCartItem() { }

        public ShoppingCartItem(Product product, int amout, string shoppingCartId)
        {
            Product = product;
            Amount = amout;
            ShoppingCartId = shoppingCartId;
        }

        public int ShoppingCartItemId { get; private set; }
        public Product Product { get; private set; }
        public int Amount { get; private set; }
        public string ShoppingCartId { get; private set; }

        public void AddAmount() => Amount++;

        public int RemoveAmount() => Amount--;
    }
}
