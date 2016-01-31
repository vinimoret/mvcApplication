using Ninject.Modules;
using VM.CursoMvc.Application;
using VM.CursoMvc.Application.Interface;
using VM.CursoMvc.Domain.Interfaces;
using VM.CursoMvc.Domain.Interfaces.Repository;
using VM.CursoMvc.Domain.Interfaces.Services;
using VM.CursoMvc.Domain.Services;
using VM.CursoMvc.Infra.Data.Repository;

namespace VM.CursoMvc.Infra.CrossCuting.IoC
{
    public class NinjectModulo : NinjectModule
    {

        public override void Load()
        {
            //Application
            Bind<IClienteAppService>().To<ClienteAppService>();

            //Domain
            Bind<IClienteService>().To<ClienteService>();

            //Data
            Bind<IClienteRepository>().To<ClienteRepository>();
            //Bind(typeof (IRepository<>)).To(typeof (Repository<>));
        }
    }
}