using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace VM.CursoMvc.Domain.Interfaces.Repository
{
    public interface IRepository<TEentity> : IDisposable where TEentity : class
    {

        void Adicionar(TEentity obj);
        TEentity ObterPorId(Guid id);
        IEnumerable<TEentity> ObterTodos();
        void Atualizar(TEentity obj);
        void Remover(Guid id);
        IEnumerable<TEentity> Buscar(Expression<Func<TEentity, bool>> predicate);
        int SaveChanges();


    }
}
