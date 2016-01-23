using AutoMapper;
using VM.CursoMvc.Application.ViewModels;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
       
        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
        }
    }
}
