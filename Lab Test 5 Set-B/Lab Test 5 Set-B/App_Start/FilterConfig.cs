﻿using System.Web;
using System.Web.Mvc;

namespace Lab_Test_5_Set_B
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}