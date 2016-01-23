using System;
using AutoMapper;

using VM.CursoMvc.Application.ViewModels;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
     
        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
        }
    }
}
