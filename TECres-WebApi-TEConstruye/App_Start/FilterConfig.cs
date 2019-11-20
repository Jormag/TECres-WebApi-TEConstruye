using System.Web;
using System.Web.Mvc;

namespace TECres_WebApi_TEConstruye
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
