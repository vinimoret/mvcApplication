using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Practices.ServiceLocation;
using VM.CursoMvc.Domain.Interfaces.Repository;
using VM.CursoMvc.Infra.Data.Context;
using VM.CursoMvc.Infra.Data.Interfaces;

namespace VM.CursoMvc.Infra.Data.Repository
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        protected CursoMvcContext Db;
        protected DbSet<Tentity> DbSet;

        public Repository()
        {
            var contextManager = ServiceLocator.Current.GetInstance<IContextManager>();
            Db = new CursoMvcContext();
            DbSet = Db.Set<Tentity>();
        }

        public virtual void Adicionar(Tentity obj)
        {
            DbSet.Add(obj);
        }

        public virtual Tentity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<Tentity> ObterTodos()
        {
            return DbSet.ToList(); //.Skip(skipe).Take(take);
        }

        public virtual void Atualizar(Tentity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;;
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
        }

        public IEnumerable<Tentity> Buscar(Expression<Func<Tentity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}