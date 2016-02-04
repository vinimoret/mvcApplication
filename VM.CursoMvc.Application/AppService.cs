using Microsoft.Practices.ServiceLocation;
using VM.CursoMvc.Infra.Data.Interfaces;

namespace VM.CursoMvc.Application
{
    public class AppService
    {
        private IUnityOfWork _uow;
        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnityOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }
    }
}