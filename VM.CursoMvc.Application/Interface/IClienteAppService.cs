using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);

        void Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        void Atualizar(Cliente obj);
        void Remover(Guid id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate);
        int SaveChanges();
    }
}