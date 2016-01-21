using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using VM.CursoMvc.Domain.Entities;

namespace VM.CursoMvc.Infra.Data.EntityConfig
{
    public class ClienteConfiguration :EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            //composed key
            //HasKey(c => new {c.CPF, c.ClienteId});

            Property(c => c.Nome)
                .IsRequired()
                //change column name
                //.HasColumnName("Cliente_Nome")
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired().HasMaxLength(100);

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute(){IsUnique = true}));

            ToTable("Clientes");
        }
    }
}