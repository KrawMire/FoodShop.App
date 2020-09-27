using System;
using System.Collections.Generic;

namespace FoodShop.App
{
    public partial class EmployeeMainInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual EmployeeShopInfo EmployeeShopInfo { get; set; }
        public virtual EmployeeWorkInfo EmployeeWorkInfo { get; set; }
    }
}
