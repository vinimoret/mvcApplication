using System.Linq;
using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Domain.Interfaces;

namespace VM.CursoMvc.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente> , IClienteRepository
    {

        public Cliente ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }
    }
}