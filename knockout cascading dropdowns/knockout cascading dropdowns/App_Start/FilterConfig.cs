﻿using System.Web;
using System.Web.Mvc;

namespace knockout_cascading_dropdowns
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
