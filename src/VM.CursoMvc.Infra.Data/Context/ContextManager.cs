using VM.CursoMvc.Infra.Data.Interfaces;
using  System.Web;
namespace VM.CursoMvc.Infra.Data.Context
{
    public class ContextManager : IContextManager
    {
        //One COntext Per Request
        private const string ContextKey = "ContextManager.Context";
        public CursoMvcContext GetContext()
        {
            if (HttpContext.Current.Items[ContextKey] == null)
            {
                 HttpContext.Current.Items[ContextKey] = new CursoMvcContext();
            }

            return (CursoMvcContext) HttpContext.Current.Items[ContextKey];
        }
    }
}