using System;
using System.Collections.Generic;

namespace FoodShop.App.DBWorker
{
    public partial class EmployeeMainInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
