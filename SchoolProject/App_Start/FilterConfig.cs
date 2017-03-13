using System.Web;
using System.Web.Mvc;

namespace SchoolProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // start project
            filters.Add(new HandleErrorAttribute());
        }
    }
}