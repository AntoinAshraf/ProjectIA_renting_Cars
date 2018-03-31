using System.Web;
using System.Web.Mvc;

namespace ProjectIA_renting_Cars
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
