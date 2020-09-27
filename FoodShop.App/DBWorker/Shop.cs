using System;
using System.Collections.Generic;

namespace FoodShop.App
{
    public partial class Shop
    {
        public Shop()
        {
            EmployeeShopInfo = new HashSet<EmployeeShopInfo>();
            ProductInShop = new HashSet<ProductInShop>();
        }

        public int Id { get; set; }
        public string Address { get; set; }

        public virtual ICollection<EmployeeShopInfo> EmployeeShopInfo { get; set; }
        public virtual ICollection<ProductInShop> ProductInShop { get; set; }
    }
}
