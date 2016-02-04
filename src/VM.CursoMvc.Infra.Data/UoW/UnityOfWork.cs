using System;
using Microsoft.Practices.ServiceLocation;
using VM.CursoMvc.Infra.Data.Context;
using VM.CursoMvc.Infra.Data.Interfaces;

namespace VM.CursoMvc.Infra.Data.UoW
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly CursoMvcContext _dbContext;
        private bool _disposed;

        public UnityOfWork()
        {
            //var contextManager = new ContextManager().GetContext();
            var contexManager = ServiceLocator.Current.GetInstance<IContextManager>();
            _dbContext = contexManager.GetContext();
        }

        public void BeginTransaction()
        {
            _disposed = false;

        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}