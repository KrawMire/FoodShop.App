using System;
using System.Collections.Generic;

namespace FoodShop.App
{
    public partial class EmployeeShopInfo
    {
        public int EmployeeId { get; set; }
        public int ShopId { get; set; }

        public virtual EmployeeMainInfo Employee { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
