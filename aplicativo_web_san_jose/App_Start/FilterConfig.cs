using System.Web;
using System.Web.Mvc;

namespace aplicativo_web_san_jose
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
