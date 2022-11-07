using System.Web;
using System.Web.Mvc;

namespace EM_WebApplication_RUAP_LV2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
