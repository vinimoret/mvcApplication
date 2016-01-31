using System;
using System.Collections.Generic;
using AutoMapper;
using VM.CursoMvc.Application.Interface;
using VM.CursoMvc.Application.ViewModels;
using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Domain.Interfaces.Services;

namespace VM.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        public ClienteViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorCpf(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorEmail(email));
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.ObterTodos());
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
            _clienteService.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteService.Remover(id);
        }

        public int SaveChanges()
        {
            return _clienteService.SaveChanges();
        }

        public void Dispose()
        {
            _clienteService.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Adicionar(ClienteEnderecoViewModel clienteEnederecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnederecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnederecoViewModel);

            cliente.Enderecos.Add(endereco);

            _clienteService.Adicionar(cliente);
        }
    }
}