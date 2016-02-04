using VM.CursoMvc.Infra.Data.Context;

namespace VM.CursoMvc.Infra.Data.Interfaces
{
    public interface IContextManager
    {
        CursoMvcContext GetContext();
    }
}