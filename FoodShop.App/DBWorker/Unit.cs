using System;
using System.Collections.Generic;

namespace FoodShop.App.DBWorker
{
    public partial class Unit
    {
        public Unit()
        {
            ProductInShop = new HashSet<ProductInShop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductInShop> ProductInShop { get; set; }
    }
}
