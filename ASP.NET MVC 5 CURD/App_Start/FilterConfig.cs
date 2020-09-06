using ASP.NET_MVC_5_CURD.Infrastructure;

namespace ASP.NET_MVC_5_CURD.App_Start
{
    public class FilterConfig
    {
        public static void Configure(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
