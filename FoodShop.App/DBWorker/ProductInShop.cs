using System;
using System.Collections.Generic;

namespace FoodShop.App.DBWorker
{
    public partial class ProductInShop
    {
        public int ProductId { get; set; }
        public int ShopId { get; set; }
        public int Amount { get; set; }
        public int UnitId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
