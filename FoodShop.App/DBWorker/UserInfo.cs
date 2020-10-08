using System;
using System.Collections.Generic;

namespace FoodShop.App.DBWorker
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual User User { get; set; }
    }
}
