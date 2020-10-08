using System;
using System.Collections.Generic;

namespace FoodShop.App.DBWorker
{
    public partial class Shop
    {
        public Shop()
        {
            ProductInShop = new HashSet<ProductInShop>();
        }

        public int Id { get; set; }
        public string Address { get; set; }

        public virtual ICollection<ProductInShop> ProductInShop { get; set; }
    }
}
