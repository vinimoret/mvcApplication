using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using VM.CursoMvc.Domain.Entities;
using VM.CursoMvc.Domain.Interfaces;

namespace VM.CursoMvc.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente> , IClienteRepository
    {

        public Cliente ObterPorCpf(string cpf)
        {
            var sql = @"select * from clientes c "+
                "inner join endereco e "+
                "on c.clienteId = e.ClienteId"+
                "Where c.cpf = @cpf";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql, (c, e) =>
                {
                    c.Enderecos.Add(e);
                    return c;
                },
                    new {cpf = cpf}
                    );
                return cliente.FirstOrDefault();

            }


        }

        public Cliente ObterPorEmail(string email)
        {
            var sql = @"select * from clientes c "+
                "inner join enderecos e "+
                "on c.ClienteId = e.ClienteId" +
                "Where c.email = @email";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();
               var cliente =  cn.Query<Cliente, Endereco, Cliente>(sql, (c, e) =>
                {
                    c.Enderecos.Add(e);
                    return c;
                },
                new { email = email}
                );

                return cliente.FirstOrDefault();
            }
        }

        public override Cliente ObterPorId(Guid id)
        {
            var sql = @"select * from clientes c " +
                      "inner join enderecos e " +
                      "on c.ClienteId = e.ClienteId " +
                      "Where c.ClienteId = @sid";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) =>
                    {
                        c.Enderecos.Add(e);
                        return c;
                    },
                    new{sid = id}, splitOn:"ClienteId,EnderecoId");

                return cliente.FirstOrDefault();

            }
        }

        public override IEnumerable<Cliente> ObterTodos()
        {
            var sql = @"select * from clientes";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente>(sql);

                return cliente.ToList();
            }
        } 
    }
}