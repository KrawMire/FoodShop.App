using System;
using System.Collections.Generic;

namespace FoodShop.App
{
    public partial class EmployeeWorkInfo
    {
        public int EmployeeId { get; set; }
        public string Position { get; set; }
        public DateTime WorkDateFrom { get; set; }
        public DateTime? WorkDateTo { get; set; }

        public virtual EmployeeMainInfo Employee { get; set; }
    }
}
