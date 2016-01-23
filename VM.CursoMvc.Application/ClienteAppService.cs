using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using VM.CursoMvc.Application.Interface;
using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Infra.Data.Repository;

namespace VM.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        public Cliente ObterPorCpf(string cpf)
        {
           _clienteRepository.ObterPorCpf(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
           return  _clienteRepository.ObterPorEmail(email);
        }

        public void Adicionar(Cliente cliente)
        {
           _clienteRepository.Adicionar(cliente); 
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Atualizar(Cliente cliente)
        {
           _clienteRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate)
        {
           return _clienteRepository.Buscar(predicate);
        }

        public int SaveChanges()
        {
            return _clienteRepository.SaveChanges();
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}