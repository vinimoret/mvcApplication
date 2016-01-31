using Ninject;

namespace VM.CursoMvc.Infra.CrossCuting.IoC
{
    public class Container
    {
        public StandardKernel GetModule()
        {
            return new StandardKernel(new NinjectModulo());
        }
    }
}