using System.Web;
using System.Web.Mvc;

namespace CIS467_AMP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthorizeAttribute()); // Do not allow anonymous users Anywhere (use tag to allow)
        }
    }
}
