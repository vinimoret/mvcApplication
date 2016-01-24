using System.Web;
using System.Web.Mvc;
using VM.CursoMvc.Infra.CrossCuting.MvcFilters;

namespace VM.CursoMvc.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
