﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchers
{
    class AppConstants
    {
        private static string BASE = "https://www.technetic.co.za/php";
        public static string AuthURL = BASE + "/auth.php";
        public static string UsersURL = BASE + "/user.php?mode={0}";
    }
}
