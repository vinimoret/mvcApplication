using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Domain.Interfaces.Repository;

namespace VM.CursoMvc.Domain.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
    }
}