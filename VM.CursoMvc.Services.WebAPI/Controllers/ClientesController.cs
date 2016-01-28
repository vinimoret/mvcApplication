using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VM.CursoMvc.Application;
using VM.CursoMvc.Application.ViewModels;

namespace VM.CursoMvc.Services.WebAPI.Controllers
{
    public class ClientesController : ApiController
    { 
        private readonly ClienteAppService _clienteAppService = new ClienteAppService();

        // GET: api/Clientes
        public IEnumerable<ClienteViewModel> Get()
        {
            return _clienteAppService.ObterTodos();
        }

        // GET: api/Clientes/5
        public ClienteViewModel Get(Guid id)
        {
            return _clienteAppService.ObterPorId(id);
        }

        // POST: api/Clientes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }
    }
}
