using System;
using System.Collections.Generic;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        void Atualizar(Cliente obj);
        void Adicionar(Cliente obj);
        void Remover(Guid id);
        int SaveChanges();
        void Dispose();
    }
}