using System.Web;
using System.Web.Mvc;

namespace ProjWebMVC_090821
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
