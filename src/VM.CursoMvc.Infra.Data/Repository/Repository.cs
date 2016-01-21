using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using VM.CursoMvc.Domain.Interfaces.Repository;
using VM.CursoMvc.Infra.Data.Context;

namespace VM.CursoMvc.Infra.Data.Repository
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        protected CursoMvcContext Db;
        protected DbSet<Tentity> DbSet;

        public Repository()
        {
            Db = new CursoMvcContext();
            DbSet = Db.Set<Tentity>();
        }

        public virtual void Adicionar(Tentity obj)
        {
            DbSet.Add(obj);
            SaveChanges();
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
            SaveChanges();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
            SaveChanges();
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