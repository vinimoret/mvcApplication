using System;
using System.Collections.Generic;
using AutoMapper;
using VM.CursoMvc.Application.Interface;
using VM.CursoMvc.Application.ViewModels;
using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Infra.Data.Repository;

namespace VM.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        public ClienteViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRepository.ObterPorCpf(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRepository.ObterPorEmail(email));
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRepository.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.ObterTodos());
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
            _clienteRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
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

        public void Adicionar(ClienteEnderecoViewModel clienteEnederecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnederecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnederecoViewModel);

            cliente.Enderecos.Add(endereco);

            _clienteRepository.Adicionar(cliente);
        }
    }
}