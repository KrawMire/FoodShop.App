using System;
using System.Collections.Generic;

namespace FoodShop.App
{
    public partial class Product
    {
        public Product()
        {
            ProductInShop = new HashSet<ProductInShop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductInShop> ProductInShop { get; set; }
    }
}
