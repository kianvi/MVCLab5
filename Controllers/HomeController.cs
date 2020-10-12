using MVCLab5.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab5.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "This is ASP.Net MVC Filters Tutorial";
        }
        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

    }
}