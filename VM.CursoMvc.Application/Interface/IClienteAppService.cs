using System;
using System.Collections.Generic;
using VM.CursoMvc.Application.ViewModels;

namespace VM.CursoMvc.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        ClienteViewModel ObterPorId(Guid id);
        IEnumerable<ClienteViewModel> ObterTodos();
        void Atualizar(ClienteViewModel obj);
        void Adicionar(ClienteEnderecoViewModel obj);
        void Remover(Guid id);
        int SaveChanges();
    }
}