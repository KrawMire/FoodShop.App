﻿using System;
using System.Collections.Generic;

namespace FoodShop.App
{
    public partial class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
