using System.Web;
using System.Web.Mvc;

namespace Vobacom.HappyWheels.MVCClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
