using System;
using System.Collections.Generic;
using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Domain.Interfaces;
using VM.CursoMvc.Domain.Interfaces.Services;

namespace VM.CursoMvc.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente ObterPorCpf(string cpf)
        {
            return _clienteRepository.ObterPorCpf(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
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
            _clienteRepository.Adicionar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public int SaveChanges()
        {
            return _clienteRepository.SaveChanges();
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
        }
        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        
    }
}